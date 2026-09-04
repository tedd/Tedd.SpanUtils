namespace Tedd.SpanUtils.SourceGenerator
{
    public static partial class CodeGenBodies
    {
        public static string ReadByte(Endianness e) => ReadResult("span[0]");
        public static string ReadSByte(Endianness e) => ReadResult("(SByte)span[0]");
        public static string ReadBoolean(Endianness e) => ReadResult("span[0] != 0");
        public static string ReadInt16(Endianness e) => ReadInteger("Int16", e);
        public static string ReadUInt16(Endianness e) => ReadInteger("UInt16", e);
        public static string ReadInt32(Endianness e) => ReadInteger("Int32", e);
        public static string ReadUInt32(Endianness e) => ReadInteger("UInt32", e);
        public static string ReadInt64(Endianness e) => ReadInteger("Int64", e);
        public static string ReadUInt64(Endianness e) => ReadInteger("UInt64", e);
        public static string ReadInt128(Endianness e) => ReadInteger("Int128", e);
        public static string ReadUInt128(Endianness e) => ReadInteger("UInt128", e);
        public static string ReadChar(Endianness e) => ReadResult("(Char)SpanUtils.ReadUInt16[LEBE](span)");
        public static string ReadSingle(Endianness e) => ReadResult("BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32[LEBE](span))");
        public static string ReadDouble(Endianness e) => ReadResult("BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64[LEBE](span))");
        public static string ReadHalf(Endianness e) => ReadResult("BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16[LEBE](span))");
        public static string ReadUInt24(Endianness e) => ReadResult(e == Endianness.BE
            ? "(UInt24)(span[2] | (span[1] << 8) | (span[0] << 16))"
            : "(UInt24)((span[2] << 16) | (span[1] << 8) | span[0])");
        public static string ReadInt24(Endianness e) => ReadResult("((Int32)SpanUtils.ReadUInt24[LEBE](span) << 8) >> 8");
        public static string ReadDecimal(Endianness e) => e == Endianness.Default
            ? ReadResult("MemoryMarshal.Read<Decimal>(span)")
            : ReadResult("SpanUtils.ReadDecimalPortable(span, " + (e == Endianness.BE ? "true" : "false") + ")");
        public static string ReadGuid(Endianness e) => e == Endianness.BE
            ? ReadResult("SpanUtils.ReadGuidBigEndian(span)")
            : ReadResult("new Guid(span.Slice(0, 16))");
        public static string ReadBytes(Endianness e) => ReadResult("span.Slice(0, length).ToArray()");
        public static string ReadString(Endianness e) => ReadResult("Encoding.UTF8.GetString(span.Slice(0, length))");
        public static string ReadSpan(Endianness e) => ReadResult("span.Slice(0, length)");
        private static string ReadUnsignedVlq(int bits, string cast) => ReadResult($"{cast}SpanUtils.ReadUnsignedVLQ(span, {bits}, out length)");
        private static string ReadSignedVlq(int bits, string type) => ReadResult($"({type})SpanUtils.ReadSignedVLQ(span, {bits}, out length)");
        public static string ReadVLQUInt16(Endianness e) => ReadUnsignedVlq(16, "(UInt16)");
        public static string ReadVLQUInt24(Endianness e) => ReadUnsignedVlq(24, "(UInt24)");
        public static string ReadVLQUInt32(Endianness e) => ReadUnsignedVlq(32, "(UInt32)");
        public static string ReadVLQUInt64(Endianness e) => ReadUnsignedVlq(64, "");
        public static string ReadVLQInt16(Endianness e) => ReadSignedVlq(16, "Int16");
        public static string ReadVLQInt32(Endianness e) => ReadSignedVlq(32, "Int32");
        public static string ReadVLQInt64(Endianness e) => ReadSignedVlq(64, "Int64");
        public static string ReadSize(Endianness e) => @"
            var first = span[0];
            length = (first >> 6) + 1;
            UInt32 ret = length switch
            {
                1 => (UInt32)first,
                2 => BinaryPrimitives.ReadUInt16BigEndian(span) & 0x3FFFU,
                3 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0x3FFFFFU,
                _ => BinaryPrimitives.ReadUInt32BigEndian(span) & 0x3FFFFFFFU
            };
            [MOVE]
            return ret;";
        public static string ReadSizedBytes(Endianness e) => @"
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size).ToArray();
            length = prefix + size;
            [MOVE]
            return ret;";
        public static string ReadSizedSpan(Endianness e) => @"
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;
            [MOVE]
            return ret;";
        public static string ReadSizedString(Endianness e) => @"
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = Encoding.UTF8.GetString(span.Slice(prefix, size));
            length = prefix + size;
            [MOVE]
            return ret;";
    }
}
