```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 10.0  IterationCount=3
LaunchCount=1  WarmupCount=3

```
| Method          | Categories        | Mean      | Error      | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------- |------------------ |----------:|-----------:|----------:|------:|--------:|----------:|------------:|
| ArchivedInt32LE | Int32LE roundtrip | 0.7395 ns |  0.6551 ns | 0.0359 ns |  1.00 |    0.06 |         - |          NA |
| CurrentInt32LE  | Int32LE roundtrip | 1.0236 ns |  1.0624 ns | 0.0582 ns |  1.39 |    0.09 |         - |          NA |
|                 |                   |           |            |           |       |         |           |             |
| ArchivedInt64BE | Int64BE roundtrip | 4.0902 ns |  0.8328 ns | 0.0457 ns |  1.00 |    0.01 |         - |          NA |
| CurrentInt64BE  | Int64BE roundtrip | 1.3375 ns |  0.2665 ns | 0.0146 ns |  0.33 |    0.00 |         - |          NA |
|                 |                   |           |            |           |       |         |           |             |
| ArchivedVLQ     | VLQ roundtrip     | 8.8838 ns | 16.6266 ns | 0.9114 ns |  1.01 |    0.12 |         - |          NA |
| CurrentVLQ      | VLQ roundtrip     | 8.7735 ns | 12.8923 ns | 0.7067 ns |  0.99 |    0.11 |         - |          NA |
