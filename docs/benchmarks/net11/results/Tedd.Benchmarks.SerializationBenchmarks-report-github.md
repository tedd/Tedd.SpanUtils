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
| Method          | Categories        | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------- |------------------ |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| ArchivedInt32LE | Int32LE roundtrip | 1.488 ns | 1.3239 ns | 0.0726 ns |  1.00 |    0.00 |         - |          NA |
| CurrentInt32LE  | Int32LE roundtrip | 1.140 ns | 1.6810 ns | 0.0921 ns |  0.77 |    0.06 |         - |          NA |
|                 |                   |          |           |           |       |         |           |             |
| ArchivedInt64BE | Int64BE roundtrip | 4.463 ns | 0.4382 ns | 0.0240 ns |  1.00 |    0.00 |         - |          NA |
| CurrentInt64BE  | Int64BE roundtrip | 1.446 ns | 0.4806 ns | 0.0263 ns |  0.32 |    0.01 |         - |          NA |
|                 |                   |          |           |           |       |         |           |             |
| ArchivedVLQ     | VLQ roundtrip     | 6.071 ns | 8.8221 ns | 0.4836 ns |  1.00 |    0.00 |         - |          NA |
| CurrentVLQ      | VLQ roundtrip     | 7.533 ns | 2.2852 ns | 0.1253 ns |  1.25 |    0.08 |         - |          NA |
