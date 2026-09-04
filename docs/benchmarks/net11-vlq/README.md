# Rejected VLQ inlining experiment

These measurements evaluate an intermediate implementation that was reverted. They do not describe the final version 2 implementation.

The experiment added `MethodImplOptions.AggressiveInlining` to the internal unsigned VLQ reader, try-reader core, and writer. The intention was to expose constant bit widths to the JIT while retaining all validation. Focused .NET 11 correctness tests passed, but the measured current/archived ratio was 1.27, compared with 1.25 for the retained implementation. This provided no evidence of a benefit, so the attributes were removed and no .NET 10 follow-up was run.

Both measurements used ShortRun. Different absolute times between runs emphasize why this decision uses the within-run archived/current comparison rather than claiming a precise effect from a single elapsed-time difference.

Command used for the experiment (the intermediate source is not part of the release):

```powershell
dotnet run -c Release -f net11.0 -p:EnableNet11=true --project src/Tedd.SpanUtils.Benchmark -- --short --filter '*VLQ*' --artifacts docs/benchmarks/net11-vlq
```

[Experiment report](results/Tedd.Benchmarks.SerializationBenchmarks-report-github.md) · [CSV](results/Tedd.Benchmarks.SerializationBenchmarks-report.csv)
