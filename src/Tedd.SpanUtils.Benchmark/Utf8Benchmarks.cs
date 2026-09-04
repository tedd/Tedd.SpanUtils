extern alias archive;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Old = archive::Tedd.SpanUtils;
using Current = Tedd.SpanUtils;

namespace Tedd.Benchmarks;

[MemoryDiagnoser]
[CategoriesColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class Utf8Benchmarks
{
    private const string Text = "Span serialization: ASCII, norsk æøå, 日本語 and 🚀. ";
    private readonly byte[] oldBuffer = new byte[1024];
    private readonly byte[] newBuffer = new byte[1024];
    private readonly string value = string.Concat(Enumerable.Repeat(Text, 4));

    [GlobalSetup]
    public void Setup()
    {
        if (ArchivedWrite() != CurrentWrite() || !oldBuffer.AsSpan().SequenceEqual(newBuffer)
            || ArchivedRead() != value || CurrentRead() != value)
            throw new InvalidOperationException("UTF-8 baseline differs from current implementation.");
    }

    [Benchmark(Baseline = true), BenchmarkCategory("UTF8 write")]
    public int ArchivedWrite()
    {
        Old.WriteSized(oldBuffer, value, out var written);
        return written;
    }

    [Benchmark, BenchmarkCategory("UTF8 write")]
    public int CurrentWrite()
    {
        Current.WriteSized(newBuffer, value, out var written);
        return written;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("UTF8 read")]
    public string ArchivedRead() => Old.ReadSizedString((ReadOnlySpan<byte>)oldBuffer);

    [Benchmark, BenchmarkCategory("UTF8 read")]
    public string CurrentRead() => Current.ReadSizedString((ReadOnlySpan<byte>)newBuffer);
}
