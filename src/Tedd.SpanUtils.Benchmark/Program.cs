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
            var summary1 = BenchmarkRunner.Run<SpanCopyMethodInt>();
            //var summary2 = BenchmarkRunner.Run<SpanCopyMethodLong>();
            //var summary3 = BenchmarkRunner.Run<SpanReadMethodLong>();
            var summary4 = BenchmarkRunner.Run<MeasureVLQBenchmarks>();
        }
    }
}
