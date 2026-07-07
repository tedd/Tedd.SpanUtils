using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Tedd.Benchmarks
{
    [MemoryDiagnoser]
    public class MeasureVLQBenchmark
    {
        private ulong[] _u64Data = new ulong[1000];
        private long[] _i64Data = new long[1000];

        [GlobalSetup]
        public void Setup()
        {
            var rand = new Random(42);
            for (int i = 0; i < 1000; i++)
            {
                byte[] b = new byte[8];
                rand.NextBytes(b);
                _u64Data[i] = BitConverter.ToUInt64(b, 0);
                _i64Data[i] = BitConverter.ToInt64(b, 0);

                // Mix in some small numbers
                if (i % 5 == 0) _u64Data[i] = (ulong)rand.Next(0, 100000);
                if (i % 5 == 1) _i64Data[i] = (long)rand.Next(-100000, 100000);
            }
        }

        [Benchmark(Baseline = true)]
        public long Legacy_MeasureVLQ_UInt64()
        {
            long sum = 0;
            foreach (var val in _u64Data)
            {
                sum += Tedd.Archive.SpanUtils.MeasureVLQ(val);
            }
            return sum;
        }

        [Benchmark]
        public long Optimized_MeasureVLQ_UInt64()
        {
            long sum = 0;
            foreach (var val in _u64Data)
            {
                sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            }
            return sum;
        }

        [Benchmark]
        public long Legacy_MeasureVLQ_Int64()
        {
            long sum = 0;
            foreach (var val in _i64Data)
            {
                sum += Tedd.Archive.SpanUtils.MeasureVLQ(val);
            }
            return sum;
        }

        [Benchmark]
        public long Optimized_MeasureVLQ_Int64()
        {
            long sum = 0;
            foreach (var val in _i64Data)
            {
                sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MeasureVLQBenchmark>();
        }
    }
}
