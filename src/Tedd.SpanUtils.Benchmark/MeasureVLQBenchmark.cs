using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;

namespace Tedd.Tests
{
    [MemoryDiagnoser]
    public class MeasureVLQBenchmark
    {
        [Params(0, 100, 10000, 1000000, 1000000000L, Int64.MaxValue)]
        public long Value;

        public ulong UValue;

        [GlobalSetup]
        public void Setup()
        {
            UValue = (ulong)Value;
        }

        [Benchmark(Baseline = true)]
        public byte Int64_Legacy()
        {
            return global::Tedd.Archive.SpanUtils.MeasureVLQ(Value);
        }

        [Benchmark]
        public byte Int64_Optimized()
        {
            return global::Tedd.SpanUtils.MeasureVLQ(Value);
        }

        [Benchmark]
        public byte UInt64_Legacy()
        {
            return global::Tedd.Archive.SpanUtils.MeasureVLQ(UValue);
        }

        [Benchmark]
        public byte UInt64_Optimized()
        {
            return global::Tedd.SpanUtils.MeasureVLQ(UValue);
        }
    }
}
