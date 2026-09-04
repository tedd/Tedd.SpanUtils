extern alias archive;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Old = archive::Tedd.SpanUtils;
using Current = Tedd.SpanUtils;
using OldSpanStream = archive::Tedd.SpanStream;
using NewSpanStream = Tedd.SpanStream;
using OldMemoryStreamer = archive::Tedd.MemoryStreamer;
using NewMemoryStreamer = Tedd.MemoryStreamer;

namespace Tedd.Benchmarks;

[MemoryDiagnoser]
[CategoriesColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class CursorBenchmarks
{
    public const int Count = 128;
    private readonly byte[] oldBuffer = new byte[Count * 8];
    private readonly byte[] newBuffer = new byte[Count * 8];
    private readonly byte[] payload = Enumerable.Range(0, Count * 8).Select(i => (byte)i).ToArray();
    private readonly byte[] oldCopy = new byte[Count * 8];
    private readonly byte[] newCopy = new byte[Count * 8];
    private OldMemoryStreamer oldStream = null!;
    private NewMemoryStreamer newStream = null!;

    [GlobalSetup]
    public void Setup()
    {
        oldStream = new OldMemoryStreamer(oldBuffer);
        newStream = new NewMemoryStreamer(newBuffer);
        Validate(ArchivedMovingSpan(), CurrentMovingSpan(), "MovingSpan");
        Validate(ArchivedSpanStream(), CurrentSpanStream(), "SpanStream");
        Validate(ArchivedMemoryCopy(), CurrentMemoryCopy(), "MemoryStreamer");
        if (!oldCopy.AsSpan().SequenceEqual(payload) || !newCopy.AsSpan().SequenceEqual(payload))
            throw new InvalidOperationException("MemoryStreamer copied different bytes.");
    }

    private void Validate(long oldResult, long newResult, string name)
    {
        if (oldResult != newResult || !oldBuffer.AsSpan().SequenceEqual(newBuffer))
            throw new InvalidOperationException($"{name} baseline differs from current implementation.");
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = Count), BenchmarkCategory("Moving span roundtrip")]
    public long ArchivedMovingSpan()
    {
        Span<byte> writer = oldBuffer;
        for (var i = 0; i < Count; i++) Old.MoveWrite(ref writer, (long)i);
        ReadOnlySpan<byte> reader = oldBuffer;
        long sum = 0;
        for (var i = 0; i < Count; i++) sum += Old.MoveReadInt64(ref reader);
        return sum;
    }

    [Benchmark(OperationsPerInvoke = Count), BenchmarkCategory("Moving span roundtrip")]
    public long CurrentMovingSpan()
    {
        Span<byte> writer = newBuffer;
        for (var i = 0; i < Count; i++) Current.MoveWrite(ref writer, (long)i);
        ReadOnlySpan<byte> reader = newBuffer;
        long sum = 0;
        for (var i = 0; i < Count; i++) sum += Current.MoveReadInt64(ref reader);
        return sum;
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = Count), BenchmarkCategory("SpanStream roundtrip")]
    public long ArchivedSpanStream()
    {
        var stream = new OldSpanStream(oldBuffer);
        for (var i = 0; i < Count; i++) stream.Write((long)i);
        stream.Position = 0;
        long sum = 0;
        for (var i = 0; i < Count; i++) sum += stream.ReadInt64();
        return sum;
    }

    [Benchmark(OperationsPerInvoke = Count), BenchmarkCategory("SpanStream roundtrip")]
    public long CurrentSpanStream()
    {
        var stream = new NewSpanStream(newBuffer);
        for (var i = 0; i < Count; i++) stream.Write((long)i);
        stream.Position = 0;
        long sum = 0;
        for (var i = 0; i < Count; i++) sum += stream.ReadInt64();
        return sum;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("MemoryStreamer 1KiB copy")]
    public int ArchivedMemoryCopy()
    {
        oldStream.Position = 0;
        oldStream.Write(payload, 0, payload.Length);
        oldStream.Position = 0;
        return oldStream.Read(oldCopy, 0, oldCopy.Length);
    }

    [Benchmark, BenchmarkCategory("MemoryStreamer 1KiB copy")]
    public int CurrentMemoryCopy()
    {
        newStream.Position = 0;
        newStream.Write(payload, 0, payload.Length);
        newStream.Position = 0;
        return newStream.Read(newCopy, 0, newCopy.Length);
    }
}
