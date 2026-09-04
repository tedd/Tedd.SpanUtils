```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 10.0  IterationCount=3
LaunchCount=1  WarmupCount=3  Categories=Moving span roundtrip

```
| Method             | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| ArchivedMovingSpan | 0.9461 ns | 0.3325 ns | 0.0182 ns |  1.00 |    0.02 |         - |          NA |
| CurrentMovingSpan  | 1.2352 ns | 1.0668 ns | 0.0585 ns |  1.31 |    0.06 |         - |          NA |
