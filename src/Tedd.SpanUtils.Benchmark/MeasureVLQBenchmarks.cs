using BenchmarkDotNet.Attributes;
using Tedd.Archive;

namespace Tedd.Benchmark
{
    [MemoryDiagnoser]
    public class MeasureVLQBenchmarks
    {
        private ulong[] _uValues;
        private long[] _iValues;
        private uint[] _u32Values;
        private int[] _i32Values;
        private short[] _i16Values;

        [GlobalSetup]
        public void Setup()
        {
            _uValues = new ulong[] { 0, 100, 10000, 1000000000, ulong.MaxValue };
            _iValues = new long[] { 0, -100, 10000, -1000000000, long.MaxValue, long.MinValue };
            _u32Values = new uint[] { 0, 100, 10000, 1000000000, uint.MaxValue };
            _i32Values = new int[] { 0, -100, 10000, -1000000000, int.MaxValue, int.MinValue };
            _i16Values = new short[] { 0, -100, 10000, short.MaxValue, short.MinValue };
        }

        [Benchmark(Baseline = true)]
        public int Old_UInt64()
        {
            int sum = 0;
            foreach (var val in _uValues) sum += UtilsArchive.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int New_UInt64()
        {
            int sum = 0;
            foreach (var val in _uValues) sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int Old_Int64()
        {
            int sum = 0;
            foreach (var val in _iValues) sum += UtilsArchive.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int New_Int64()
        {
            int sum = 0;
            foreach (var val in _iValues) sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int Old_UInt32()
        {
            int sum = 0;
            foreach (var val in _u32Values) sum += UtilsArchive.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int New_UInt32()
        {
            int sum = 0;
            foreach (var val in _u32Values) sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int Old_Int32()
        {
            int sum = 0;
            foreach (var val in _i32Values) sum += UtilsArchive.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int New_Int32()
        {
            int sum = 0;
            foreach (var val in _i32Values) sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int Old_Int16()
        {
            int sum = 0;
            foreach (var val in _i16Values) sum += UtilsArchive.MeasureVLQ(val);
            return sum;
        }

        [Benchmark]
        public int New_Int16()
        {
            int sum = 0;
            foreach (var val in _i16Values) sum += global::Tedd.SpanUtils.MeasureVLQ(val);
            return sum;
        }
    }
}
