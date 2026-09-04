namespace Tedd.SpanUtils.SourceGenerator
{
    public static partial class CodeGenBodies
    {
        public static string WriteByte(Endianness e) => WriteResult("span[0] = value;");
        public static string WriteSByte(Endianness e) => WriteResult("span[0] = (Byte)value;");
        public static string WriteBoolean(Endianness e) => WriteResult("span[0] = value ? (Byte)1 : (Byte)0;");
        public static string WriteInt16(Endianness e) => WriteInteger("Int16", e);
        public static string WriteUInt16(Endianness e) => WriteInteger("UInt16", e);
        public static string WriteInt32(Endianness e) => WriteInteger("Int32", e);
        public static string WriteUInt32(Endianness e) => WriteInteger("UInt32", e);
        public static string WriteInt64(Endianness e) => WriteInteger("Int64", e);
        public static string WriteUInt64(Endianness e) => WriteInteger("UInt64", e);
        public static string WriteInt128(Endianness e) => WriteInteger("Int128", e);
        public static string WriteUInt128(Endianness e) => WriteInteger("UInt128", e);
        public static string WriteChar(Endianness e) => WriteResult("SpanUtils.Write[LEBE](span, (UInt16)value);");
        public static string WriteSingle(Endianness e) => WriteResult("SpanUtils.Write[LEBE](span, BitConverter.SingleToInt32Bits(value));");
        public static string WriteDouble(Endianness e) => WriteResult("SpanUtils.Write[LEBE](span, BitConverter.DoubleToInt64Bits(value));");
        public static string WriteHalf(Endianness e) => WriteResult("SpanUtils.Write[LEBE](span, BitConverter.HalfToInt16Bits(value));");
        public static string WriteUInt24(Endianness e) => WriteResult(@"
            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            " + (e == Endianness.BE
                ? "span[2] = (Byte)value; span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)((UInt32)value >> 16);"
                : "span[2] = (Byte)((UInt32)value >> 16); span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)value;"));
        public static string WriteInt24(Endianness e) => WriteResult(@"
            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.Write[LEBE](span, (UInt24)((UInt32)value & 0xFFFFFFU));");
        public static string WriteDecimal(Endianness e) => e == Endianness.Default
            ? WriteInteger("Decimal", e)
            : WriteResult("SpanUtils.WriteDecimalPortable(span, value, " + (e == Endianness.BE ? "true" : "false") + ");");
        public static string WriteGuid(Endianness e) => e == Endianness.BE
            ? WriteResult("SpanUtils.WriteGuidBigEndian(span, value);")
            : WriteResult(@"if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException(nameof(span));");
        public static string WriteString(Endianness e) => WriteResult(@"
            if (value == null) throw new ArgumentNullException(nameof(value));
            var required = Encoding.UTF8.GetByteCount(value);
            if (span.Length < required) throw new ArgumentException(""String exceeds destination capacity."", nameof(span));
            length = Encoding.UTF8.GetBytes(value.AsSpan(), span);");
        public static string WriteSpan(Endianness e) => WriteResult(@"
            value.CopyTo(span);
            length = value.Length;");
        private static string WriteSignedVlq(string type) => WriteResult($"length = SpanUtils.WriteSignedVLQ(span, value, {type}.MinValue);");
        private static string WriteUnsignedVlq(string cast = "") => WriteResult($"length = SpanUtils.WriteUnsignedVLQ(span, {cast}value);");
        public static string WriteVLQInt16(Endianness e) => WriteSignedVlq("Int16");
        public static string WriteVLQInt32(Endianness e) => WriteSignedVlq("Int32");
        public static string WriteVLQInt64(Endianness e) => WriteSignedVlq("Int64");
        public static string WriteVLQUInt16(Endianness e) => WriteUnsignedVlq();
        public static string WriteVLQUInt32(Endianness e) => WriteUnsignedVlq();
        public static string WriteVLQUInt64(Endianness e) => WriteUnsignedVlq();
        public static string WriteVLQUInt24(Endianness e) => WriteResult(@"
            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            length = SpanUtils.WriteUnsignedVLQ(span, (UInt32)value);");
        public static string WriteSize(Endianness e) => @"
            length = SpanUtils.MeasureWriteSize(value);
            switch (length)
            {
                case 1: span[0] = (Byte)value; break;
                case 2: BinaryPrimitives.WriteUInt16BigEndian(span, (UInt16)(value | 0x4000U)); break;
                case 3: SpanUtils.WriteBE(span, (UInt24)(value | 0x800000U)); break;
                default: BinaryPrimitives.WriteUInt32BigEndian(span, value | 0xC0000000U); break;
            }
            [MOVE]";
        public static string WriteSizedBytes(Endianness e) => WriteSizedSpan(e);
        public static string WriteSizedSpan(Endianness e) => @"
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException(""Data exceeds destination capacity."", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;
            [MOVE]";
        public static string WriteSizedString(Endianness e) => @"
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            var byteCount = Encoding.UTF8.GetByteCount(value);
            var prefix = SpanUtils.MeasureWriteSize((UInt32)byteCount);
            if (span.Length < prefix || byteCount > span.Length - prefix)
                throw new ArgumentException(""String exceeds destination capacity."", nameof(span));
            Encoding.UTF8.GetBytes(value.AsSpan(), span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)byteCount);
            length = prefix + byteCount;
            [MOVE]";
    }
}
