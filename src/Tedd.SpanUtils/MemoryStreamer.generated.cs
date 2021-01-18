// This file is auto-generated. Do not modify.

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
namespace Tedd {
    public partial class MemoryStreamer {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByte() => ReadSByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByte(out int length) {
            var ret = SpanUtils.ReadSByte(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(SByte value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(SByte value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int ReadByte() => ReadByte(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByte(out int length) {
            var ret = SpanUtils.ReadByte(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16() => ReadUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16(out int length) {
            var ret = SpanUtils.ReadUInt16(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt16 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt16 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16() => ReadInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16(out int length) {
            var ret = SpanUtils.ReadInt16(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int16 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int16 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32() => ReadUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32(out int length) {
            var ret = SpanUtils.ReadUInt32(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt32 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt32 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32() => ReadInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32(out int length) {
            var ret = SpanUtils.ReadInt32(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int32 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int32 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64() => ReadUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64(out int length) {
            var ret = SpanUtils.ReadUInt64(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt64 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt64 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64() => ReadInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64(out int length) {
            var ret = SpanUtils.ReadInt64(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int64 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int64 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle() => ReadSingle(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle(out int length) {
            var ret = SpanUtils.ReadSingle(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Single value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Single value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble() => ReadDouble(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble(out int length) {
            var ret = SpanUtils.ReadDouble(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Double value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Double value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal() => ReadDecimal(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal(out int length) {
            var ret = SpanUtils.ReadDecimal(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Decimal value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Decimal value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean() => ReadBoolean(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean(out int length) {
            var ret = SpanUtils.ReadBoolean(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Boolean value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Boolean value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar() => ReadChar(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar(out int length) {
            var ret = SpanUtils.ReadChar(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Char value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Char value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat() => ReadFloat(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat(out int length) {
            var ret = SpanUtils.ReadFloat(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Single);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort() => ReadShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort(out int length) {
            var ret = SpanUtils.ReadShort(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort() => ReadUShort(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort(out int length) {
            var ret = SpanUtils.ReadUShort(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt() => ReadInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt(out int length) {
            var ret = SpanUtils.ReadInt(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt() => ReadUInt(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt(out int length) {
            var ret = SpanUtils.ReadUInt(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt32);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong() => ReadLong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong(out int length) {
            var ret = SpanUtils.ReadLong(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Int64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong() => ReadULong(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong(out int length) {
            var ret = SpanUtils.ReadULong(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(UInt64);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool() => ReadBool(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool(out int length) {
            var ret = SpanUtils.ReadBool(ROMemory.Span.Slice(_position), out length);
            Position += sizeof(Boolean);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16() => ReadVLQUInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16(out int length) {
            var ret = SpanUtils.ReadVLQUInt16(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt16 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt16 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16() => ReadVLQInt16(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16(out int length) {
            var ret = SpanUtils.ReadVLQInt16(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int16 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int16 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32() => ReadVLQUInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32(out int length) {
            var ret = SpanUtils.ReadVLQUInt32(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt32 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt32 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32() => ReadVLQInt32(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32(out int length) {
            var ret = SpanUtils.ReadVLQInt32(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int32 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int32 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64() => ReadVLQUInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64(out int length) {
            var ret = SpanUtils.ReadVLQUInt64(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt64 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt64 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64() => ReadVLQInt64(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64(out int length) {
            var ret = SpanUtils.ReadVLQInt64(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int64 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int64 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24() => ReadUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24(out int length) {
            var ret = SpanUtils.ReadUInt24(ROMemory.Span.Slice(_position), out length);
            Position += 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt24 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt24 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24() => ReadVLQUInt24(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24(out int length) {
            var ret = SpanUtils.ReadVLQUInt24(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt24 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt24 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteVLQ(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid() => ReadGuid(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid(out int length) {
            var ret = SpanUtils.ReadGuid(ROMemory.Span.Slice(_position), out length);
            Position += 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Guid value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Guid value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadBytes(int length) {
            var ret = SpanUtils.ReadBytes(ROMemory.Span.Slice(_position), length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte[] value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte[] value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<byte> ReadSpan(int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only, use ReadReadOnlySpan.");
            var ret = SpanUtils.ReadSpan(Memory.Span.Slice(_position), length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Span<byte> value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Span<byte> value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> ReadReadOnlySpan(int length) {
            var ret = SpanUtils.ReadReadOnlySpan(ROMemory.Span.Slice(_position), length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(ReadOnlySpan<byte> value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(ReadOnlySpan<byte> value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.Write(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize() => ReadSize(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize(out int length) {
            var ret = SpanUtils.ReadSize(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSize(UInt32 value) => WriteSize(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSize(UInt32 value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteSize(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes() => ReadSizedBytes(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes(out int length) {
            var ret = SpanUtils.ReadSizedBytes(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Byte[] value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Byte[] value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteSized(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString() => ReadSizedString(out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString(out int length) {
            var ret = SpanUtils.ReadSizedString(ROMemory.Span.Slice(_position), out length);
            Position += length;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(String value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(String value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteSized(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Span<byte> value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Span<byte> value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteSized(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(ReadOnlySpan<byte> value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(ReadOnlySpan<byte> value, out int length) {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            SpanUtils.WriteSized(Memory.Span.Slice(_position), value, out length);
            Position += length;
        }
    }

}
