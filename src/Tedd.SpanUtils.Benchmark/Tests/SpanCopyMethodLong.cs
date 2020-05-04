using System;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Tedd.SpanUtils.Benchmark.Tests
{
    [Config(typeof(RunConfig))]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [PlainExporter]
    [RPlotExporter]
    [JsonExporterAttribute.Brief]
    [JsonExporterAttribute.BriefCompressed]
    [JsonExporterAttribute.Full]
    [JsonExporterAttribute.FullCompressed]
    [MarkdownExporterAttribute.Default]
    [MarkdownExporterAttribute.GitHub]
    [MarkdownExporterAttribute.StackOverflow]
    [MarkdownExporterAttribute.Atlassian]
    [XmlExporterAttribute.Brief]
    [XmlExporterAttribute.BriefCompressed]
    [XmlExporterAttribute.Full]
    [XmlExporterAttribute.FullCompressed]
    public class SpanCopyMethodLong
    {
        public const int AlignmentCount = 256_000;
        public byte[] Memory = new byte[AlignmentCount + 8];

        public long Value;

        [Benchmark(Baseline = true)]
        public void NormalAssign()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
            }
        }

        public static void NormalAssignEx(Span<byte> span, long value)
        {
            // Byte by byte copy
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)(value >> (8 * 2));
            span[2] = (byte)(value >> (8 * 1));
            span[3] = (byte)value;
        }

        [Benchmark]
        public void NormalAssignLF()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                NormalAssignLFEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
                //NormalAssignEx(s, Value);
            }
        }

        public static void NormalAssignLFEx(Span<byte> span, long value)
        {
            // Byte by byte copy
            span[3] = (byte)value;
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)(value >> (8 * 2));
            span[2] = (byte)(value >> (8 * 1));
        }

        [Benchmark()]
        public void AssignReverse()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
                //AssignReverseEx(s, Value);
            }
        }

        public static void AssignReverseEx(Span<byte> span, long value)
        {
            // Byte by byte copy
            span[3] = (byte)value;
            span[2] = (byte)(value >> (8 * 1));
            span[1] = (byte)(value >> (8 * 2));
            span[0] = (byte)(value >> (8 * 3));
        }

        [Benchmark()]
        public void MarshalSafeCast()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
                //MarshalSafeCastEx(s, Value);
            }
        }
        public static unsafe void MarshalSafeCastEx(Span<byte> span, long value)
        {
            // MemoryMarshal safe cast
            Span<long> a = stackalloc long[1] { value };
            var ab = MemoryMarshal.Cast<long, byte>(a);
            ab.CopyTo(span);
        }


        [Benchmark()]
        public void SpanSpanCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
                //SpanSpanCopyEx(s, Value);
            }
        }
        public static unsafe void SpanSpanCopyEx(Span<byte> span, long value)
        {
            // Span to span copy with unsafe cast to span
            long* b = stackalloc long[1] { value };
            var s = new Span<byte>((void*)b, sizeof(long));
            s.CopyTo(span);
        }

        [Benchmark()]
        public void StackSpanCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
                //StackSpanCopyEx(s, Value);
            }
        }
        public static unsafe void StackSpanCopyEx(Span<byte> span, long value)
        {
            // Byte by byte copy from known sized stack array
            var b = stackalloc byte[] {
                (byte)(value >> (8 * 3)),
                (byte)(value >> (8 * 2)),
                (byte)(value >> (8 * 1)),
                (byte)value
            };
            span[0] = b[0];
            span[1] = b[1];
            span[2] = b[2];
            span[3] = b[3];
        }

        [Benchmark()]
        public void UnsafeCastStackCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(long));
                UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
                //UnsafeCastStackCopyEx(s, Value);
            }
        }
        public static unsafe void UnsafeCastStackCopyEx(Span<byte> span, long value)
        {
            // Byte by byte copy from unsafe casted stack array
            long* i = stackalloc long[] { value };
            var b = (byte*)i;
            span[0] = b[0];
            span[1] = b[1];
            span[2] = b[2];
            span[3] = b[3];
        }
    }
}