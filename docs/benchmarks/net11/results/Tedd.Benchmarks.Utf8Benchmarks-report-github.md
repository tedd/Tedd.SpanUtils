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
| Method        | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------- |----------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| ArchivedRead  | UTF8 read  | 147.71 ns |  35.00 ns |  1.918 ns |  1.00 |    0.00 | 0.0253 |     424 B |        1.00 |
| CurrentRead   | UTF8 read  | 155.27 ns | 278.77 ns | 15.280 ns |  1.05 |    0.09 | 0.0253 |     424 B |        1.00 |
|               |            |           |           |           |       |         |        |           |             |
| ArchivedWrite | UTF8 write |  91.93 ns |  44.59 ns |  2.444 ns |  1.00 |    0.00 |      - |         - |          NA |
| CurrentWrite  | UTF8 write |  84.52 ns | 147.44 ns |  8.081 ns |  0.92 |    0.08 |      - |         - |          NA |
