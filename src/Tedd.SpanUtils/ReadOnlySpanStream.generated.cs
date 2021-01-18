// This file is auto-generated. Do not modify.

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
namespace Tedd {
    public ref partial struct ReadOnlySpanStream {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByte() => ReadSByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByte(out int length) {
            var ret = SpanUtils.ReadSByte(Span.Slice(_position), out length);
            Position += sizeof(SByte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByte() => ReadByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByte(out int length) {
            var ret = SpanUtils.ReadByte(Span.Slice(_position), out length);
            Position += sizeof(Byte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16() => ReadUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16(out int length) {
            var ret = SpanUtils.ReadUInt16(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16() => ReadInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16(out int length) {
            var ret = SpanUtils.ReadInt16(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32() => ReadUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32(out int length) {
            var ret = SpanUtils.ReadUInt32(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32() => ReadInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32(out int length) {
            var ret = SpanUtils.ReadInt32(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64() => ReadUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64(out int length) {
            var ret = SpanUtils.ReadUInt64(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64() => ReadInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64(out int length) {
            var ret = SpanUtils.ReadInt64(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle() => ReadSingle(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle(out int length) {
            var ret = SpanUtils.ReadSingle(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble() => ReadDouble(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble(out int length) {
            var ret = SpanUtils.ReadDouble(Span.Slice(_position), out length);
            Position += sizeof(Double);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal() => ReadDecimal(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal(out int length) {
            var ret = SpanUtils.ReadDecimal(Span.Slice(_position), out length);
            Position += sizeof(Decimal);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean() => ReadBoolean(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean(out int length) {
            var ret = SpanUtils.ReadBoolean(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar() => ReadChar(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar(out int length) {
            var ret = SpanUtils.ReadChar(Span.Slice(_position), out length);
            Position += sizeof(Char);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat() => ReadFloat(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat(out int length) {
            var ret = SpanUtils.ReadFloat(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort() => ReadShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort(out int length) {
            var ret = SpanUtils.ReadShort(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort() => ReadUShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort(out int length) {
            var ret = SpanUtils.ReadUShort(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt() => ReadInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt(out int length) {
            var ret = SpanUtils.ReadInt(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt() => ReadUInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt(out int length) {
            var ret = SpanUtils.ReadUInt(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong() => ReadLong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong(out int length) {
            var ret = SpanUtils.ReadLong(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong() => ReadULong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong(out int length) {
            var ret = SpanUtils.ReadULong(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool() => ReadBool(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool(out int length) {
            var ret = SpanUtils.ReadBool(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16() => ReadVLQUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16(out int length) {
            var ret = SpanUtils.ReadVLQUInt16(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16() => ReadVLQInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16(out int length) {
            var ret = SpanUtils.ReadVLQInt16(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32() => ReadVLQUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32(out int length) {
            var ret = SpanUtils.ReadVLQUInt32(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32() => ReadVLQInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32(out int length) {
            var ret = SpanUtils.ReadVLQInt32(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64() => ReadVLQUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64(out int length) {
            var ret = SpanUtils.ReadVLQUInt64(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64() => ReadVLQInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64(out int length) {
            var ret = SpanUtils.ReadVLQInt64(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24() => ReadUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24(out int length) {
            var ret = SpanUtils.ReadUInt24(Span.Slice(_position), out length);
            Position += 3;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24() => ReadVLQUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24(out int length) {
            var ret = SpanUtils.ReadVLQUInt24(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid() => ReadGuid(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid(out int length) {
            var ret = SpanUtils.ReadGuid(Span.Slice(_position), out length);
            Position += 16;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadBytes(int length) {
            var ret = SpanUtils.ReadBytes(Span.Slice(_position), length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> ReadReadOnlySpan(int length) {
            var ret = SpanUtils.ReadReadOnlySpan(Span.Slice(_position), length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize() => ReadSize(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize(out int length) {
            var ret = SpanUtils.ReadSize(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes() => ReadSizedBytes(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes(out int length) {
            var ret = SpanUtils.ReadSizedBytes(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString() => ReadSizedString(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString(out int length) {
            var ret = SpanUtils.ReadSizedString(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

    }

}
