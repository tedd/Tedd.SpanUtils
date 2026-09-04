# Rejected moving-span experiment

These measurements evaluate an intermediate implementation that was reverted. They do not describe the final version 2 implementation.

The experiment copied the moving span into a local, computed the remaining slice before accessing the data, and committed the caller's reference after success. It preserved bounds validation and passed the focused correctness tests, but showed no performance benefit: the measured version 2/archived ratio was 1.31, compared with 1.20 for the retained implementation in the full .NET 10 suite. Both runs used BenchmarkDotNet ShortRun and have broad confidence intervals.

The generator change was reverted and regenerated. The [main .NET 10 cursor report](../net10/results/Tedd.Benchmarks.CursorBenchmarks-report-github.md) measures the retained implementation. This experiment is retained to document the rejected optimization, not to claim a statistically established difference between the two version 2 implementations.

Reproduction of the measurement command (requires the rejected code to be reapplied):

```powershell
dotnet run -c Release -f net10.0 --project src/Tedd.SpanUtils.Benchmark -- --short --filter '*MovingSpan*' --artifacts docs/benchmarks/net10-moving
```

[Experiment report](results/Tedd.Benchmarks.CursorBenchmarks-report-github.md) · [CSV](results/Tedd.Benchmarks.CursorBenchmarks-report.csv)
