```

BenchmarkDotNet v0.16.0-preview.1, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
Memory: 56.67 GB Total, 14.53 GB Available
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 11.0.0 (11.0.0-preview.7.26381.103, 11.0.26.38203), X64 RyuJIT x86-64-v3
  ShortRun : .NET 11.0.0 (11.0.0-preview.7.26381.103, 11.0.26.38203), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 11.0  Arguments=/p:EnableNet11=true
IterationCount=3  LaunchCount=1  WarmupCount=3

```
| Method               | Length | Mean         | Error        | StdDev      | Ratio | Allocated | Alloc Ratio |
|--------------------- |------- |-------------:|-------------:|------------:|------:|----------:|------------:|
| **ArchivedScalarReadBE** | **64**     |    **90.782 ns** |    **87.820 ns** |   **4.8137 ns** |  **1.00** |         **-** |          **NA** |
| CurrentBulkReverse   | 64     |     5.222 ns |     6.075 ns |   0.3330 ns |  0.06 |         - |          NA |
|                      |        |              |              |             |       |           |             |
| **ArchivedScalarReadBE** | **4096**   | **4,573.101 ns** | **3,657.323 ns** | **200.4702 ns** |  **1.00** |         **-** |          **NA** |
| CurrentBulkReverse   | 4096   |   237.012 ns |   199.631 ns |  10.9425 ns |  0.05 |         - |          NA |
