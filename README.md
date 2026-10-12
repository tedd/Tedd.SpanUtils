# Tedd.SpanUtils

Binary serialization over caller-owned `Span<byte>`, `ReadOnlySpan<byte>`, and `Memory<byte>`. Read and write primitives, length-prefixed UTF-8 and byte sequences, variable-length integers, and fixed-capacity streams without an intermediate buffer.

## Architectural Paradigms and Epistemological Scope

This framework is rigorously architected as a low-level, memory-safe manipulation and binary serialization infrastructure. Its functional scope is strictly bounded to deterministic byte sequence processing without abstraction overhead.

**Established Framework Capabilities:**
- High-performance, zero-allocation binary serialization over `Span<byte>`, `ReadOnlySpan<byte>`, and `Memory<byte>`.
- Hardware-intrinsics accelerated endian conversion and variable-length integer encoding (VLQ, EBML VInt).
- Stream adapters for caller-owned spans (`SpanStream`, `MemoryStreamer`) that avoid intermediate buffer allocations.

**Planned Future Enhancements (Hypotheses):**
- Hierarchical data binding infrastructure.
- Routed event mechanics and unified UI integration contexts.
- Retro-computing DOS-era controls operating with modern binding contexts.

These roadmap hypotheses represent speculative theoretical models, not operational reality. Developers must not assume the presence of high-level UI architectures, hierarchical data binding, or routed events within the current execution flow. The architectural boundary is strictly confined to memory manipulation.

## Installation and supported targets

```sh
dotnet add package Tedd.SpanUtils --version 2.0.0
```

| Target | Included in the standard package | Implementation |
| --- | --- | --- |
| .NET Standard 2.1 | Yes | Portable span operations and scalar bulk conversion |
| .NET 6 | Yes | Hardware bit counting, `Half`, allocation-free decimal encoding |
| .NET 10 | Yes | Vectorized bulk endian conversion, `Int128`/`UInt128`, direct endian-aware GUID APIs |
| .NET 11 preview | Opt-in source build | Same intrinsic-backed implementation, compiled and benchmarked against the preview JIT |

.NET Framework, .NET Standard 2.0, and .NET versions below 6 are no longer targeted. Applications on .NET 7–9 can consume the .NET 6 asset. The library has no runtime NuGet dependencies.

## Quick start

Import the `Tedd` namespace. Fixed-width writes infer the type from the value; reads name the type explicitly. Use `LE` or `BE` for a portable byte order.

```csharp
using System;
using Tedd;

Span<byte> buffer = stackalloc byte[128];
var writer = new SpanStream(buffer, length: 0);
writer.WriteBE(42);
writer.WriteSized("Hello, world!");

var reader = new ReadOnlySpanStream(writer.WrittenSpan);
int number = reader.ReadInt32BE();
string message = reader.ReadSizedString();
```

Buffers are fixed in size. The caller controls allocation, lifetime, and ownership. Span streams are stack-only `ref struct` values; memory streams are `System.IO.Stream` subclasses.

## Span operations

Ordinary operations start at offset zero and leave the supplied span unchanged:

```csharp
Span<byte> bytes = stackalloc byte[8];
bytes.WriteBE(0x0102030405060708L);
long value = bytes.ReadInt64BE();

if (bytes.TryReadInt64BE(out long decoded))
{
    // A complete value was available.
}
```

`Move` operations advance a span by reference after successful processing:

```csharp
Span<byte> storage = stackalloc byte[32];
Span<byte> output = storage;
output.MoveWriteLE(123);
output.MoveWriteVLQ(300UL);

ReadOnlySpan<byte> input = storage.Slice(0, storage.Length - output.Length);
int first = input.MoveReadInt32LE();
ulong second = input.MoveReadVLQUInt64();
```

The static equivalents are available on `SpanUtils`, for example `SpanUtils.ReadInt32BE(bytes)` and `SpanUtils.MoveWriteLE(ref output, 123)`. Overloads with `out int length` report the complete number of bytes consumed or written.

### Supported values

| Value | Operations and encoding |
| --- | --- |
| `byte`, `sbyte`, `bool`, `char` | Fixed-width read/write; `char` is one UTF-16 code unit |
| 16-, 32-, and 64-bit signed/unsigned integers | Native, LE, and BE read/write |
| `UInt24` and signed 24-bit integers | Three-byte values; signed operations are named `ReadInt24` / `WriteInt24` |
| `float`, `double`, `decimal` | Native, LE, and BE read/write |
| `Half` | Two-byte floating point on .NET 6+ |
| `Int128`, `UInt128` | Sixteen-byte integers in the .NET 10/11 assets |
| `Guid` | Default/LE matches `Guid.ToByteArray()`; BE uses RFC 4122 byte order |
| Byte arrays and spans | Raw and length-prefixed operations |
| Strings | Raw UTF-8 (`ReadString(byteLength)` / `WriteString`) and length-prefixed UTF-8 |
| VLQ | Signed and unsigned 16/32/64-bit integers, plus unsigned 24-bit |
| EBML VInt | One to eight bytes, including detection of unknown-size markers |

