using System;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using Tedd.Tests;

namespace Tedd.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<MeasureVLQBenchmark>();
            //var summary2 = BenchmarkRunner.Run<SpanCopyMethodLong>();
            //var summary3 = BenchmarkRunner.Run<SpanReadMethodLong>();

        }
    }
}
