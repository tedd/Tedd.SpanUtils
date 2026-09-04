# Measured results

Measured on 4 September 2026 using an AMD Ryzen 9 5950X, Windows 11 25H2, and SDK `11.0.100-preview.7.26381.103`. The runtimes were .NET `10.0.11` and .NET `11.0.0-preview.7.26381.103`. Each runtime completed 20 BenchmarkDotNet ShortRun cases with one launch, three warmups, and three measured iterations. Workloads passed setup validation before measurement.

Version 1 means the archived **local snapshot**, not a published NuGet binary or an upstream Git commit. See [provenance and source checksums](../../archive/v1/README.md). Both source versions were compiled in Release for the same target framework. BenchmarkDotNet 0.15.8 measured .NET 10; 0.16.0-preview.1 measured .NET 11. Compare versions within a runtime; engine differences prevent attributing cross-runtime changes solely to the JIT.

## Observed means

All times are nanoseconds. Roundtrip rows represent one write plus one read; copy and bulk rows represent the entire stated block. See [workload definitions](README.md#workloads) and the original reports below for confidence intervals and allocation statistics.

| Workload | .NET 10 v1 | .NET 10 v2 | .NET 11 v1 | .NET 11 v2 |
| --- | ---: | ---: | ---: | ---: |
| Int32 LE roundtrip | 0.7395 | 1.0236 | 1.488 | 1.140 |
| Int64 BE roundtrip | 4.0902 | 1.3375 | 4.463 | 1.446 |
| Unsigned VLQ roundtrip | 8.8838 | 8.7735 | 6.071 | 7.533 |
| Sized UTF-8 write | 97.69 | 90.37 | 91.93 | 84.52 |
| Sized UTF-8 read | 166.51 | 163.76 | 147.71 | 155.27 |
| Moving span Int64 roundtrip | 0.8349 | 1.0045 | 0.8726 | 1.1060 |
| SpanStream Int64 roundtrip | 1.4617 | 1.4906 | 2.5055 | 2.1322 |
| MemoryStreamer 1 KiB write + read | 27.6718 | 31.9735 | 48.9879 | 55.0332 |
| Bulk reverse, 64 Int32 values | 97.753 | 7.558 | 90.782 | 5.222 |
| Bulk reverse, 4096 Int32 values | 6321.829 | 273.691 | 4573.101 | 237.012 |

The observed Int64 big-endian roundtrip means improved by approximately **3.1×** on both runtimes. The new bulk API was approximately **13–23×** faster than the scalar sequence available in the archived version, depending on runtime and block size. These comparisons measure the same input/output transformation; the bulk result is a new batch API, not a scalar replacement.

Performance was not uniformly better. The .NET 10 Int32 LE case increased by approximately 0.28 ns, moving-span means increased by 20–27%, memory-stream copies by 13–16%, and the .NET 11 VLQ case by 25%. The archived LE reader performs an unchecked memory read; version 2 validates bounds. Version 2 also enforces overflow, cursor, logical-length, and stream-lifetime contracts. These requirements are retained. ShortRun confidence intervals are broad, and several workloads show substantial variability; the reported means do not establish small differences as statistically significant.

Both versions allocated **0 B/op** in every measured workload except UTF-8 decoding, which allocated **424 B/op** for its returned string. Reusable buffers and stream objects were allocated in setup.

## Original reports

Each Markdown report has a corresponding CSV alongside it.

| Runtime | Scalar and VLQ | Cursors and streams | UTF-8 | Bulk endian |
| --- | --- | --- | --- | --- |
| .NET 10 | [Report](net10/results/Tedd.Benchmarks.SerializationBenchmarks-report-github.md) | [Report](net10/results/Tedd.Benchmarks.CursorBenchmarks-report-github.md) | [Report](net10/results/Tedd.Benchmarks.Utf8Benchmarks-report-github.md) | [Report](net10/results/Tedd.Benchmarks.BulkEndianBenchmarks-report-github.md) |
| .NET 11 preview | [Report](net11/results/Tedd.Benchmarks.SerializationBenchmarks-report-github.md) | [Report](net11/results/Tedd.Benchmarks.CursorBenchmarks-report-github.md) | [Report](net11/results/Tedd.Benchmarks.Utf8Benchmarks-report-github.md) | [Report](net11/results/Tedd.Benchmarks.BulkEndianBenchmarks-report-github.md) |

A [moving-span snapshot experiment](net10-moving/README.md) and a [VLQ inlining experiment](net11-vlq/README.md) passed focused correctness tests but showed no measured improvement and were reverted. Their separate reports describe the rejected intermediate implementations. The main .NET 10 and .NET 11 reports above describe the retained implementation.

The .NET 6 benchmark target uses BenchmarkDotNet 0.14.0 for compatible tooling dependencies. It compiled successfully, and every benchmark workload passed `--validate` on .NET 6.0.36. No .NET 6 timing claim is made here.
