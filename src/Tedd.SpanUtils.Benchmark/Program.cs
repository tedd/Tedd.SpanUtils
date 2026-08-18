using BenchmarkDotNet.Running;
using System;

namespace Tedd.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<VIntSizeBenchmark>();
        }
    }
}
