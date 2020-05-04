using System;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using Tedd.SpanUtils.Benchmark.Tests;

namespace Tedd.SpanUtils.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary1 = BenchmarkRunner.Run<SpanCopyMethodInt>();
            var summary2 = BenchmarkRunner.Run<SpanCopyMethodLong>();
            
        }
    }
}
