```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 10.0  IterationCount=3
LaunchCount=1  WarmupCount=3

```
| Method        | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------- |----------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| ArchivedRead  | UTF8 read  | 166.51 ns | 418.65 ns | 22.947 ns |  1.01 |    0.17 | 0.0253 |     424 B |        1.00 |
| CurrentRead   | UTF8 read  | 163.76 ns | 198.81 ns | 10.898 ns |  1.00 |    0.12 | 0.0253 |     424 B |        1.00 |
|               |            |           |           |           |       |         |        |           |             |
| ArchivedWrite | UTF8 write |  97.69 ns | 253.91 ns | 13.918 ns |  1.01 |    0.18 |      - |         - |          NA |
| CurrentWrite  | UTF8 write |  90.37 ns |  88.46 ns |  4.849 ns |  0.94 |    0.13 |      - |         - |          NA |
