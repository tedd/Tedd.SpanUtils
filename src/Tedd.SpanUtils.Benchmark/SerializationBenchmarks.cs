extern alias archive;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Old = archive::Tedd.SpanUtils;
using Current = Tedd.SpanUtils;

namespace Tedd.Benchmarks;

[MemoryDiagnoser]
[CategoriesColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class SerializationBenchmarks
{
    public const int Count = 128;
    private readonly byte[] oldBuffer = new byte[Count * 16 + 1];
    private readonly byte[] newBuffer = new byte[Count * 16 + 1];
    private readonly ulong[] values = Enumerable.Range(0, Count)
        .Select(i => (i % 8) switch { 0 => 0UL, 1 => 127UL, 2 => 128UL, 3 => 16384UL, 4 => uint.MaxValue, 5 => 1UL << 42, 6 => 1UL << 56, _ => ulong.MaxValue }).ToArray();

    [GlobalSetup]
    public void Setup()
    {
        Validate(ArchivedInt32LE(), CurrentInt32LE(), "Int32LE");
        Validate(ArchivedInt64BE(), CurrentInt64BE(), "Int64BE");
        Validate(ArchivedVLQ(), CurrentVLQ(), "VLQ");
    }

    private void Validate(ulong oldResult, ulong newResult, string name)
    {
        if (oldResult != newResult || !oldBuffer.AsSpan().SequenceEqual(newBuffer))
            throw new InvalidOperationException($"{name} baseline differs from current implementation.");
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = Count), BenchmarkCategory("Int32LE roundtrip")]
    public ulong ArchivedInt32LE()
    {
        var span = oldBuffer.AsSpan(1); // Deliberately unaligned.
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 4);
            Old.WriteLE(target, (int)values[i]);
            sum += (uint)Old.ReadInt32LE(target);
        }
        return sum;
    }

    [Benchmark(OperationsPerInvoke = Count), BenchmarkCategory("Int32LE roundtrip")]
    public ulong CurrentInt32LE()
    {
        var span = newBuffer.AsSpan(1);
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 4);
            Current.WriteLE(target, (int)values[i]);
            sum += (uint)Current.ReadInt32LE(target);
        }
        return sum;
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = Count), BenchmarkCategory("Int64BE roundtrip")]
    public ulong ArchivedInt64BE()
    {
        var span = oldBuffer.AsSpan(1);
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 8);
            Old.WriteBE(target, (long)values[i]);
            sum += (ulong)Old.ReadInt64BE(target);
        }
        return sum;
    }

    [Benchmark(OperationsPerInvoke = Count), BenchmarkCategory("Int64BE roundtrip")]
    public ulong CurrentInt64BE()
    {
        var span = newBuffer.AsSpan(1);
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 8);
            Current.WriteBE(target, (long)values[i]);
            sum += (ulong)Current.ReadInt64BE(target);
        }
        return sum;
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = Count), BenchmarkCategory("VLQ roundtrip")]
    public ulong ArchivedVLQ()
    {
        var span = oldBuffer.AsSpan(1);
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 16);
            Old.WriteVLQ(target, values[i], out var written);
            sum += Old.ReadVLQUInt64(target, out var consumed) + (uint)(written + consumed);
        }
        return sum;
    }

    [Benchmark(OperationsPerInvoke = Count), BenchmarkCategory("VLQ roundtrip")]
    public ulong CurrentVLQ()
    {
        var span = newBuffer.AsSpan(1);
        ulong sum = 0;
        for (var i = 0; i < Count; i++)
        {
            var target = span.Slice(i * 16);
            Current.WriteVLQ(target, values[i], out var written);
            sum += Current.ReadVLQUInt64(target, out var consumed) + (uint)(written + consumed);
        }
        return sum;
    }
}
