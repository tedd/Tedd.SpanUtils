// This file is auto-generated. Do not modify.

using System;
using System.Buffers.Binary;
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
            var result = SpanUtils.ReadSByte(ReadBuffer, out length);
            _position += sizeof(SByte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByte(out SByte value) => TryReadSByte(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByte(out SByte value, out int length) {
            if (!SpanUtils.TryReadSByte(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(SByte value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(SByte value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(SByte value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(SByte value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByte(out int length) {
            var result = SpanUtils.ReadByte(ReadBuffer, out length);
            _position += sizeof(Byte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByte(out Byte value) => TryReadByte(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByte(out Byte value, out int length) {
            if (!SpanUtils.TryReadByte(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Byte value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Byte value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16() => ReadUInt16(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16(out int length) {
            var result = SpanUtils.ReadUInt16(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16(out UInt16 value) => TryReadUInt16(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUInt16(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt16 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt16 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt16 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt16 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16() => ReadInt16(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16(out int length) {
            var result = SpanUtils.ReadInt16(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16(out Int16 value) => TryReadInt16(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16(out Int16 value, out int length) {
            if (!SpanUtils.TryReadInt16(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int16 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int16 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int16 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int16 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32() => ReadUInt32(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32(out int length) {
            var result = SpanUtils.ReadUInt32(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32(out UInt32 value) => TryReadUInt32(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUInt32(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt32 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt32 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt32 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt32 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32() => ReadInt32(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32(out int length) {
            var result = SpanUtils.ReadInt32(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32(out Int32 value) => TryReadInt32(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt32(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int32 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int32 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int32 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int32 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64() => ReadUInt64(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64(out int length) {
            var result = SpanUtils.ReadUInt64(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64(out UInt64 value) => TryReadUInt64(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUInt64(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt64 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt64 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt64 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt64 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64() => ReadInt64(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64(out int length) {
            var result = SpanUtils.ReadInt64(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64(out Int64 value) => TryReadInt64(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64(out Int64 value, out int length) {
            if (!SpanUtils.TryReadInt64(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int64 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int64 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int64 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int64 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle() => ReadSingle(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingle(out int length) {
            var result = SpanUtils.ReadSingle(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingle(out Single value) => TryReadSingle(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingle(out Single value, out int length) {
            if (!SpanUtils.TryReadSingle(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Single value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Single value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Single value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Single value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble() => ReadDouble(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDouble(out int length) {
            var result = SpanUtils.ReadDouble(ReadBuffer, out length);
            _position += sizeof(Double);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDouble(out Double value) => TryReadDouble(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDouble(out Double value, out int length) {
            if (!SpanUtils.TryReadDouble(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Double value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Double value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Double value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Double value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal() => ReadDecimal(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimal(out int length) {
            var result = SpanUtils.ReadDecimal(ReadBuffer, out length);
            _position += sizeof(Decimal);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimal(out Decimal value) => TryReadDecimal(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimal(out Decimal value, out int length) {
            if (!SpanUtils.TryReadDecimal(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Decimal value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Decimal value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Decimal value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Decimal value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean() => ReadBoolean(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolean(out int length) {
            var result = SpanUtils.ReadBoolean(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolean(out Boolean value) => TryReadBoolean(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolean(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBoolean(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Boolean value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Boolean value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Boolean value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Boolean value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar() => ReadChar(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadChar(out int length) {
            var result = SpanUtils.ReadChar(ReadBuffer, out length);
            _position += sizeof(Char);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadChar(out Char value) => TryReadChar(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadChar(out Char value, out int length) {
            if (!SpanUtils.TryReadChar(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Char value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Char value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Char value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Char value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat() => ReadFloat(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloat(out int length) {
            var result = SpanUtils.ReadFloat(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloat(out Single value) => TryReadFloat(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloat(out Single value, out int length) {
            if (!SpanUtils.TryReadFloat(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort() => ReadShort(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort(out int length) {
            var result = SpanUtils.ReadShort(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShort(out Int16 value) => TryReadShort(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShort(out Int16 value, out int length) {
            if (!SpanUtils.TryReadShort(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort() => ReadUShort(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort(out int length) {
            var result = SpanUtils.ReadUShort(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShort(out UInt16 value) => TryReadUShort(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShort(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUShort(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt() => ReadInt(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt(out int length) {
            var result = SpanUtils.ReadInt(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt(out Int32 value) => TryReadInt(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt() => ReadUInt(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt(out int length) {
            var result = SpanUtils.ReadUInt(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt(out UInt32 value) => TryReadUInt(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUInt(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong() => ReadLong(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong(out int length) {
            var result = SpanUtils.ReadLong(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLong(out Int64 value) => TryReadLong(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLong(out Int64 value, out int length) {
            if (!SpanUtils.TryReadLong(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong() => ReadULong(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong(out int length) {
            var result = SpanUtils.ReadULong(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULong(out UInt64 value) => TryReadULong(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULong(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadULong(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool() => ReadBool(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBool(out int length) {
            var result = SpanUtils.ReadBool(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBool(out Boolean value) => TryReadBool(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBool(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBool(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24() => ReadUInt24(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24(out int length) {
            var result = SpanUtils.ReadUInt24(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24(out UInt24 value) => TryReadUInt24(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24(out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUInt24(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt24 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt24 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt24 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt24 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24() => ReadInt24(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24(out int length) {
            var result = SpanUtils.ReadInt24(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24(out Int32 value) => TryReadInt24(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt24(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24(Int32 value) => WriteInt24(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24(Int32 value, out int length)
        {
            SpanUtils.WriteInt24(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24(Int32 value) => TryWriteInt24(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24(Int32 value, out int length) {
            if (!SpanUtils.TryWriteInt24(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalf() => ReadHalf(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalf(out int length) {
            var result = SpanUtils.ReadHalf(ReadBuffer, out length);
            _position += 2;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalf(out Half value) => TryReadHalf(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalf(out Half value, out int length) {
            if (!SpanUtils.TryReadHalf(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Half value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Half value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Half value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Half value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128() => ReadInt128(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128(out int length) {
            var result = SpanUtils.ReadInt128(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128(out Int128 value) => TryReadInt128(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128(out Int128 value, out int length) {
            if (!SpanUtils.TryReadInt128(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int128 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Int128 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int128 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Int128 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128() => ReadUInt128(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128(out int length) {
            var result = SpanUtils.ReadUInt128(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128(out UInt128 value) => TryReadUInt128(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128(out UInt128 value, out int length) {
            if (!SpanUtils.TryReadUInt128(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt128 value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(UInt128 value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt128 value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(UInt128 value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid() => ReadGuid(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid(out int length) {
            var result = SpanUtils.ReadGuid(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuid(out Guid value) => TryReadGuid(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuid(out Guid value, out int length) {
            if (!SpanUtils.TryReadGuid(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Guid value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Guid value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Guid value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Guid value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16() => ReadVLQUInt16(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16(out int length) {
            var result = SpanUtils.ReadVLQUInt16(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt16(out UInt16 value) => TryReadVLQUInt16(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt16(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadVLQUInt16(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt16 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt16 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt16 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt16 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16() => ReadVLQInt16(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16(out int length) {
            var result = SpanUtils.ReadVLQInt16(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt16(out Int16 value) => TryReadVLQInt16(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt16(out Int16 value, out int length) {
            if (!SpanUtils.TryReadVLQInt16(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int16 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int16 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int16 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int16 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32() => ReadVLQUInt32(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32(out int length) {
            var result = SpanUtils.ReadVLQUInt32(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt32(out UInt32 value) => TryReadVLQUInt32(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt32(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadVLQUInt32(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt32 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt32 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt32 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt32 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32() => ReadVLQInt32(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32(out int length) {
            var result = SpanUtils.ReadVLQInt32(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt32(out Int32 value) => TryReadVLQInt32(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt32(out Int32 value, out int length) {
            if (!SpanUtils.TryReadVLQInt32(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int32 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int32 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int32 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int32 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64() => ReadVLQUInt64(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64(out int length) {
            var result = SpanUtils.ReadVLQUInt64(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt64(out UInt64 value) => TryReadVLQUInt64(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt64(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadVLQUInt64(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt64 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt64 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt64 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt64 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64() => ReadVLQInt64(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64(out int length) {
            var result = SpanUtils.ReadVLQInt64(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt64(out Int64 value) => TryReadVLQInt64(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQInt64(out Int64 value, out int length) {
            if (!SpanUtils.TryReadVLQInt64(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int64 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(Int64 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int64 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(Int64 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24() => ReadVLQUInt24(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24(out int length) {
            var result = SpanUtils.ReadVLQUInt24(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt24(out UInt24 value) => TryReadVLQUInt24(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVLQUInt24(out UInt24 value, out int length) {
            if (!SpanUtils.TryReadVLQUInt24(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt24 value) => WriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteVLQ(UInt24 value, out int length)
        {
            SpanUtils.WriteVLQ(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt24 value) => TryWriteVLQ(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVLQ(UInt24 value, out int length) {
            if (!SpanUtils.TryWriteVLQ(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBytes(int length, out Byte[] value) {
            if (!SpanUtils.TryReadBytes(ReadBuffer, length, out value)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadBytes(int length) {
            var result = SpanUtils.ReadBytes(ReadBuffer, length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte[] value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Byte[] value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Byte[] value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Byte[] value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSpan(int length, out Span<byte> value) {
            if (!SpanUtils.TryReadSpan(ReadBuffer, length, out value)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<byte> ReadSpan(int length) {
            var result = SpanUtils.ReadSpan(ReadBuffer, length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Span<byte> value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Span<byte> value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Span<byte> value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(Span<byte> value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadReadOnlySpan(int length, out ReadOnlySpan<byte> value) {
            if (!SpanUtils.TryReadReadOnlySpan(ReadBuffer, length, out value)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> ReadReadOnlySpan(int length) {
            var result = SpanUtils.ReadReadOnlySpan(ReadBuffer, length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Write(ReadOnlySpan<byte> value) => Write(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(ReadOnlySpan<byte> value, out int length)
        {
            SpanUtils.Write(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(ReadOnlySpan<byte> value) => TryWrite(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWrite(ReadOnlySpan<byte> value, out int length) {
            if (!SpanUtils.TryWrite(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadString(int length, out String value) {
            if (!SpanUtils.TryReadString(ReadBuffer, length, out value)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadString(int length) {
            var result = SpanUtils.ReadString(ReadBuffer, length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteString(String value) => WriteString(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteString(String value, out int length)
        {
            SpanUtils.WriteString(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteString(String value) => TryWriteString(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteString(String value, out int length) {
            if (!SpanUtils.TryWriteString(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize() => ReadSize(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize(out int length) {
            var result = SpanUtils.ReadSize(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSize(out UInt32 value) => TryReadSize(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSize(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadSize(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSize(UInt32 value) => WriteSize(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSize(UInt32 value, out int length)
        {
            SpanUtils.WriteSize(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSize(UInt32 value) => TryWriteSize(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSize(UInt32 value, out int length) {
            if (!SpanUtils.TryWriteSize(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes() => ReadSizedBytes(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte[] ReadSizedBytes(out int length) {
            var result = SpanUtils.ReadSizedBytes(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedBytes(out Byte[] value) => TryReadSizedBytes(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedBytes(out Byte[] value, out int length) {
            if (!SpanUtils.TryReadSizedBytes(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Byte[] value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Byte[] value, out int length)
        {
            SpanUtils.WriteSized(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(Byte[] value) => TryWriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(Byte[] value, out int length) {
            if (!SpanUtils.TryWriteSized(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString() => ReadSizedString(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public String ReadSizedString(out int length) {
            var result = SpanUtils.ReadSizedString(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedString(out String value) => TryReadSizedString(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedString(out String value, out int length) {
            if (!SpanUtils.TryReadSizedString(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(String value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(String value, out int length)
        {
            SpanUtils.WriteSized(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(String value) => TryWriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(String value, out int length) {
            if (!SpanUtils.TryWriteSized(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<byte> ReadSizedSpan() => ReadSizedSpan(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<byte> ReadSizedSpan(out int length) {
            var result = SpanUtils.ReadSizedSpan(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedSpan(out Span<byte> value) => TryReadSizedSpan(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedSpan(out Span<byte> value, out int length) {
            if (!SpanUtils.TryReadSizedSpan(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Span<byte> value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(Span<byte> value, out int length)
        {
            SpanUtils.WriteSized(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(Span<byte> value) => TryWriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(Span<byte> value, out int length) {
            if (!SpanUtils.TryWriteSized(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> ReadSizedReadOnlySpan() => ReadSizedReadOnlySpan(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> ReadSizedReadOnlySpan(out int length) {
            var result = SpanUtils.ReadSizedReadOnlySpan(ReadBuffer, out length);
            _position += length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedReadOnlySpan(out ReadOnlySpan<byte> value) => TryReadSizedReadOnlySpan(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedReadOnlySpan(out ReadOnlySpan<byte> value, out int length) {
            if (!SpanUtils.TryReadSizedReadOnlySpan(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(ReadOnlySpan<byte> value) => WriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSized(ReadOnlySpan<byte> value, out int length)
        {
            SpanUtils.WriteSized(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(ReadOnlySpan<byte> value) => TryWriteSized(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSized(ReadOnlySpan<byte> value, out int length) {
            if (!SpanUtils.TryWriteSized(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByteLE() => ReadSByteLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByteLE(out int length) {
            var result = SpanUtils.ReadSByteLE(ReadBuffer, out length);
            _position += sizeof(SByte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByteLE(out SByte value) => TryReadSByteLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByteLE(out SByte value, out int length) {
            if (!SpanUtils.TryReadSByteLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(SByte value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(SByte value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(SByte value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(SByte value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByteLE() => ReadByteLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByteLE(out int length) {
            var result = SpanUtils.ReadByteLE(ReadBuffer, out length);
            _position += sizeof(Byte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByteLE(out Byte value) => TryReadByteLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByteLE(out Byte value, out int length) {
            if (!SpanUtils.TryReadByteLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Byte value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Byte value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Byte value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Byte value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16LE() => ReadUInt16LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16LE(out int length) {
            var result = SpanUtils.ReadUInt16LE(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16LE(out UInt16 value) => TryReadUInt16LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16LE(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUInt16LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt16 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt16 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt16 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt16 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16LE() => ReadInt16LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16LE(out int length) {
            var result = SpanUtils.ReadInt16LE(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16LE(out Int16 value) => TryReadInt16LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16LE(out Int16 value, out int length) {
            if (!SpanUtils.TryReadInt16LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int16 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int16 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int16 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int16 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32LE() => ReadUInt32LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32LE(out int length) {
            var result = SpanUtils.ReadUInt32LE(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32LE(out UInt32 value) => TryReadUInt32LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32LE(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUInt32LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt32 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt32 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt32 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt32 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32LE() => ReadInt32LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32LE(out int length) {
            var result = SpanUtils.ReadInt32LE(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32LE(out Int32 value) => TryReadInt32LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32LE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt32LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int32 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int32 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int32 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int32 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64LE() => ReadUInt64LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64LE(out int length) {
            var result = SpanUtils.ReadUInt64LE(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64LE(out UInt64 value) => TryReadUInt64LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64LE(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUInt64LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt64 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt64 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt64 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt64 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64LE() => ReadInt64LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64LE(out int length) {
            var result = SpanUtils.ReadInt64LE(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64LE(out Int64 value) => TryReadInt64LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64LE(out Int64 value, out int length) {
            if (!SpanUtils.TryReadInt64LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int64 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int64 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int64 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int64 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingleLE() => ReadSingleLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingleLE(out int length) {
            var result = SpanUtils.ReadSingleLE(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingleLE(out Single value) => TryReadSingleLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingleLE(out Single value, out int length) {
            if (!SpanUtils.TryReadSingleLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Single value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Single value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Single value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Single value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDoubleLE() => ReadDoubleLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDoubleLE(out int length) {
            var result = SpanUtils.ReadDoubleLE(ReadBuffer, out length);
            _position += sizeof(Double);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDoubleLE(out Double value) => TryReadDoubleLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDoubleLE(out Double value, out int length) {
            if (!SpanUtils.TryReadDoubleLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Double value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Double value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Double value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Double value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimalLE() => ReadDecimalLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimalLE(out int length) {
            var result = SpanUtils.ReadDecimalLE(ReadBuffer, out length);
            _position += sizeof(Decimal);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimalLE(out Decimal value) => TryReadDecimalLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimalLE(out Decimal value, out int length) {
            if (!SpanUtils.TryReadDecimalLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Decimal value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Decimal value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Decimal value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Decimal value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBooleanLE() => ReadBooleanLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBooleanLE(out int length) {
            var result = SpanUtils.ReadBooleanLE(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBooleanLE(out Boolean value) => TryReadBooleanLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBooleanLE(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBooleanLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Boolean value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Boolean value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Boolean value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Boolean value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadCharLE() => ReadCharLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadCharLE(out int length) {
            var result = SpanUtils.ReadCharLE(ReadBuffer, out length);
            _position += sizeof(Char);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadCharLE(out Char value) => TryReadCharLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadCharLE(out Char value, out int length) {
            if (!SpanUtils.TryReadCharLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Char value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Char value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Char value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Char value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloatLE() => ReadFloatLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloatLE(out int length) {
            var result = SpanUtils.ReadFloatLE(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloatLE(out Single value) => TryReadFloatLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloatLE(out Single value, out int length) {
            if (!SpanUtils.TryReadFloatLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShortLE() => ReadShortLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShortLE(out int length) {
            var result = SpanUtils.ReadShortLE(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShortLE(out Int16 value) => TryReadShortLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShortLE(out Int16 value, out int length) {
            if (!SpanUtils.TryReadShortLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShortLE() => ReadUShortLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShortLE(out int length) {
            var result = SpanUtils.ReadUShortLE(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShortLE(out UInt16 value) => TryReadUShortLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShortLE(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUShortLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadIntLE() => ReadIntLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadIntLE(out int length) {
            var result = SpanUtils.ReadIntLE(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadIntLE(out Int32 value) => TryReadIntLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadIntLE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadIntLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUIntLE() => ReadUIntLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUIntLE(out int length) {
            var result = SpanUtils.ReadUIntLE(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUIntLE(out UInt32 value) => TryReadUIntLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUIntLE(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUIntLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLongLE() => ReadLongLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLongLE(out int length) {
            var result = SpanUtils.ReadLongLE(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLongLE(out Int64 value) => TryReadLongLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLongLE(out Int64 value, out int length) {
            if (!SpanUtils.TryReadLongLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULongLE() => ReadULongLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULongLE(out int length) {
            var result = SpanUtils.ReadULongLE(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULongLE(out UInt64 value) => TryReadULongLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULongLE(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadULongLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolLE() => ReadBoolLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolLE(out int length) {
            var result = SpanUtils.ReadBoolLE(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolLE(out Boolean value) => TryReadBoolLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolLE(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBoolLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24LE() => ReadUInt24LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24LE(out int length) {
            var result = SpanUtils.ReadUInt24LE(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24LE(out UInt24 value) => TryReadUInt24LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24LE(out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUInt24LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt24 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt24 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt24 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt24 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24LE() => ReadInt24LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24LE(out int length) {
            var result = SpanUtils.ReadInt24LE(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24LE(out Int32 value) => TryReadInt24LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24LE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt24LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24LE(Int32 value) => WriteInt24LE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24LE(Int32 value, out int length)
        {
            SpanUtils.WriteInt24LE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24LE(Int32 value) => TryWriteInt24LE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24LE(Int32 value, out int length) {
            if (!SpanUtils.TryWriteInt24LE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalfLE() => ReadHalfLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalfLE(out int length) {
            var result = SpanUtils.ReadHalfLE(ReadBuffer, out length);
            _position += 2;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalfLE(out Half value) => TryReadHalfLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalfLE(out Half value, out int length) {
            if (!SpanUtils.TryReadHalfLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Half value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Half value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Half value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Half value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128LE() => ReadInt128LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128LE(out int length) {
            var result = SpanUtils.ReadInt128LE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128LE(out Int128 value) => TryReadInt128LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128LE(out Int128 value, out int length) {
            if (!SpanUtils.TryReadInt128LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int128 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Int128 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int128 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Int128 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128LE() => ReadUInt128LE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128LE(out int length) {
            var result = SpanUtils.ReadUInt128LE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128LE(out UInt128 value) => TryReadUInt128LE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128LE(out UInt128 value, out int length) {
            if (!SpanUtils.TryReadUInt128LE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt128 value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(UInt128 value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt128 value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(UInt128 value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuidLE() => ReadGuidLE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuidLE(out int length) {
            var result = SpanUtils.ReadGuidLE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuidLE(out Guid value) => TryReadGuidLE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuidLE(out Guid value, out int length) {
            if (!SpanUtils.TryReadGuidLE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Guid value) => WriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteLE(Guid value, out int length)
        {
            SpanUtils.WriteLE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Guid value) => TryWriteLE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteLE(Guid value, out int length) {
            if (!SpanUtils.TryWriteLE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByteBE() => ReadSByteBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SByte ReadSByteBE(out int length) {
            var result = SpanUtils.ReadSByteBE(ReadBuffer, out length);
            _position += sizeof(SByte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByteBE(out SByte value) => TryReadSByteBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSByteBE(out SByte value, out int length) {
            if (!SpanUtils.TryReadSByteBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(SByte value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(SByte value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(SByte value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(SByte value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByteBE() => ReadByteBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Byte ReadByteBE(out int length) {
            var result = SpanUtils.ReadByteBE(ReadBuffer, out length);
            _position += sizeof(Byte);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByteBE(out Byte value) => TryReadByteBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadByteBE(out Byte value, out int length) {
            if (!SpanUtils.TryReadByteBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Byte value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Byte value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Byte value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Byte value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16BE() => ReadUInt16BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16BE(out int length) {
            var result = SpanUtils.ReadUInt16BE(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16BE(out UInt16 value) => TryReadUInt16BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt16BE(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUInt16BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt16 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt16 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt16 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt16 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16BE() => ReadInt16BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16BE(out int length) {
            var result = SpanUtils.ReadInt16BE(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16BE(out Int16 value) => TryReadInt16BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt16BE(out Int16 value, out int length) {
            if (!SpanUtils.TryReadInt16BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int16 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int16 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int16 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int16 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32BE() => ReadUInt32BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32BE(out int length) {
            var result = SpanUtils.ReadUInt32BE(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32BE(out UInt32 value) => TryReadUInt32BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt32BE(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUInt32BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt32 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt32 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt32 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt32 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32BE() => ReadInt32BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32BE(out int length) {
            var result = SpanUtils.ReadInt32BE(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32BE(out Int32 value) => TryReadInt32BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt32BE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt32BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int32 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int32 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int32 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int32 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64BE() => ReadUInt64BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64BE(out int length) {
            var result = SpanUtils.ReadUInt64BE(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64BE(out UInt64 value) => TryReadUInt64BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt64BE(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUInt64BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt64 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt64 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt64 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt64 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64BE() => ReadInt64BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64BE(out int length) {
            var result = SpanUtils.ReadInt64BE(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64BE(out Int64 value) => TryReadInt64BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt64BE(out Int64 value, out int length) {
            if (!SpanUtils.TryReadInt64BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int64 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int64 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int64 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int64 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingleBE() => ReadSingleBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadSingleBE(out int length) {
            var result = SpanUtils.ReadSingleBE(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingleBE(out Single value) => TryReadSingleBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSingleBE(out Single value, out int length) {
            if (!SpanUtils.TryReadSingleBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Single value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Single value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Single value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Single value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDoubleBE() => ReadDoubleBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Double ReadDoubleBE(out int length) {
            var result = SpanUtils.ReadDoubleBE(ReadBuffer, out length);
            _position += sizeof(Double);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDoubleBE(out Double value) => TryReadDoubleBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDoubleBE(out Double value, out int length) {
            if (!SpanUtils.TryReadDoubleBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Double value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Double value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Double value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Double value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimalBE() => ReadDecimalBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Decimal ReadDecimalBE(out int length) {
            var result = SpanUtils.ReadDecimalBE(ReadBuffer, out length);
            _position += sizeof(Decimal);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimalBE(out Decimal value) => TryReadDecimalBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadDecimalBE(out Decimal value, out int length) {
            if (!SpanUtils.TryReadDecimalBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Decimal value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Decimal value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Decimal value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Decimal value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBooleanBE() => ReadBooleanBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBooleanBE(out int length) {
            var result = SpanUtils.ReadBooleanBE(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBooleanBE(out Boolean value) => TryReadBooleanBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBooleanBE(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBooleanBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Boolean value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Boolean value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Boolean value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Boolean value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadCharBE() => ReadCharBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Char ReadCharBE(out int length) {
            var result = SpanUtils.ReadCharBE(ReadBuffer, out length);
            _position += sizeof(Char);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadCharBE(out Char value) => TryReadCharBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadCharBE(out Char value, out int length) {
            if (!SpanUtils.TryReadCharBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Char value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Char value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Char value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Char value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloatBE() => ReadFloatBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Single ReadFloatBE(out int length) {
            var result = SpanUtils.ReadFloatBE(ReadBuffer, out length);
            _position += sizeof(Single);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloatBE(out Single value) => TryReadFloatBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadFloatBE(out Single value, out int length) {
            if (!SpanUtils.TryReadFloatBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShortBE() => ReadShortBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShortBE(out int length) {
            var result = SpanUtils.ReadShortBE(ReadBuffer, out length);
            _position += sizeof(Int16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShortBE(out Int16 value) => TryReadShortBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadShortBE(out Int16 value, out int length) {
            if (!SpanUtils.TryReadShortBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShortBE() => ReadUShortBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShortBE(out int length) {
            var result = SpanUtils.ReadUShortBE(ReadBuffer, out length);
            _position += sizeof(UInt16);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShortBE(out UInt16 value) => TryReadUShortBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUShortBE(out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUShortBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadIntBE() => ReadIntBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadIntBE(out int length) {
            var result = SpanUtils.ReadIntBE(ReadBuffer, out length);
            _position += sizeof(Int32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadIntBE(out Int32 value) => TryReadIntBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadIntBE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadIntBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUIntBE() => ReadUIntBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUIntBE(out int length) {
            var result = SpanUtils.ReadUIntBE(ReadBuffer, out length);
            _position += sizeof(UInt32);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUIntBE(out UInt32 value) => TryReadUIntBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUIntBE(out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUIntBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLongBE() => ReadLongBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLongBE(out int length) {
            var result = SpanUtils.ReadLongBE(ReadBuffer, out length);
            _position += sizeof(Int64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLongBE(out Int64 value) => TryReadLongBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadLongBE(out Int64 value, out int length) {
            if (!SpanUtils.TryReadLongBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULongBE() => ReadULongBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULongBE(out int length) {
            var result = SpanUtils.ReadULongBE(ReadBuffer, out length);
            _position += sizeof(UInt64);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULongBE(out UInt64 value) => TryReadULongBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadULongBE(out UInt64 value, out int length) {
            if (!SpanUtils.TryReadULongBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolBE() => ReadBoolBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Boolean ReadBoolBE(out int length) {
            var result = SpanUtils.ReadBoolBE(ReadBuffer, out length);
            _position += sizeof(Boolean);
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolBE(out Boolean value) => TryReadBoolBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadBoolBE(out Boolean value, out int length) {
            if (!SpanUtils.TryReadBoolBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24BE() => ReadUInt24BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24BE(out int length) {
            var result = SpanUtils.ReadUInt24BE(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24BE(out UInt24 value) => TryReadUInt24BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt24BE(out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUInt24BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt24 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt24 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt24 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt24 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24BE() => ReadInt24BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt24BE(out int length) {
            var result = SpanUtils.ReadInt24BE(ReadBuffer, out length);
            _position += 3;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24BE(out Int32 value) => TryReadInt24BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt24BE(out Int32 value, out int length) {
            if (!SpanUtils.TryReadInt24BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24BE(Int32 value) => WriteInt24BE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteInt24BE(Int32 value, out int length)
        {
            SpanUtils.WriteInt24BE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24BE(Int32 value) => TryWriteInt24BE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteInt24BE(Int32 value, out int length) {
            if (!SpanUtils.TryWriteInt24BE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalfBE() => ReadHalfBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Half ReadHalfBE(out int length) {
            var result = SpanUtils.ReadHalfBE(ReadBuffer, out length);
            _position += 2;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalfBE(out Half value) => TryReadHalfBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadHalfBE(out Half value, out int length) {
            if (!SpanUtils.TryReadHalfBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Half value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Half value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Half value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Half value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128BE() => ReadInt128BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 ReadInt128BE(out int length) {
            var result = SpanUtils.ReadInt128BE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128BE(out Int128 value) => TryReadInt128BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadInt128BE(out Int128 value, out int length) {
            if (!SpanUtils.TryReadInt128BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int128 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Int128 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int128 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Int128 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128BE() => ReadUInt128BE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 ReadUInt128BE(out int length) {
            var result = SpanUtils.ReadUInt128BE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128BE(out UInt128 value) => TryReadUInt128BE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadUInt128BE(out UInt128 value, out int length) {
            if (!SpanUtils.TryReadUInt128BE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt128 value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(UInt128 value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt128 value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(UInt128 value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuidBE() => ReadGuidBE(out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuidBE(out int length) {
            var result = SpanUtils.ReadGuidBE(ReadBuffer, out length);
            _position += 16;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuidBE(out Guid value) => TryReadGuidBE(out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadGuidBE(out Guid value, out int length) {
            if (!SpanUtils.TryReadGuidBE(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Guid value) => WriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBE(Guid value, out int length)
        {
            SpanUtils.WriteBE(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Guid value) => TryWriteBE(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteBE(Guid value, out int length) {
            if (!SpanUtils.TryWriteBE(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VInt ReadVInt(int maxLength = 8) {
            var value = SpanUtils.ReadVInt(ReadBuffer, maxLength);
            _position += value.Length;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadVInt(out VInt value, int maxLength = 8) {
            if (!SpanUtils.TryReadVInt(ReadBuffer, out value, maxLength)) return false;
            _position += value.Length;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVInt(ulong value) {
            var length = SpanUtils.WriteVInt(WriteBuffer, value);
            AdvanceWrite(length);
            return length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteVInt(ulong value, out int length) {
            if (!SpanUtils.TryWriteVInt(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;
        }

    }

}
