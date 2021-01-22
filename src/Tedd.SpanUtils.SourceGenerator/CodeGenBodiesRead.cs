using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static partial class CodeGenBodies
    {

        public static string ReadByte(Endianness le) => @"
            var ret = span[0];
            [LEN]
            [MOVE]
            return ret;";
        public static string ReadSByte(Endianness le) => @"
            var ret = (SByte)span[0];
            [LEN]
            [MOVE]
            return ret;";

        public static string ReadUInt16(Endianness le) => le switch
        {
            Endianness.Default => @"
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            [LEN]
            [MOVE]
            return ret;",
            Endianness.LE => @"
            var ret = (UInt16)(
                  ((UInt16)span[0])
                | ((UInt16)span[1] << (8 * 1))
                );            [LEN]
            [MOVE]
            return ret;",
            Endianness.BE => @"
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            [LEN]
            [MOVE]
            return ret;"
        };

        public static string ReadUInt24(Endianness le) => le switch
        {
            var x when x== Endianness.Default || x== Endianness.LE
             => @"
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            [LEN]
            [MOVE]
            return ret;",
            Endianness.BE => @"
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                );
            [LEN]
            [MOVE]
            return ret;"
        };
        public static string ReadUInt32(Endianness le) => le switch
        {
            Endianness.Default => @"
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            [LEN]
            [MOVE]
            return ret;",
            Endianness.LE => @"
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3] << (8 * 3))
                | ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            [LEN]
            [MOVE]
            return ret;",
            Endianness.BE => @"
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            [LEN]
            [MOVE]
            return ret;"
        };
        public static string ReadUInt64(Endianness le) => le switch
        {
            Endianness.Default => @"
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            [LEN]
            [MOVE]
            return ret;",
            Endianness.LE => @"
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7] << (8 * 7))
                | ((UInt64)span[6] << (8 * 6))
                | ((UInt64)span[5] << (8 * 5))
                | ((UInt64)span[4] << (8 * 4))
                | ((UInt64)span[3] << (8 * 3))
                | ((UInt64)span[2] << (8 * 2))
                | ((UInt64)span[1] << (8 * 1))
                | ((UInt64)span[0])
                );
            [LEN]
            [MOVE]
            return ret;",
            Endianness.BE => @"
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            [LEN]
            [MOVE]
            return ret;"
        };

        public static string ReadBoolean(Endianness le) => @"
            var ret = span[0] != 0;
            [LEN]
            [MOVE]
            return ret;";
        public static string ReadChar(Endianness le) => @"
            var r = MemoryMarshal.Read<Char>(span);
            [LEN]
            [MOVE]
            return r;"; // TODO: Endianness

        public static string ReadHalf(Endianness le) => @"
            Span<half> a = stackalloc half[1];
            var ab = MemoryMarshal.Cast<half, byte>(a);
            span.Slice(0, sizeof(half)).CopyTo(ab);
            [LEN]
            [MOVE]
            return a[0];";

        public static string ReadSingle(Endianness le) => @"
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32[LEBE](span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32[LEBE](span, out _);
            var r = *(float*)(&i);
#endif
            [LEN]
            [MOVE]
            return r;";

        public static string ReadDouble(Endianness le) => @"
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64[LEBE](span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64[LEBE](span, out _);
            var r = *(double*)(&i);
#endif
            [LEN]
            [MOVE]
            return r;";

        public static string ReadDecimal(Endianness le) => @"
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            [LEN]
            [MOVE]
            return a[0];";

        public static string ReadGuid(Endianness le) => @"
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var ret = new Guid(span.Slice(0, 16));
#else
            var ret = new Guid(span.Slice(0, 16).ToArray());
#endif
            [LEN]
            [MOVE]
            return ret;"; // TODO: ToArray creates object

        public static string ReadBytes(Endianness le) => @"
            var ret = span.Slice(0, length).ToArray();
            [LEN]
            [MOVE]
            return ret;";

        public static string ReadSpan(Endianness le) => @"
            var ret = span.Slice(0, length);
            [LEN]
            [MOVE]
            return ret;";

        public static string ReadVLQInt16(Endianness le) => @"
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                [MOVE]
                return Int16.MinValue;
            }

            var i = 0;
            var shift = 0;
            Int32 ret = 0;

            ret |= (Int32)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int16) + 2)
                    throw new OverflowException($""VLQ exceeded {sizeof(Int16) + 1} bytes"");

                ret |= (Int32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                ret = (Int16)(ret * -1);

            [MOVE]
            return (Int16)ret;";
        public static string ReadVLQUInt16(Endianness le) => @"
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == sizeof(UInt16) + 2)
                    throw new OverflowException($""VLQ exceeded {sizeof(UInt16) + 1} bytes"");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            [MOVE]
            return (UInt16)ret;";
        public static string ReadVLQUInt24(Endianness le) => @"
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == 3 + 2)
                    throw new OverflowException($""VLQ exceeded {3 + 1} bytes"");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            [MOVE]
            return ret.ToUInt24();";
        public static string ReadVLQInt32(Endianness le) => @"
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                [MOVE]
                return Int32.MinValue;
            }


            var i = 0;
            var shift = 0;
            Int32 ret = 0;

            ret |= (Int32)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int32) + 2)
                    throw new OverflowException($""VLQ exceeded {sizeof(Int32) + 1} bytes"");

                ret |= (Int32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                ret = (Int32)(ret * -1);

            [MOVE]
            return (Int32)ret;";
        public static string ReadVLQUInt32(Endianness le) => @"
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == sizeof(UInt32) + 2)
                    throw new OverflowException($""VLQ exceeded {sizeof(UInt32) + 1} bytes"");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            [MOVE]
            return ret;";
        public static string ReadVLQInt64(Endianness le) => @"
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                [MOVE]
                return Int64.MinValue;
            }

            var i = 0;
            var shift = 0;
            Int64 ret = 0;

            ret |= (Int64)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int64) + 3)
                    throw new OverflowException($""VLQ exceeded {sizeof(Int64) + 2} bytes"");

                ret |= (Int64)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                ret = (Int64)(ret * -1);

            [MOVE]
            return (Int64)ret;";
        public static string ReadVLQUInt64(Endianness le) => @"
            var i = 0;
            var shift = 0;
            UInt64 ret = 0;
            do
            {
                if (i == sizeof(UInt64) + 3)
                    throw new OverflowException($""VLQ exceeded {sizeof(UInt64) + 2} bytes"");

                ret |= ((UInt64)(span[i] & 0b0111_1111) << shift);
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            [MOVE]
            return ret;";


        public static string ReadSize(Endianness le) => @"
            var b1 = span[0];
            var s = b1 >> 6;

            length = s + 1;
            var ret = s switch
            {
                0b00 => (UInt32)b1 & 0b00111111,
                0b01 => (UInt32)SpanUtils.ReadUInt16BE(span) & 0b00111111_11111111,
                0b10 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0b00111111_11111111_11111111,
                //case 0b11:
                _ => (UInt32)SpanUtils.ReadUInt32BE(span) & 0b00111111_11111111_11111111_11111111
            };
            [MOVE]
            return ret;";

        public static string ReadSizedBytes(Endianness le) => @"
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
            var ret = span.Slice(len, (int)size).ToArray();
            [MOVE]
            return ret;";


        public static string ReadSizedString(Endianness le) => @"
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            [MOVE]
            return ret;";




        public static string ReadInt16(Endianness le) => ReadUInt16(le).Replace("return ", "return (Int16)");
        public static string ReadInt32(Endianness le) => ReadUInt32(le).Replace("return ", "return (Int32)");
        public static string ReadInt64(Endianness le) => ReadUInt64(le).Replace("return ", "return (Int64)");

    }
}
