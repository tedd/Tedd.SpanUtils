using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;

namespace Tedd.SpanUtils.Benchmark
{
    public class RunConfig : ManualConfig
    {
        public RunConfig()
        {
            //AddJob(new Job(EnvironmentMode.RyuJitX64, RunMode.Dry)
            //{
            //    Environment = { Runtime = CoreRuntime.Core31 },
            //    Run = { LaunchCount = 3, WarmupCount = 5 },
            //    Accuracy = { MaxRelativeError = 0.01 }
            //});

            AddJob(Job
                .Dry
                .WithJit(Jit.RyuJit)
                .WithPlatform(Platform.X64)
                .WithRuntime(CoreRuntime.Core31)
                .WithIterationCount(10_000)
                .WithWarmupCount(1_000)
            );

            AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 3)));
            AddColumn(StatisticColumn.Error, StatisticColumn.Iterations, StatisticColumn.P0, StatisticColumn.P90);
            AddHardwareCounters(HardwareCounter.BranchInstructions, HardwareCounter.BranchMispredictions//,HardwareCounter.CacheMisses, HardwareCounter.TotalCycles
                );
            AddDiagnoser(new InliningDiagnoser());
            
        }
    }
}