Fixed-width values expose `TryRead*`, `TryWrite*`, `TryMoveRead*`, and `TryMoveWrite*` variants. A failed `Try` operation returns `false` without advancing the cursor or changing the destination. Variable-length `Try` methods also reject truncated and overflowing encodings.

### Byte order and decimal layout

Methods without an endian suffix use native machine byte order for ordinary primitives. The three-byte integer format is little endian by default, preserving the original format. Use explicit suffixes for files and network protocols.

`decimal` without a suffix retains the CLR's native memory layout. Portable `decimal` LE/BE methods encode four 32-bit words in `decimal.GetBits` order: low, middle, high, flags. Each word uses the requested byte order. Readers validate flags and scale. Portable decimal writes allocate an `int[4]` only in the .NET Standard 2.1 asset; .NET 6+ uses stack storage.

### Length-prefixed data and zero-copy reads

`WriteSized` prefixes the payload with its byte length. `ReadSizedString` returns a new string; `ReadSizedBytes` returns a new array. Use `ReadSizedSpan` or `ReadSizedReadOnlySpan` to obtain a view into the existing buffer:

```csharp
Span<byte> packet = stackalloc byte[64];
packet.WriteSized(new byte[] { 10, 20, 30 });
ReadOnlySpan<byte> payload = ((ReadOnlySpan<byte>)packet).ReadSizedReadOnlySpan();
```

The top two bits of the first byte specify prefix width; the remaining bits encode the length in big endian order:

| Payload length | Prefix size |
| --- | --- |
| 0–63 | 1 byte |
| 64–16,383 | 2 bytes |
| 16,384–4,194,303 | 3 bytes |
| 4,194,304–1,073,741,823 | 4 bytes |

`MeasureWriteSize` calculates prefix size. String lengths count UTF-8 bytes, not characters. UTF-8 uses the framework's replacement fallback for malformed text. Writing a string does not allocate an intermediate byte array. Returned spans alias their source and share its lifetime.

### Variable-length integers

`WriteVLQ` and `ReadVLQ*` preserve the library's existing wire format: low-order groups first, with the high bit marking continuation. Signed values use six magnitude bits and a sign bit in the first byte; a single `0x40` represents the minimum value of the destination signed type. This signed format is distinct from ZigZag and signed LEB128.

`MeasureVLQ` returns encoded width. Readers reject truncation and values outside the requested integer range.

`WriteVInt` / `ReadVInt` implement EBML variable-length integers with a leading width marker. `VInt.GetSize` reserves all-one payloads for unknown sizes and rejects values above `VInt.MaxValue`. `VInt.IsUnknown` identifies an unknown-size marker read from a buffer.

## Stream adapters

| Adapter | Storage | Writable | Inherits `Stream` |
| --- | --- | --- | --- |
| `SpanStream` | `Span<byte>` | Yes | No |
| `ReadOnlySpanStream` | `ReadOnlySpan<byte>` | No | No |
| `MemoryStreamer` | `Memory<byte>` | Yes | Yes |
| `ReadOnlyMemoryStreamer` | `ReadOnlyMemory<byte>` | No | Yes |

A one-argument constructor treats the entire buffer as readable content. Pass `length: 0` to a writable adapter to start an empty writer. `Length` is the readable content size; `Capacity` / `MaxLength` is the fixed backing-buffer size. `WrittenSpan` or `WrittenMemory` exposes the logical content.

Memory adapters also provide `ReadMemory` and `ReadSizedMemory`: zero-copy `Memory<byte>` or `ReadOnlyMemory<byte>` views suitable for asynchronous code. `WriteMemory`, `WriteSizedMemory`, and their `Try` counterparts accept memory without an intermediate array. All four adapters expose `Try` operations and `Remaining`. Reads stop at `Length`. Standard `Read` returns the available byte count; `ReadExactly` requires the complete request. Typed reads require a complete value. Position changes and seeking do not grow the logical length; successful writes do. Gaps created by seeking past the end are zeroed when a subsequent write extends the content. `SetLength` clears newly exposed bytes and clamps the position when shrinking.

