extern alias archive;

using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using Old = archive::Tedd.SpanUtils;
using Current = Tedd.SpanUtils;

namespace Tedd.Benchmarks;

// Version 1 has no bulk API: its baseline is an explicit loop over the public scalar reader.
[MemoryDiagnoser]
public class BulkEndianBenchmarks
{
    [Params(64, 4096)]
    public int Length { get; set; } = 64;

    private int[] source = null!;
    private int[] oldOutput = null!;
    private int[] newOutput = null!;

    [GlobalSetup]
    public void Setup()
    {
        if (!BitConverter.IsLittleEndian)
            throw new PlatformNotSupportedException("This scalar BE-decoding comparison requires a little-endian host.");
        source = Enumerable.Range(0, Length).Select(i => unchecked(i * 16777619)).ToArray();
        oldOutput = new int[Length];
        newOutput = new int[Length];
        if (ArchivedScalarReadBE() != CurrentBulkReverse() || !oldOutput.AsSpan().SequenceEqual(newOutput))
            throw new InvalidOperationException("Bulk endian output differs from the archived scalar equivalent.");
    }

    [Benchmark(Baseline = true)]
    public int ArchivedScalarReadBE()
    {
        var bytes = MemoryMarshal.AsBytes(source.AsSpan());
        for (var i = 0; i < source.Length; i++)
            oldOutput[i] = Old.ReadInt32BE(bytes.Slice(i * sizeof(int)));
        return oldOutput[Length - 1];
    }

    [Benchmark]
    public int CurrentBulkReverse()
    {
        Current.ReverseEndianness(source, newOutput);
        return newOutput[Length - 1];
    }
}
