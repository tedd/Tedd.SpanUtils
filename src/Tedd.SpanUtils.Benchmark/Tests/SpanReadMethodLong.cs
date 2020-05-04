using System;
using System.Collections.Generic;
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
    public class SpanReadMethodLong
    {
        public const Int64 AlignmentCount = 256_000;
        public byte[] Memory = new byte[AlignmentCount+8];
        public Int64 Value;

        public SpanReadMethodLong()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true, true);
            
            GC.WaitForFullGCComplete();
        }

        [Benchmark(Baseline = true)]
        public void NormalAssign()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value+=NormalAssignEx(s);
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

        public static Int64 NormalAssignEx(Span<byte> span)
        {
            // Byte by byte copy
            return (Int64)(
                ((Int64)span[0] << (8 * 7))
                | ((Int64)span[1] << (8 * 6))
                | ((Int64)span[2] << (8 * 5))
                | ((Int64)span[3] << (8 * 4))
                | ((Int64)span[4] << (8 * 3))
                | ((Int64)span[5] << (8 * 2))
                | ((Int64)span[6] << (8 * 1))
                | ((Int64)span[7]));
        }

        [Benchmark]
        public void NormalAssignLF()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value += NormalAssignLFEx(s);
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

        public static Int64 NormalAssignLFEx(Span<byte> span)
        {
            // Byte by byte copy
            return (Int64)(
                ((Int64)span[7])
                | ((Int64)span[0] << (8 * 7))
                | ((Int64)span[1] << (8 * 6))
                | ((Int64)span[2] << (8 * 5))
                | ((Int64)span[3] << (8 * 4))
                | ((Int64)span[4] << (8 * 3))
                | ((Int64)span[5] << (8 * 2))
                | ((Int64)span[6] << (8 * 1))
                );
        }

        [Benchmark()]
        public void AssignReverse()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value += AssignReverseEx(s);
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

        public static Int64 AssignReverseEx(Span<byte> span)
        {
            // Byte by byte copy
            return (Int64)(
                ((Int64)span[7])
                | ((Int64)span[6] << (8 * 1))
                | ((Int64)span[5] << (8 * 2))
                | ((Int64)span[4] << (8 * 3))
                | ((Int64)span[3] << (8 * 4))
                | ((Int64)span[2] << (8 * 5))
                | ((Int64)span[1] << (8 * 6))
                | ((Int64)span[0] << (8 * 7))
            );
        }

        [Benchmark()]
        public void MarshalSafeCast()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value += MarshalSafeCastEx(s);
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
        public static unsafe Int64 MarshalSafeCastEx(Span<byte> span)
        {
            // MemoryMarshal safe cast
            Span<Int64> a = stackalloc Int64[1] ;
            var ab = MemoryMarshal.Cast<Int64, byte>(a);
            span.CopyTo(ab);
            return a[0];
        }


        [Benchmark()]
        public void SpanSpanCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value += SpanSpanCopyEx(s);
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
        public static unsafe Int64 SpanSpanCopyEx(Span<byte> span)
        {
            // Span to span copy with unsafe cast to span
            Int64* b = stackalloc Int64[1];
            var s = new Span<byte>((void*)b, sizeof(Int64));
            span.Slice(0,sizeof(long)).CopyTo(s);
            return b[0];
        }

        //[Benchmark()]
        //public void StackSpanCopy()
        //{
        //    for (var i = 0; i < AlignmentCount; i++)
        //    {
        //        var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
        //        Value += StackSpanCopyEx(s;
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //        //StackSpanCopyEx(s, Value);
        //    }
        //}
        //public static unsafe void StackSpanCopyEx(Span<byte> span)
        //{
        //    // Byte by byte copy from known sized stack array
        //    var b = stackalloc byte[sizeof(long)] {
               
        //    };
        //    b[0] = span[0];
        //    b[1] = span[1];
        //    b[2] = span[2];
        //    b[3] = span[3];
        //    b[4] = span[4];
        //    b[5] = span[5];
        //    b[6] = span[6];
        //    b[7] = span[7];

        //    return b;
        //}

        [Benchmark()]
        public void UnsafeCastStackCopy()
        {
            for (var i = 0; i < AlignmentCount; i++)
            {
                var s = ((Span<byte>)Memory).Slice(i, sizeof(Int64));
                Value += UnsafeCastStackCopyEx(s);
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
        public static unsafe Int64 UnsafeCastStackCopyEx(Span<byte> span)
        {
            // Byte by byte copy from unsafe casted stack array
            Int64* i = stackalloc Int64[] { };
            var b = (byte*)i;
            b[0] = span[0];
            b[1] = span[1];
            b[2] = span[2];
            b[3] = span[3];
            b[4] = span[4];
            b[5] = span[5];
            b[6] = span[6];
            b[7] = span[7];

            return i[0];
        }
    }
}
