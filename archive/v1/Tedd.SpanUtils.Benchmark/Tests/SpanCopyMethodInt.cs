using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
    public class SpanCopyMethodInt
    {
        public const int AlignmentCount = 256_000;
        public byte[] Memory = new byte[AlignmentCount+8];
        public int Value;

        public SpanCopyMethodInt()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true, true);
            
            GC.WaitForFullGCComplete();
        }

        [Benchmark(Baseline = true)]
        public void NormalAssign()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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

        public static void NormalAssignEx(Span<byte> span, int value)
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
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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

        public static void NormalAssignLFEx(Span<byte> span, int value)
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
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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

        public static void AssignReverseEx(Span<byte> span, int value)
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
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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
        public static unsafe void MarshalSafeCastEx(Span<byte> span, int value)
        {
            // MemoryMarshal safe cast
            Span<int> a = stackalloc int[1] { value };
            var ab = MemoryMarshal.Cast<int, byte>(a);
            ab.CopyTo(span);
        }


        [Benchmark()]
        public void SpanSpanCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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
        public static unsafe void SpanSpanCopyEx(Span<byte> span, int value)
        {
            // Span to span copy with unsafe cast to span
            int* b = stackalloc int[1] { value };
            var s = new Span<byte>((void*)b, sizeof(int));
            s.CopyTo(span);
        }

        [Benchmark()]
        public void StackSpanCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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
        public static unsafe void StackSpanCopyEx(Span<byte> span, int value)
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
                var s = ((Span<byte>)Memory).Slice(i, sizeof(int));
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
        public static unsafe void UnsafeCastStackCopyEx(Span<byte> span, int value)
        {
            // Byte by byte copy from unsafe casted stack array
            int* i = stackalloc int[] { value };
            var b = (byte*)i;
            span[0] = b[0];
            span[1] = b[1];
            span[2] = b[2];
            span[3] = b[3];
        }

        [Benchmark()]
        public void UnsafeWriteUnaligned()
        {
            var m = ((Span<byte>)Memory);
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = m.Slice(i, sizeof(int));
                Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(s), i);
            }
        }
        [Benchmark()]
        public void UnsafeWriteAs()
        {
            var m = ((Span<byte>)Memory);
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = m.Slice(i, sizeof(int));
                Unsafe.As<byte, Int64>(ref MemoryMarshal.GetReference(s)) = i;
            }
        } 
        [Benchmark()]
        public void UnsafeWriteAsFirstByte()
        {
            var m = ((Span<byte>)Memory);
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = m.Slice(i, sizeof(int));
                Unsafe.As<byte, Int64>(ref s[0]) = i;
            }
        }
    }
}
