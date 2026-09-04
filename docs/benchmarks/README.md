# Benchmarks

[Measured results and regressions](RESULTS.md) · [Moving-span experiment](net10-moving/README.md) · [VLQ experiment](net11-vlq/README.md)

The BenchmarkDotNet suite compares version 2 with the [archived local version 1 snapshot](../../archive/v1/README.md) using the same benchmark executable and target framework. BenchmarkDotNet launches an isolated process for each measured case. The archived library has its own assembly name and is referenced through `extern alias archive`. All benchmark inputs, buffer sizes, loop counts, and runtime settings match between versions. `GlobalSetup` verifies encoded bytes and returned values before each benchmark runs.

## Run

Run from the repository root using a Release build. The default command uses BenchmarkDotNet's normal statistical run; `--short` selects its three-measurement ShortRun for exploratory measurements.

```powershell
# Validate all benchmark workloads without timing.
dotnet run -c Release -f net10.0 --project src/Tedd.SpanUtils.Benchmark -- --validate

# Complete comparative suite on .NET 10.
dotnet run -c Release -f net10.0 --project src/Tedd.SpanUtils.Benchmark -- --filter '*'

# Short exploratory suite, with reports in a chosen directory.
dotnet run -c Release -f net10.0 --project src/Tedd.SpanUtils.Benchmark -- --short --filter '*' --artifacts docs/benchmarks/net10

# .NET 11 preview, requiring a matching SDK and runtime.
dotnet run -c Release -f net11.0 -p:EnableNet11=true --project src/Tedd.SpanUtils.Benchmark -- --short --filter '*' --artifacts docs/benchmarks/net11

# .NET 6, requiring the .NET 6 runtime.
dotnet run -c Release -f net6.0 --project src/Tedd.SpanUtils.Benchmark -- --short --filter '*'

# Restrict runs while investigating an implementation.
dotnet run -c Release -f net10.0 --project src/Tedd.SpanUtils.Benchmark -- --filter '*BulkEndian*'
```

The benchmark dependency is pinned per target: [0.14.0](https://www.nuget.org/packages/BenchmarkDotNet/0.14.0) for .NET 6, [0.15.8](https://www.nuget.org/packages/BenchmarkDotNet/0.15.8) for .NET 10, and [0.16.0-preview.1](https://www.nuget.org/packages/BenchmarkDotNet/0.16.0-preview.1) for .NET 11. This preserves compatible .NET 6 tooling dependencies and uses native .NET 11 benchmark support. Both library versions use the same engine and runtime within each comparison. Cross-runtime differences cannot be attributed solely to the JIT because the benchmark engine also differs. The selected host framework determines which target of each library is compiled. No in-process timing shortcut is used. The .NET 11 target is opt-in because .NET 11 is a preview at the time of these measurements.

## Workloads

| Workload | Work per reported operation | Inputs |
| --- | --- | --- |
| Int32LE roundtrip | One integer write and read | 128 values per invocation; byte buffer starts at offset 1 |
| Int64BE roundtrip | One integer write and read | 128 values per invocation; byte buffer starts at offset 1 |
| VLQ roundtrip | One unsigned 64-bit write and read | Repeated mix of 0, 127, 128, 16384, UInt32.MaxValue, 2^42, 2^56, UInt64.MaxValue |
| UTF8 write/read | One sized string | Four repetitions of a mixed ASCII/Norwegian/Japanese/emoji string |
| Moving span roundtrip | One Int64 write and read | 128 sequential values using ref-span cursor advancement |
| SpanStream roundtrip | One Int64 write and read | 128 sequential values; cursor construction and reset included |
| MemoryStreamer 1KiB copy | One write plus one read | Reused stream instances and preallocated source/destination arrays |
| Bulk endian | One entire 64- or 4096-element block | Version 1 scalar Int32 BE reads versus version 2 bulk endianness reversal |

All allocations of input buffers and reusable stream objects occur in setup. `MemoryDiagnoser` includes allocations made by the measured methods; decoding a string necessarily allocates its returned string. Integer methods return an accumulated value; bulk output is retained in instance arrays and its last element is returned. Times for roundtrips include the loop/cursor work stated above, not just an isolated CPU instruction.

The bulk comparison measures a new batch API against the scalar sequence available in version 1. It is not a like-for-like scalar method replacement. That comparison requires a little-endian host; setup rejects big-endian hosts rather than silently comparing different transformations. The remaining suite does not require a particular CPU instruction set.

## Interpretation

Ratios compare version 2 with the archived baseline for the same workload and runtime; lower is faster. A ShortRun has broad confidence intervals and is useful for identifying substantial changes, not for asserting small differences. Repeat the default run on the intended deployment hardware before drawing conclusions from changes near measurement noise. Results depend on CPU, power policy, JIT, runtime version, and workload shape. Run one benchmark job at a time and avoid competing CPU-intensive work.

Malformed or truncated data is covered by correctness tests, not timed as a successful decode. The archived local snapshot contains compilation defects repaired only in an intermediate build file; none of the repaired methods is a benchmark subject. Version 2 also adds validation and correct stream semantics, so small costs can reflect stronger behavior guarantees.
