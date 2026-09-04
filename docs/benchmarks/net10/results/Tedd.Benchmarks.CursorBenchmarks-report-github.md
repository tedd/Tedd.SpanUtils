```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.9168/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5950X 3.40GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.7.26381.103
  [Host]   : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3

Job=ShortRun  Runtime=.NET 10.0  IterationCount=3
LaunchCount=1  WarmupCount=3

```
| Method             | Categories               | Mean       | Error      | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |------------------------- |-----------:|-----------:|----------:|------:|--------:|----------:|------------:|
| ArchivedMemoryCopy | MemoryStreamer 1KiB copy | 27.6718 ns |  6.6790 ns | 0.3661 ns |  1.00 |    0.02 |         - |          NA |
| CurrentMemoryCopy  | MemoryStreamer 1KiB copy | 31.9735 ns | 33.5640 ns | 1.8398 ns |  1.16 |    0.06 |         - |          NA |
|                    |                          |            |            |           |       |         |           |             |
| ArchivedMovingSpan | Moving span roundtrip    |  0.8349 ns |  0.3384 ns | 0.0185 ns |  1.00 |    0.03 |         - |          NA |
| CurrentMovingSpan  | Moving span roundtrip    |  1.0045 ns |  0.2220 ns | 0.0122 ns |  1.20 |    0.03 |         - |          NA |
|                    |                          |            |            |           |       |         |           |             |
| ArchivedSpanStream | SpanStream roundtrip     |  1.4617 ns |  1.2814 ns | 0.0702 ns |  1.00 |    0.06 |         - |          NA |
| CurrentSpanStream  | SpanStream roundtrip     |  1.4906 ns |  2.5663 ns | 0.1407 ns |  1.02 |    0.09 |         - |          NA |
