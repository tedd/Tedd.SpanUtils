```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 10.0  IterationCount=3
LaunchCount=1  WarmupCount=3

```
| Method               | Length | Mean         | Error         | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |------- |-------------:|--------------:|-----------:|------:|--------:|----------:|------------:|
| **ArchivedScalarReadBE** | **64**     |    **97.753 ns** |     **93.330 ns** |   **5.116 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CurrentBulkReverse   | 64     |     7.558 ns |     38.981 ns |   2.137 ns |  0.08 |    0.02 |         - |          NA |
|                      |        |              |               |            |       |         |           |             |
| **ArchivedScalarReadBE** | **4096**   | **6,321.829 ns** | **15,886.173 ns** | **870.775 ns** |  **1.01** |    **0.18** |         **-** |          **NA** |
| CurrentBulkReverse   | 4096   |   273.691 ns |    184.164 ns |  10.095 ns |  0.04 |    0.01 |         - |          NA |
