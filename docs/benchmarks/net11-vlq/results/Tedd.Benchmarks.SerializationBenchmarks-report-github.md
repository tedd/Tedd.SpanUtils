```

BenchmarkDotNet v0.16.0-preview.1, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
Memory: 56.67 GB Total, 14.23 GB Available
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 11.0.0 (11.0.0-preview.7.26381.103, 11.0.26.38203), X64 RyuJIT x86-64-v3
  ShortRun : .NET 11.0.0 (11.0.0-preview.7.26381.103, 11.0.26.38203), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 11.0  Arguments=/p:EnableNet11=true
IterationCount=3  LaunchCount=1  WarmupCount=3
Categories=VLQ roundtrip

```
| Method      | Mean      | Error    | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------ |----------:|---------:|----------:|------:|--------:|----------:|------------:|
| ArchivedVLQ |  9.071 ns | 3.177 ns | 0.1741 ns |  1.00 |    0.00 |         - |          NA |
| CurrentVLQ  | 11.478 ns | 3.528 ns | 0.1934 ns |  1.27 |    0.03 |         - |          NA |