`MemoryStreamer.ReadByte()` and its read-only counterpart follow `Stream`: an `int` result, or `-1` at EOF. Span/memory I/O overrides avoid the base class's temporary-array path. Disposing a memory adapter closes the adapter without disposing caller-owned memory. `Clear()` erases logical content and resets position and length; `Clear(all: true)` erases the entire capacity.

## Performance and benchmarks

The implementation uses checked `MemoryMarshal` loads, `BinaryPrimitives`, direct cursor advancement, and zero-copy payload views. Bulk endian conversion supports in-place and overlapping buffers:

```csharp
int[] source = { 0x01020304, 0x05060708 };
int[] destination = new int[source.Length];
SpanUtils.ReverseEndianness(source, destination);
```

.NET 10/11 delegate bulk conversion to the runtime's vectorized implementation. The .NET Standard 2.1 and .NET 6 assets use a scalar fallback with equivalent overlap semantics. Small, inlinable span operations also let the .NET 11 JIT apply its [improved range-check elimination](https://github.com/dotnet/core/blob/main/release-notes/11.0/preview/preview5/runtime.md#redundant-span-and-null-checks). Preview results are measurements of the tested runtime, not guarantees for the final .NET 11 release.

The [benchmark report](https://github.com/tedd/Tedd.SpanUtils/blob/main/docs/benchmarks/README.md) includes runtime/hardware details, time and allocation measurements, limitations, and reproduction commands. The [archived implementation](https://github.com/tedd/Tedd.SpanUtils/blob/main/archive/v1/README.md) is built under a separate assembly alias and compared on identical workloads. Benchmark setup verifies output equivalence before timing. Historical ad hoc benchmark subjects are preserved in the archive.

```sh
dotnet run --project src/Tedd.SpanUtils.Benchmark -c Release -f net10.0 -- --validate
dotnet run --project src/Tedd.SpanUtils.Benchmark -c Release -f net10.0 -- --short --filter '*'
dotnet run --project src/Tedd.SpanUtils.Benchmark -c Release -f net11.0 -p:EnableNet11=true -- --short --filter '*'
```

Omit `--short` for longer measurements. Run one benchmark process at a time on an otherwise idle machine.

## Migrating from 1.x

Version 2 changes the following contracts:

- The minimum targets are .NET Standard 2.1 and .NET 6. The default build requires the .NET 10 SDK; preview builds require the .NET 11 SDK.
- Fixed-width operations check buffer bounds. Code relying on out-of-bounds access is invalid; short buffers now throw or produce a failed `Try` result.
- Explicit decimal LE/BE methods use the documented portable word layout. Old explicit-endian decimal data requires conversion. Explicit-endian `char` methods now honor byte order.
- Signed minimum VLQ values advance moving spans correctly. Overflowing or truncated variable-length values are rejected.
- VInt values must fit the EBML 1–8 byte format. Previously unbounded size calculations are rejected.
- `SpanStream.Length` is a read-only property; use `SetLength`. Seeking and position assignment no longer grow logical length. Reads honor logical length, and `Clear(all: true)` resets it.
- Read-only adapters reject mutation with `NotSupportedException`. Memory adapters enforce disposal and use the standard `Stream.ReadByte()` return type and EOF behavior.
- Invalid `UInt24` casts above `0xFFFFFF` are rejected by writers. Use `ToUInt24()` when deliberate truncation is required.

## Build and test

```sh
dotnet build src/Tedd.SpanUtils.sln -c Release
dotnet test src/Tedd.SpanUtils.Tests -c Release
dotnet test src/Tedd.SpanUtils.StandardTests -c Release
dotnet pack src/Tedd.SpanUtils -c Release -o artifacts/packages
```

Install the .NET 6 runtime to execute the minimum-runtime tests. The standard compatibility suite explicitly references the .NET Standard 2.1 asset and verifies which assembly it loads. CI tests .NET 6, .NET 10, the standard asset, and .NET 11 preview.

```sh
dotnet test src/Tedd.SpanUtils.Tests -c Release -f net11.0 -p:EnableNet11=true
```

### Regenerate APIs

Generated files are checked in. Edit the templates in `src/Tedd.SpanUtils.SourceGenerator`, then run from the repository root:

```sh
dotnet run --project src/Tedd.SpanUtils.SourceGenerator -c Release
```

The generator emits matching static, extension, moving-span, and stream APIs. Archived projects are reference material and are not shipped in the NuGet package.

## License

[GNU Lesser General Public License, version 3](LICENSE).
