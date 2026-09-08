extern alias archive;

using BenchmarkDotNet.Attributes;
using System;

namespace Tedd.Benchmarks;

[MemoryDiagnoser]
public class MeasureWriteSizeBenchmarks
{
    private uint[] _values = Array.Empty<uint>();

    [Params(100)]
    public int Count { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _values = new uint[Count];
        var random = new Random(42);
        for (int i = 0; i < Count; i++)
        {
            _values[i] = (uint)random.Next(0, 0x3FFFFFFF);
        }

        // Ensure equivalent results
        for (int i = 0; i < Count; i++)
        {
            var expected = archive::Tedd.SpanUtils.MeasureWriteSize(_values[i]);
            var actual = Tedd.SpanUtils.MeasureWriteSize(_values[i]);
            if (expected != actual) throw new Exception("Mismatch");
        }
    }

    [Benchmark(Baseline = true)]
    public int Archived()
    {
        int sum = 0;
        var values = _values;
        for (int i = 0; i < values.Length; i++)
        {
            sum += archive::Tedd.SpanUtils.MeasureWriteSize(values[i]);
        }
        return sum;
    }

    [Benchmark]
    public int Current()
    {
        int sum = 0;
        var values = _values;
        for (int i = 0; i < values.Length; i++)
        {
            sum += Tedd.SpanUtils.MeasureWriteSize(values[i]);
        }
        return sum;
    }
}
