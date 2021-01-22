// This file is auto-generated. Do not modify.

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
#if !BEFORENETCOREAPP3
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
namespace Tedd {
    public ref partial struct ReadOnlySpanStream {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByte() => ReadSByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByte(out int length) {
            var ret = SpanUtils.ReadSByte(Span.Slice(_position), out length);
            Position += sizeof(SByte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByte() => ReadByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByte(out int length) {
            var ret = SpanUtils.ReadByte(Span.Slice(_position), out length);
            Position += sizeof(Byte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16() => ReadUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16(out int length) {
            var ret = SpanUtils.ReadUInt16(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16() => ReadInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16(out int length) {
            var ret = SpanUtils.ReadInt16(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32() => ReadUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32(out int length) {
            var ret = SpanUtils.ReadUInt32(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32() => ReadInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32(out int length) {
            var ret = SpanUtils.ReadInt32(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64() => ReadUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64(out int length) {
            var ret = SpanUtils.ReadUInt64(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64() => ReadInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64(out int length) {
            var ret = SpanUtils.ReadInt64(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingle() => ReadSingle(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingle(out int length) {
            var ret = SpanUtils.ReadSingle(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDouble() => ReadDouble(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDouble(out int length) {
            var ret = SpanUtils.ReadDouble(Span.Slice(_position), out length);
            Position += sizeof(Double);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimal() => ReadDecimal(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimal(out int length) {
            var ret = SpanUtils.ReadDecimal(Span.Slice(_position), out length);
            Position += sizeof(Decimal);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolean() => ReadBoolean(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolean(out int length) {
            var ret = SpanUtils.ReadBoolean(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadChar() => ReadChar(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadChar(out int length) {
            var ret = SpanUtils.ReadChar(Span.Slice(_position), out length);
            Position += sizeof(Char);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloat() => ReadFloat(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloat(out int length) {
            var ret = SpanUtils.ReadFloat(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShort() => ReadShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShort(out int length) {
            var ret = SpanUtils.ReadShort(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShort() => ReadUShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShort(out int length) {
            var ret = SpanUtils.ReadUShort(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt() => ReadInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt(out int length) {
            var ret = SpanUtils.ReadInt(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt() => ReadUInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt(out int length) {
            var ret = SpanUtils.ReadUInt(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLong() => ReadLong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLong(out int length) {
            var ret = SpanUtils.ReadLong(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULong() => ReadULong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULong(out int length) {
            var ret = SpanUtils.ReadULong(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBool() => ReadBool(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBool(out int length) {
            var ret = SpanUtils.ReadBool(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadVLQUInt16() => ReadVLQUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadVLQUInt16(out int length) {
            var ret = SpanUtils.ReadVLQUInt16(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadVLQInt16() => ReadVLQInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadVLQInt16(out int length) {
            var ret = SpanUtils.ReadVLQInt16(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadVLQUInt32() => ReadVLQUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadVLQUInt32(out int length) {
            var ret = SpanUtils.ReadVLQUInt32(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadVLQInt32() => ReadVLQInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadVLQInt32(out int length) {
            var ret = SpanUtils.ReadVLQInt32(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadVLQUInt64() => ReadVLQUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadVLQUInt64(out int length) {
            var ret = SpanUtils.ReadVLQUInt64(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadVLQInt64() => ReadVLQInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadVLQInt64(out int length) {
            var ret = SpanUtils.ReadVLQInt64(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24() => ReadUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24(out int length) {
            var ret = SpanUtils.ReadUInt24(Span.Slice(_position), out length);
            Position += 3;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadVLQUInt24() => ReadVLQUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadVLQUInt24(out int length) {
            var ret = SpanUtils.ReadVLQUInt24(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Guid ReadGuid() => ReadGuid(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Guid ReadGuid(out int length) {
            var ret = SpanUtils.ReadGuid(Span.Slice(_position), out length);
            Position += 16;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte[] ReadBytes(int length) {
            var ret = SpanUtils.ReadBytes(Span.Slice(_position), length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe ReadOnlySpan<byte> ReadReadOnlySpan(int length) {
            var ret = SpanUtils.ReadReadOnlySpan(Span.Slice(_position), length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadSize() => ReadSize(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadSize(out int length) {
            var ret = SpanUtils.ReadSize(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte[] ReadSizedBytes() => ReadSizedBytes(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte[] ReadSizedBytes(out int length) {
            var ret = SpanUtils.ReadSizedBytes(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe String ReadSizedString() => ReadSizedString(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe String ReadSizedString(out int length) {
            var ret = SpanUtils.ReadSizedString(Span.Slice(_position), out length);
            Position += length;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByteLE() => ReadSByteLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByteLE(out int length) {
            var ret = SpanUtils.ReadSByteLE(Span.Slice(_position), out length);
            Position += sizeof(SByte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByteLE() => ReadByteLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByteLE(out int length) {
            var ret = SpanUtils.ReadByteLE(Span.Slice(_position), out length);
            Position += sizeof(Byte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16LE() => ReadUInt16LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16LE(out int length) {
            var ret = SpanUtils.ReadUInt16LE(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16LE() => ReadInt16LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16LE(out int length) {
            var ret = SpanUtils.ReadInt16LE(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32LE() => ReadUInt32LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32LE(out int length) {
            var ret = SpanUtils.ReadUInt32LE(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32LE() => ReadInt32LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32LE(out int length) {
            var ret = SpanUtils.ReadInt32LE(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64LE() => ReadUInt64LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64LE(out int length) {
            var ret = SpanUtils.ReadUInt64LE(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64LE() => ReadInt64LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64LE(out int length) {
            var ret = SpanUtils.ReadInt64LE(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingleLE() => ReadSingleLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingleLE(out int length) {
            var ret = SpanUtils.ReadSingleLE(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDoubleLE() => ReadDoubleLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDoubleLE(out int length) {
            var ret = SpanUtils.ReadDoubleLE(Span.Slice(_position), out length);
            Position += sizeof(Double);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimalLE() => ReadDecimalLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimalLE(out int length) {
            var ret = SpanUtils.ReadDecimalLE(Span.Slice(_position), out length);
            Position += sizeof(Decimal);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBooleanLE() => ReadBooleanLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBooleanLE(out int length) {
            var ret = SpanUtils.ReadBooleanLE(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadCharLE() => ReadCharLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadCharLE(out int length) {
            var ret = SpanUtils.ReadCharLE(Span.Slice(_position), out length);
            Position += sizeof(Char);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloatLE() => ReadFloatLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloatLE(out int length) {
            var ret = SpanUtils.ReadFloatLE(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShortLE() => ReadShortLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShortLE(out int length) {
            var ret = SpanUtils.ReadShortLE(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShortLE() => ReadUShortLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShortLE(out int length) {
            var ret = SpanUtils.ReadUShortLE(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadIntLE() => ReadIntLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadIntLE(out int length) {
            var ret = SpanUtils.ReadIntLE(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUIntLE() => ReadUIntLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUIntLE(out int length) {
            var ret = SpanUtils.ReadUIntLE(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLongLE() => ReadLongLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLongLE(out int length) {
            var ret = SpanUtils.ReadLongLE(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULongLE() => ReadULongLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULongLE(out int length) {
            var ret = SpanUtils.ReadULongLE(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolLE() => ReadBoolLE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolLE(out int length) {
            var ret = SpanUtils.ReadBoolLE(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24LE() => ReadUInt24LE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24LE(out int length) {
            var ret = SpanUtils.ReadUInt24LE(Span.Slice(_position), out length);
            Position += 3;
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByteBE() => ReadSByteBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe SByte ReadSByteBE(out int length) {
            var ret = SpanUtils.ReadSByteBE(Span.Slice(_position), out length);
            Position += sizeof(SByte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByteBE() => ReadByteBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Byte ReadByteBE(out int length) {
            var ret = SpanUtils.ReadByteBE(Span.Slice(_position), out length);
            Position += sizeof(Byte);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16BE() => ReadUInt16BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUInt16BE(out int length) {
            var ret = SpanUtils.ReadUInt16BE(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16BE() => ReadInt16BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadInt16BE(out int length) {
            var ret = SpanUtils.ReadInt16BE(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32BE() => ReadUInt32BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUInt32BE(out int length) {
            var ret = SpanUtils.ReadUInt32BE(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32BE() => ReadInt32BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadInt32BE(out int length) {
            var ret = SpanUtils.ReadInt32BE(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64BE() => ReadUInt64BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadUInt64BE(out int length) {
            var ret = SpanUtils.ReadUInt64BE(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64BE() => ReadInt64BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadInt64BE(out int length) {
            var ret = SpanUtils.ReadInt64BE(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingleBE() => ReadSingleBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadSingleBE(out int length) {
            var ret = SpanUtils.ReadSingleBE(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDoubleBE() => ReadDoubleBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Double ReadDoubleBE(out int length) {
            var ret = SpanUtils.ReadDoubleBE(Span.Slice(_position), out length);
            Position += sizeof(Double);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimalBE() => ReadDecimalBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Decimal ReadDecimalBE(out int length) {
            var ret = SpanUtils.ReadDecimalBE(Span.Slice(_position), out length);
            Position += sizeof(Decimal);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBooleanBE() => ReadBooleanBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBooleanBE(out int length) {
            var ret = SpanUtils.ReadBooleanBE(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadCharBE() => ReadCharBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Char ReadCharBE(out int length) {
            var ret = SpanUtils.ReadCharBE(Span.Slice(_position), out length);
            Position += sizeof(Char);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloatBE() => ReadFloatBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Single ReadFloatBE(out int length) {
            var ret = SpanUtils.ReadFloatBE(Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShortBE() => ReadShortBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int16 ReadShortBE(out int length) {
            var ret = SpanUtils.ReadShortBE(Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShortBE() => ReadUShortBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt16 ReadUShortBE(out int length) {
            var ret = SpanUtils.ReadUShortBE(Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadIntBE() => ReadIntBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int32 ReadIntBE(out int length) {
            var ret = SpanUtils.ReadIntBE(Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUIntBE() => ReadUIntBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt32 ReadUIntBE(out int length) {
            var ret = SpanUtils.ReadUIntBE(Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLongBE() => ReadLongBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Int64 ReadLongBE(out int length) {
            var ret = SpanUtils.ReadLongBE(Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULongBE() => ReadULongBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt64 ReadULongBE(out int length) {
            var ret = SpanUtils.ReadULongBE(Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolBE() => ReadBoolBE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Boolean ReadBoolBE(out int length) {
            var ret = SpanUtils.ReadBoolBE(Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24BE() => ReadUInt24BE(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe UInt24 ReadUInt24BE(out int length) {
            var ret = SpanUtils.ReadUInt24BE(Span.Slice(_position), out length);
            Position += 3;
            return ret;
        }

    }

}
