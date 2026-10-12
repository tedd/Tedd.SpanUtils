extern alias archive;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Tedd.Benchmarks;

internal static class Program
{
    private static int Main(string[] args)
    {
        if (args.Contains("--validate"))
        {
            new SerializationBenchmarks().Setup();
            new MeasureWriteSizeBenchmarks().Setup();
            new Utf8Benchmarks().Setup();
            new CursorBenchmarks().Setup();
            foreach (var length in new[] { 64, 4096 }) new BulkEndianBenchmarks { Length = length }.Setup();
            Console.WriteLine("All archived/current benchmark workloads produced equivalent results.");
            return 0;
        }

        var shortRun = args.Contains("--short");
        var forwarded = args.Where(arg => arg != "--short").ToArray();
        var job = shortRun ? Job.ShortRun : Job.Default;
#if NET11_0_OR_GREATER
        job = job.WithRuntime(CoreRuntime.Core11_0)

            .WithArguments(new[] { new MsBuildArgument("/p:EnableNet11=true") });
#elif NET10_0_OR_GREATER
        job = job.WithRuntime(CoreRuntime.Core10_0);
#else
        job = job.WithRuntime(CoreRuntime.Core60);
#endif
        var config = DefaultConfig.Instance
            .AddJob(job.WithId(shortRun ? "ShortRun" : "Default"));
        var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(forwarded, config);
        return summaries.Any(summary => summary.HasCriticalValidationErrors || summary.Reports.Any(report => !report.Success)) ? 1 : 0;
    }
}
