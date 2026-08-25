using System;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using Tedd.Benchmark.Tests;

namespace Tedd.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<MeasureWriteSizeBenchmark>();
            var summary2 = BenchmarkRunner.Run<MeasureVLQBenchmark>();
        }
    }
}
