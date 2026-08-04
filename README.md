# Tedd.SpanUtils
Utilities for reading/writing to span.

Available on NuGet: https://www.nuget.org/packages/Tedd.SpanUtils

Span<byte> extension methods to read or write SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, String, byte\[\], span<byte>.
There is also an UInt24 type which can be cast to/from UInt32 and used for reading/writing 3-byte integers.

`MoveWrite()` and `MoveRead*()` moves Span pointer ahead so that the span function as a stream streamwriter and streamreader.

100% code coverage in unit tests.

## Architectural Paradigms and Epistemological Scope

**Implemented Facts:**
Tedd.SpanUtils operates exclusively as a low-level .NET library designed for memory-safe `Span<byte>` and `Memory<byte>` manipulation. Its core operational capabilities are executed via deterministic pointer advancement methods (e.g., `MoveRead*` and `MoveWrite*`) and stream-like memory abstractions (`SpanStream` and `MemoryStreamer`).

**Roadmap Hypotheses:**
To mitigate speculative assumptions, it must be explicitly delineated that the framework does *not* currently possess high-level UI architecture. Features such as hierarchical data binding, routed event infrastructure, and retro-computing DOS-era controls operating with modern binding contexts are purely hypothetical constructs planned for future architectural iterations. Fabricating these operational capabilities within the current iteration constitutes a structural defect.

# Example
```csharp
using System;
using Tedd;

var mem = new byte[1000];
var span = new Span<byte>(mem);

Int32 a = 1234;
span.Write(a);
var b = span.ReadInt32();
// a == b


// Move* methods advance the Span pointer during read or write operations.
Int16 a1 = 10;
Int32 a2 = 20;
Int64 a3 = 30;
span.MoveWrite(a1);
span.MoveWrite(a2);
span.MoveWrite(a3);

// To recommence reading from the origin, a new Span reference pointing to the memory area's beginning is required.
var span2 = new Span<byte>(mem);

var b1 = span2.MoveReadInt16();
var b2 = span2.MoveReadInt32();
var b3 = span2.MoveReadInt64();

// a1 == b1
// a2 == b2
// a3 == b3

```



# Move read/write
Move read/write will slice the current span so that it moves forward in memory area.
## Example
```csharp
using System;
using Tedd;

var mem = new byte[10];
var span = new Span<byte>(mem);
// span is initialized to point to index 0 of mem, with a length of 10 bytes.
var i = span.MoveReadInt32();
// As Int32 occupies 4 bytes, the span pointer is advanced by 4 bytes.
// span now points to index 4 of mem, with a residual length of 6 bytes.
```

# WriteSize() / ReadSize()
`WriteSize()` and `ReadSize()` to write and read size to span. These methods employ a compression technique utilizing the two most significant bits to define the byte length of the size descriptor.

Values requiring 6 bits or fewer (less than 64) occupy 1 byte.<br />
Values requiring 14 bits or fewer (less than 16,384) occupy 2 bytes.<br />
Values requiring 22 bits or fewer (less than 4,194,304) occupy 3 bytes.<br />
Values requiring 30 bits or fewer (less than 1,073,741,824) occupy 4 bytes.<br />

Consequently, invoking `WriteSized("hello")` consumes 1 byte for the size header and 5 bytes for the string content. Conversely, invoking `WriteSized(new byte[20_000])` consumes 3 bytes for the size header.

To calculate the total bytes occupied by the size descriptor, execute `(firstByte >> 6) + 1`, yielding a result between 1 and 4.

# Sized writes
Data types such as String, byte\[\], Span<> and ReadOnlySpan<> are supported via `WriteSized()`. This operation prepends a 1-4 byte size descriptor, negating the requirement for predetermined size knowledge when invoking `ReadSized*()`;

# Variable-Length Quantity
Sized writes offer optimized processing efficiency by localizing length metadata within the first two bits, facilitating immediate determination of total required bytes. This approach is bounded to 30-bit integers due to the 2-bit descriptor allocation.

Variable-Length Quantity (VLQ) provides an alternative numerical encoding paradigm. While variations exist, the primary implementation utilizes the most significant bit of each byte as a continuation flag. For signed integers, the second bit of the initial byte functions as the sign indicator.

WriteVLQ() and ReadVLQ\*() methods provide this functionality.

16-bit: 1-3 bytes.
32-bit: 1-5 bytes.
64-bit: 1-10 bytes.

## String
Strings undergo UTF-8 encoding prior to writing.

In .NET Core and newer environments, allocation-free operations mitigate Large Object Heap (LOH) fragmentation. Given the variable length of UTF-8, the requisite size is preemptively determined via `Encoding.UTF8.GetByteCount`, necessitating a two-pass operation (calculation followed by copying).

In legacy .NET Framework (4.x) environments, a short-lived byte array functions as an intermediary UTF-8 buffer.

## NOTE
Implementation via extension methods necessitates a defensive copy of minor byte structures during invocation, an inherent characteristic of the C# compiler architecture.
