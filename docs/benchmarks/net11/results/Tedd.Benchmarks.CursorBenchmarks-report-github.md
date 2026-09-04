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
| Method             | Categories               | Mean       | Error      | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |------------------------- |-----------:|-----------:|----------:|------:|--------:|----------:|------------:|
| ArchivedMemoryCopy | MemoryStreamer 1KiB copy | 48.9879 ns | 57.4916 ns | 3.1513 ns |  1.00 |    0.00 |         - |          NA |
| CurrentMemoryCopy  | MemoryStreamer 1KiB copy | 55.0332 ns | 31.1439 ns | 1.7071 ns |  1.13 |    0.07 |         - |          NA |
|                    |                          |            |            |           |       |         |           |             |
| ArchivedMovingSpan | Moving span roundtrip    |  0.8726 ns |  0.0913 ns | 0.0050 ns |  1.00 |    0.00 |         - |          NA |
| CurrentMovingSpan  | Moving span roundtrip    |  1.1060 ns |  0.1574 ns | 0.0086 ns |  1.27 |    0.01 |         - |          NA |
|                    |                          |            |            |           |       |         |           |             |
| ArchivedSpanStream | SpanStream roundtrip     |  2.5055 ns |  0.1777 ns | 0.0097 ns |  1.00 |    0.00 |         - |          NA |
| CurrentSpanStream  | SpanStream roundtrip     |  2.1322 ns |  0.1375 ns | 0.0075 ns |  0.85 |    0.00 |         - |          NA |
