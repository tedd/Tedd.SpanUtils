using System;
using System.Collections.Generic;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static partial class CodeGenBodies
    {
        public static string WriteSByte(bool le) => @"
        span[0] = (byte)value;
        [LEN]
        [MOVE]";

        public static string WriteByte(bool le) => @"
        span[0] = value;
        [LEN]
        [MOVE]";

        //public static string WriteInt16(bool le) => le switch
        //{
        //    true => @"
        //    span[1] = (byte)(value & 0xFF);
        //    span[0] = (byte)(value >> (8 * 1));
        //    [LEN]
        //    [MOVE]",
        //    false => @"
        //    span[1] = (byte)(value >> (8 * 1));
        //    span[0] = (byte)(value & 0xFF);
        //    [LEN]
        //    [MOVE]"
        //};

        public static string WriteUInt16(bool le) => le switch
        {
            true => @"
            span[1] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 1));
            [LEN]
            [MOVE]",
            false => @"
            span[1] = (byte)(value >> (8 * 1));
            span[0] = (byte)(value & 0xFF);
            [LEN]
            [MOVE]"
        };
        public static string WriteUInt24(bool le) => le switch
        {
            true => @"
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)((Int32)value & 0xFF);
            span[0] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            [LEN]
            [MOVE]",
            false => @"
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[0] = (byte)((Int32)value & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            [LEN]
            [MOVE]"
        };


//        public static string WriteInt32(bool le) => le switch
//        {
//            true => @"
//",
//            false => @"
//"
//        };

        public static string WriteUInt32(bool le) => le switch
        {
            true => @"
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            [LEN]
            [MOVE]",
            false => @"
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value >> (8 * 3));
            span[2] = (byte)((value >> (8 * 2)) & 0xFF);
            span[1] = (byte)((value >> (8 * 1)) & 0xFF);
            span[0] = (byte)(value & 0xFF);
            [LEN]
            [MOVE]"
        };

        //public static string WriteInt64(bool le) => le switch
        //{
        //    true => @"
        //    [LEN]
        //    [MOVE]",
        //    false => @"
        //    [LEN]
        //    [MOVE]"
        //};


        public static string WriteUInt64(bool le) => le switch
        {
            true => @"
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            [LEN]
            [MOVE]",
            false => @"
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value >> (8 * 7));
            span[6] = (byte)((value >> (8 * 6)) & 0xFF);
            span[5] = (byte)((value >> (8 * 5)) & 0xFF);
            span[4] = (byte)((value >> (8 * 4)) & 0xFF);
            span[3] = (byte)((value >> (8 * 3)) & 0xFF);
            span[2] = (byte)((value >> (8 * 2)) & 0xFF);
            span[1] = (byte)((value >> (8 * 1)) & 0xFF);
            span[0] = (byte)(value & 0xFF);
            [LEN]
            [MOVE]"
        };


        public static string WriteSingle(bool le) => @"
            Span<float> a = stackalloc float[1] { value };
            var ab = MemoryMarshal.Cast<float, byte>(a);
            ab.CopyTo(span);
            [LEN]
            [MOVE]";

        public static string WriteDouble(bool le) => @"
            Span<double> a = stackalloc double[1] { value };
            var ab = MemoryMarshal.Cast<double, byte>(a);
            ab.CopyTo(span);
            [LEN]
            [MOVE]";

        public static string WriteDecimal(bool le) => @"
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            [LEN]
            [MOVE]";

        public static string WriteBoolean(bool le) => @"
            span[0] = (byte)(value ? 1 : 0);
            [LEN]
            [MOVE]";

        public static string WriteChar(bool le) => @"
            Span<char> a = stackalloc char[1] { value };
            var ab = MemoryMarshal.Cast<char, byte>(a);
            ab.CopyTo(span);
            [LEN]
            [MOVE]";

        public static string WriteGuid(bool le) => @"
            var array = new Span<byte>(value.ToByteArray());
            array.CopyTo(span);
            length = array.Length;
            [LEN]
            [MOVE]";

        public static string WriteBytes(bool le) => @"
            value.CopyTo(span);
            length = value.Length;
            [LEN]
            [MOVE]";

        public static string WriteSpan(bool le) => @"
            value.CopyTo(span);
            length = value.Length;
            [LEN]
            [MOVE]";

        public static string WriteVLQInt16(bool le) => @"
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int16.MinValue) {
                    length = 1;
                    [MOVE]
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }

            ++length;
            [LEN]
            [MOVE]";

        public static string WriteVLQUInt16(bool le) => @"
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            [LEN]
            [MOVE]";

        public static string WriteVLQUInt24(bool le) => @"
            length = 0;
            value = (UInt24)((UInt32)value & 0b11111111_11111111_11111111);
            while ((UInt32)value >= 0x80)
            {
                span[length++] = ((byte)((UInt32)value | 0x80));
                value = (UInt24)((UInt32)value >> 7);
            }
            span[length++] = (byte)value;
            [LEN]
            [MOVE]";

        public static string WriteVLQInt32(bool le) => @"
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int32.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            [LEN]
            [MOVE]";

        public static string WriteVLQUInt32(bool le) => @"
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            [LEN]
            [MOVE]";

        public static string WriteVLQInt64(bool le) => @"
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int64.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            [LEN]
            [MOVE]";

        public static string WriteVLQUInt64(bool le) => @"
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            [LEN]
            [MOVE]";

        public static string WriteSize(bool le) => @"
            length = SpanUtils.MeasureWriteSize(value);
            if (length == 1)
                SpanUtils.Write(span, (Byte)value);
            else if (length == 2)
                SpanUtils.Write(span, (UInt16)((UInt16)value | (0b01 << 14)));
            // Even larger (up to 4,2M) we store length as 3 bytes
            else if (length == 3)
                SpanUtils.Write(span, (UInt24)((UInt32)value | (0b10 << 22)));
            else if (length == 4)
                SpanUtils.Write(span, (UInt32)((UInt32)value | (0b11 << 30)));

            [LEN]
            [MOVE]";

        public static string WriteSizedBytes(bool le) => @"
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException(""Data length too big for target span."", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            [LEN]
            [MOVE]";
        public static string WriteSizedSpan(bool le) => @"
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException(""Data length too big for target span."", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            [LEN]
            [MOVE]";

        public static string WriteSizedString(bool le) => @"
#if NETCOREAPP || NETSTANDARD21
            // We use GetByteCount followed by direct copy to avoid creating a byte array (avoid GC).
            // For larger strings this could cause 
            var strSize = (UInt32)Encoding.UTF8.GetByteCount(value);
            var mbs = SpanUtils.MeasureWriteSize((UInt32)strSize);
            var len = (int)mbs + (int)strSize;
            if (len > span.Length)
                throw new ArgumentException(""Data length too big for target span."", nameof(value));

            SpanUtils.WriteSize(span, strSize, out _);

            Encoding.UTF8.GetBytes(value, span.Slice(mbs));
#else
            var bytes = Encoding.UTF8.GetBytes(value);
            if (bytes.Length > span.Length)
                throw new ArgumentException(""String is too long."", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)bytes.Length, out var mbs);
            var len = (int)mbs + bytes.Length;
            var s = span.Slice(mbs, bytes.Length);
            SpanUtils.Write(s, bytes, out _);
#endif
            length = len;
            [LEN]
            [MOVE]";


        public static string WriteInt16(bool le) => WriteUInt16(le);
        public static string WriteInt32(bool le) => WriteUInt32(le);
        public static string WriteInt64(bool le) => WriteUInt64(le);


    }
}