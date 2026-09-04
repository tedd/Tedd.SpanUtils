// This file is auto-generated. Do not modify.

using System;
using System.Buffers.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
namespace Tedd {
    public static partial class SpanUtils {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(ref Span<byte> span, int length) => span = span.Slice(length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(ref ReadOnlySpan<byte> span, int length) => span = span.Slice(length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(Span<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSByte(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByte(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(Span<byte> span, out SByte value) => SpanUtils.TryReadSByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSByte(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByte(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, SByte value) {
            span[0] = (Byte)value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, SByte value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, SByte value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(ref Span<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByte(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(ref Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByte(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(ref ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByte(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(ref ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByte(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, SByte value) {
            span[0] = (Byte)value;

            span = span.Slice(sizeof(SByte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, SByte value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, SByte value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(Span<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadByte(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByte(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(Span<byte> span, out Byte value) => SpanUtils.TryReadByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(ReadOnlySpan<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadByte(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByte(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Byte value) {
            span[0] = value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Byte value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Byte value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(ref Span<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByte(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(ref Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByte(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(ref ReadOnlySpan<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByte(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(ref ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByte(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Byte value) {
            span[0] = value;

            span = span.Slice(sizeof(Byte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Byte value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Byte value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt16 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt16 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt16 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt16 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(UInt16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt16 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int16 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int16 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int16 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int16 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(Int16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int16 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt32 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt32 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt32 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt32 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(UInt32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt32 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int32 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int32 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int32 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int32 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(Int32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt64 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt64 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt64 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt64 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(UInt64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt64 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int64 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int64 value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int64 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int64 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(Int64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int64 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSingle(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingle(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(Span<byte> span, out Single value) => SpanUtils.TryReadSingle(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSingle(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingle(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingle(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Single value) {
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Single value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Single value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingle(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingle(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingle(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingle(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingle(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingle(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Single value) {
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value));

            span = span.Slice(sizeof(Single));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Single value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Single value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDouble(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDouble(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(Span<byte> span, out Double value) => SpanUtils.TryReadDouble(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDouble(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDouble(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDouble(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Double value) {
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Double value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Double value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(ref Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDouble(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(ref Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDouble(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDouble(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDouble(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(ref ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDouble(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDouble(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Double value) {
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value));

            span = span.Slice(sizeof(Double));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Double value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Double value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(Span<byte> span) {
            var ret = MemoryMarshal.Read<Decimal>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimal(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimal(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimal(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Decimal>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimal(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimal(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimal(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Decimal value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Decimal value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Decimal value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Decimal>(span);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimal(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(ref Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimal(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimal(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Decimal>(span);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimal(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(ref ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimal(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimal(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Decimal value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(sizeof(Decimal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Decimal value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolean(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolean(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolean(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolean(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolean(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolean(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Boolean value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Boolean value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolean(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolean(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolean(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolean(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolean(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolean(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;

            span = span.Slice(sizeof(Boolean));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Boolean value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadChar(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadChar(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(Span<byte> span, out Char value) => SpanUtils.TryReadChar(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadChar(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadChar(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadChar(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Char value) {
            SpanUtils.Write(span, (UInt16)value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Char value, out int length) {
            SpanUtils.Write(span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Char value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(ref Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadChar(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(ref Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadChar(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadChar(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(ref ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadChar(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(ref ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadChar(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadChar(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Char value) {
            SpanUtils.Write(span, (UInt16)value);

            span = span.Slice(sizeof(Char));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Char value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Char value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadFloat(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloat(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(Span<byte> span, out Single value) => SpanUtils.TryReadFloat(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadFloat(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloat(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloat(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloat(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloat(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloat(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloat(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloat(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloat(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadShort(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShort(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(Span<byte> span, out Int16 value) => SpanUtils.TryReadShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadShort(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShort(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShort(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShort(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int16>(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShort(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShort(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUShort(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShort(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUShort(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShort(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShort(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShort(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt16>(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShort(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShort(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int32>(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt32>(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadLong(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLong(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(Span<byte> span, out Int64 value) => SpanUtils.TryReadLong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadLong(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLong(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLong(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLong(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int64>(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLong(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLong(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadULong(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULong(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(Span<byte> span, out UInt64 value) => SpanUtils.TryReadULong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadULong(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULong(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULong(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULong(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt64>(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULong(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULong(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBool(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBool(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(Span<byte> span, out Boolean value) => SpanUtils.TryReadBool(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBool(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBool(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBool(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBool(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBool(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBool(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBool(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBool(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBool(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(Span<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(ReadOnlySpan<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)((UInt32)value >> 16); span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt24 value, out int length) {
            SpanUtils.Write(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt24 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref Span<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(ref Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref ReadOnlySpan<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(ref ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)((UInt32)value >> 16); span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)value;

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt24 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24(Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.Write(span, (UInt24)((UInt32)value & 0xFFFFFFU));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24(Span<byte> span, Int32 value, out int length) {
            SpanUtils.WriteInt24(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24(Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.WriteInt24(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24(Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(ref Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(ref ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24(ref Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.Write(span, (UInt24)((UInt32)value & 0xFFFFFFU));

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWriteInt24(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.MoveWriteInt24(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadHalf(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalf(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(Span<byte> span, out Half value) => SpanUtils.TryReadHalf(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadHalf(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalf(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalf(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Half value) {
            SpanUtils.Write(span, BitConverter.HalfToInt16Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Half value, out int length) {
            SpanUtils.Write(span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Half value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(ref Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalf(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(ref Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalf(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalf(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalf(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(ref ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalf(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalf(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Half value) {
            SpanUtils.Write(span, BitConverter.HalfToInt16Bits(value));

            span = span.Slice(2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Half value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Half value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(Span<byte> span) {
            var ret = MemoryMarshal.Read<Int128>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int128>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int128 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Int128 value, out int length) {
            SpanUtils.Write(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Int128 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<Int128>(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(ref Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<Int128>(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(ref ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int128 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Int128 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt128>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt128>(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt128 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, UInt128 value, out int length) {
            SpanUtils.Write(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, UInt128 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(ref Span<byte> span) {
            var ret = MemoryMarshal.Read<UInt128>(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(ref Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(ref ReadOnlySpan<byte> span) {
            var ret = MemoryMarshal.Read<UInt128>(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(ref ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt128 value) {

#if NET8_0_OR_GREATER
            MemoryMarshal.Write(span, in value);
#else
            MemoryMarshal.Write(span, ref value);
#endif

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, UInt128 value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(Span<byte> span) {
            var ret = new Guid(span.Slice(0, 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadGuid(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuid(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(Span<byte> span, out Guid value) => SpanUtils.TryReadGuid(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(ReadOnlySpan<byte> span) {
            var ret = new Guid(span.Slice(0, 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadGuid(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuid(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuid(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Guid value) {
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException(nameof(span));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Guid value, out int length) {
            SpanUtils.Write(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.Write(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Guid value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(ref Span<byte> span) {
            var ret = new Guid(span.Slice(0, 16));

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuid(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(ref Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuid(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuid(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(ref ReadOnlySpan<byte> span) {
            var ret = new Guid(span.Slice(0, 16));

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuid(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(ref ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuid(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuid(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Guid value) {
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException(nameof(span));

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Guid value, out int length) {
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWrite(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Guid value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(Span<byte> span) => SpanUtils.ReadVLQUInt16(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(Span<byte> span, out int length) {
            var ret = (UInt16)SpanUtils.ReadUnsignedVLQ(span, 16, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(Span<byte> span, out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt16)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(Span<byte> span, out UInt16 value) => SpanUtils.TryReadVLQUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt16(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt16)SpanUtils.ReadUnsignedVLQ(span, 16, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt16)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadVLQUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt16 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt16 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt16 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt16 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(ref Span<byte> span) => SpanUtils.MoveReadVLQUInt16(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(ref Span<byte> span, out int length) {
            var ret = (UInt16)SpanUtils.ReadUnsignedVLQ(span, 16, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(ref Span<byte> span, out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt16)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt16(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt16)SpanUtils.ReadUnsignedVLQ(span, 16, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt16)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt16 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt16 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt16 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(Span<byte> span) => SpanUtils.ReadVLQInt16(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(Span<byte> span, out int length) {
            var ret = (Int16)SpanUtils.ReadSignedVLQ(span, 16, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(Span<byte> span, out Int16 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int16)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(Span<byte> span, out Int16 value) => SpanUtils.TryReadVLQInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt16(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = (Int16)SpanUtils.ReadSignedVLQ(span, 16, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int16)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadVLQInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int16 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int16 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int16.MinValue);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int16 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int16 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(ref Span<byte> span) => SpanUtils.MoveReadVLQInt16(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(ref Span<byte> span, out int length) {
            var ret = (Int16)SpanUtils.ReadSignedVLQ(span, 16, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(ref Span<byte> span, out Int16 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int16)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt16(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (Int16)SpanUtils.ReadSignedVLQ(span, 16, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 16, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int16)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int16 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int16 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int16.MinValue);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int16 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(Span<byte> span) => SpanUtils.ReadVLQUInt32(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(Span<byte> span, out int length) {
            var ret = (UInt32)SpanUtils.ReadUnsignedVLQ(span, 32, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(Span<byte> span, out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt32)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(Span<byte> span, out UInt32 value) => SpanUtils.TryReadVLQUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt32(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt32)SpanUtils.ReadUnsignedVLQ(span, 32, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt32)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadVLQUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt32 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt32 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt32 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt32 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(ref Span<byte> span) => SpanUtils.MoveReadVLQUInt32(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(ref Span<byte> span, out int length) {
            var ret = (UInt32)SpanUtils.ReadUnsignedVLQ(span, 32, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(ref Span<byte> span, out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt32)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt32(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt32)SpanUtils.ReadUnsignedVLQ(span, 32, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt32)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt32 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt32 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(Span<byte> span) => SpanUtils.ReadVLQInt32(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(Span<byte> span, out int length) {
            var ret = (Int32)SpanUtils.ReadSignedVLQ(span, 32, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(Span<byte> span, out Int32 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int32)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(Span<byte> span, out Int32 value) => SpanUtils.TryReadVLQInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt32(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = (Int32)SpanUtils.ReadSignedVLQ(span, 32, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int32)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadVLQInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int32 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int32 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int32.MinValue);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int32 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int32 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(ref Span<byte> span) => SpanUtils.MoveReadVLQInt32(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(ref Span<byte> span, out int length) {
            var ret = (Int32)SpanUtils.ReadSignedVLQ(span, 32, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(ref Span<byte> span, out Int32 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int32)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt32(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (Int32)SpanUtils.ReadSignedVLQ(span, 32, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 32, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int32)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int32 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int32.MinValue);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int32 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(Span<byte> span) => SpanUtils.ReadVLQUInt64(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUnsignedVLQ(span, 64, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(Span<byte> span, out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt64)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(Span<byte> span, out UInt64 value) => SpanUtils.TryReadVLQUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt64(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUnsignedVLQ(span, 64, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt64)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadVLQUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt64 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt64 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt64 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt64 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(ref Span<byte> span) => SpanUtils.MoveReadVLQUInt64(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(ref Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUnsignedVLQ(span, 64, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(ref Span<byte> span, out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt64)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt64(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUnsignedVLQ(span, 64, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt64)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt64 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt64 value, out int length) {
            length = SpanUtils.WriteUnsignedVLQ(span, value);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt64 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(Span<byte> span) => SpanUtils.ReadVLQInt64(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(Span<byte> span, out int length) {
            var ret = (Int64)SpanUtils.ReadSignedVLQ(span, 64, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(Span<byte> span, out Int64 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int64)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(Span<byte> span, out Int64 value) => SpanUtils.TryReadVLQInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt64(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = (Int64)SpanUtils.ReadSignedVLQ(span, 64, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int64)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadVLQInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int64 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, Int64 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int64.MinValue);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int64 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, Int64 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(ref Span<byte> span) => SpanUtils.MoveReadVLQInt64(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(ref Span<byte> span, out int length) {
            var ret = (Int64)SpanUtils.ReadSignedVLQ(span, 64, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(ref Span<byte> span, out Int64 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int64)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt64(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (Int64)SpanUtils.ReadSignedVLQ(span, 64, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (!SpanUtils.TryReadSignedVLQCore(span, 64, out var decoded, out length, out _)) { value = default; return false; }
            value = (Int64)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int64 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, Int64 value, out int length) {
            length = SpanUtils.WriteSignedVLQ(span, value, Int64.MinValue);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int64 value, out int length) {
            length = 0;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(Span<byte> span) => SpanUtils.ReadVLQUInt24(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(Span<byte> span, out int length) {
            var ret = (UInt24)SpanUtils.ReadUnsignedVLQ(span, 24, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(Span<byte> span, out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 24, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt24)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(Span<byte> span, out UInt24 value) => SpanUtils.TryReadVLQUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt24(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)SpanUtils.ReadUnsignedVLQ(span, 24, out length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 24, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt24)decoded;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadVLQUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt24 value) => SpanUtils.WriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(Span<byte> span, UInt24 value, out int length) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            length = SpanUtils.WriteUnsignedVLQ(span, (UInt32)value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt24 value, out int length) {
            length = 0;
            if ((UInt32)value > 0xFFFFFFU) return false;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.WriteVLQ(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(Span<byte> span, UInt24 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(ref Span<byte> span) => SpanUtils.MoveReadVLQUInt24(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(ref Span<byte> span, out int length) {
            var ret = (UInt24)SpanUtils.ReadUnsignedVLQ(span, 24, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(ref Span<byte> span, out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 24, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt24)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt24(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)SpanUtils.ReadUnsignedVLQ(span, 24, out length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(ref ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (!SpanUtils.TryReadUnsignedVLQCore(span, 24, out var decoded, out length, out _)) { value = default; return false; }
            value = (UInt24)decoded;
            span = span.Slice(length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt24 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(ref Span<byte> span, UInt24 value, out int length) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            length = SpanUtils.WriteUnsignedVLQ(span, (UInt32)value);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt24 value, out int length) {
            length = 0;
            if ((UInt32)value > 0xFFFFFFU) return false;
            var required = SpanUtils.MeasureVLQ(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteVLQ(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(Span<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBytes(Span<byte> span, int length, out Byte[] value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadBytes(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBytes(ReadOnlySpan<byte> span, int length, out Byte[] value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadBytes(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Byte[] value) => SpanUtils.Write(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Byte[] value, out int length) {

            value.CopyTo(span);
            length = value.Length;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Byte[] value, out int length) {
            length = 0;
            if (value == null) return false;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.Write(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Byte[] value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadBytes(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBytes(ref Span<byte> span, int length, out Byte[] value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadBytes(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadBytes(ref ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBytes(ref ReadOnlySpan<byte> span, int length, out Byte[] value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadBytes(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Byte[] value) => SpanUtils.MoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Byte[] value, out int length) {

            value.CopyTo(span);
            length = value.Length;

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Byte[] value, out int length) {
            length = 0;
            if (value == null) return false;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.MoveWrite(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Byte[] value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSpan(Span<byte> span, int length) {
            var ret = span.Slice(0, length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSpan(Span<byte> span, int length, out Span<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadSpan(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Span<byte> value) => SpanUtils.Write(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, Span<byte> value, out int length) {

            value.CopyTo(span);
            length = value.Length;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Span<byte> value, out int length) {
            length = 0;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.Write(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, Span<byte> value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSpan(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSpan(ref Span<byte> span, int length, out Span<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadSpan(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Span<byte> value) => SpanUtils.MoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, Span<byte> value, out int length) {

            value.CopyTo(span);
            length = value.Length;

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Span<byte> value, out int length) {
            length = 0;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.MoveWrite(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, Span<byte> value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadReadOnlySpan(Span<byte> span, int length) {
            var ret = span.Slice(0, length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadReadOnlySpan(Span<byte> span, int length, out ReadOnlySpan<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadReadOnlySpan(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadReadOnlySpan(ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadReadOnlySpan(ReadOnlySpan<byte> span, int length, out ReadOnlySpan<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadReadOnlySpan(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.Write(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(Span<byte> span, ReadOnlySpan<byte> value, out int length) {

            value.CopyTo(span);
            length = value.Length;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            length = 0;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.Write(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadReadOnlySpan(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadReadOnlySpan(ref Span<byte> span, int length, out ReadOnlySpan<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadReadOnlySpan(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadReadOnlySpan(ref ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length);

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadReadOnlySpan(ref ReadOnlySpan<byte> span, int length, out ReadOnlySpan<byte> value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadReadOnlySpan(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.MoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref Span<byte> span, ReadOnlySpan<byte> value, out int length) {

            value.CopyTo(span);
            length = value.Length;

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            length = 0;
            var required = value.Length;
            if (span.Length < required) return false;
            SpanUtils.MoveWrite(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(Span<byte> span, int length) {
            var ret = Encoding.UTF8.GetString(span.Slice(0, length));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadString(Span<byte> span, int length, out String value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadString(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(ReadOnlySpan<byte> span, int length) {
            var ret = Encoding.UTF8.GetString(span.Slice(0, length));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadString(ReadOnlySpan<byte> span, int length, out String value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.ReadString(span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteString(Span<byte> span, String value) => SpanUtils.WriteString(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteString(Span<byte> span, String value, out int length) {

            if (value == null) throw new ArgumentNullException(nameof(value));
            var required = Encoding.UTF8.GetByteCount(value);
            if (span.Length < required) throw new ArgumentException("String exceeds destination capacity.", nameof(span));
            length = Encoding.UTF8.GetBytes(value.AsSpan(), span);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteString(Span<byte> span, String value, out int length) {
            length = 0;
            if (value == null) return false;
            var required = Encoding.UTF8.GetByteCount(value);
            if (span.Length < required) return false;
            SpanUtils.WriteString(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteString(Span<byte> span, String value) => SpanUtils.TryWriteString(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadString(ref Span<byte> span, int length) {
            var ret = Encoding.UTF8.GetString(span.Slice(0, length));

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadString(ref Span<byte> span, int length, out String value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadString(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadString(ref ReadOnlySpan<byte> span, int length) {
            var ret = Encoding.UTF8.GetString(span.Slice(0, length));

            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadString(ref ReadOnlySpan<byte> span, int length, out String value) {
            if ((uint)length > (uint)span.Length) { value = default; return false; }
            value = SpanUtils.MoveReadString(ref span, length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteString(ref Span<byte> span, String value) => SpanUtils.MoveWriteString(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteString(ref Span<byte> span, String value, out int length) {

            if (value == null) throw new ArgumentNullException(nameof(value));
            var required = Encoding.UTF8.GetByteCount(value);
            if (span.Length < required) throw new ArgumentException("String exceeds destination capacity.", nameof(span));
            length = Encoding.UTF8.GetBytes(value.AsSpan(), span);

            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteString(ref Span<byte> span, String value, out int length) {
            length = 0;
            if (value == null) return false;
            var required = Encoding.UTF8.GetByteCount(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteString(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteString(ref Span<byte> span, String value) => SpanUtils.TryMoveWriteString(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(Span<byte> span) => SpanUtils.ReadSize(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(Span<byte> span, out int length) {
            var first = span[0];
            length = (first >> 6) + 1;
            UInt32 ret = length switch
            {
                1 => (UInt32)first,
                2 => BinaryPrimitives.ReadUInt16BigEndian(span) & 0x3FFFU,
                3 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0x3FFFFFU,
                _ => BinaryPrimitives.ReadUInt32BigEndian(span) & 0x3FFFFFFFU
            };

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(Span<byte> span, out UInt32 value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            value = SpanUtils.ReadSize(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(Span<byte> span, out UInt32 value) => SpanUtils.TryReadSize(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(ReadOnlySpan<byte> span) => SpanUtils.ReadSize(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(ReadOnlySpan<byte> span, out int length) {
            var first = span[0];
            length = (first >> 6) + 1;
            UInt32 ret = length switch
            {
                1 => (UInt32)first,
                2 => BinaryPrimitives.ReadUInt16BigEndian(span) & 0x3FFFU,
                3 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0x3FFFFFU,
                _ => BinaryPrimitives.ReadUInt32BigEndian(span) & 0x3FFFFFFFU
            };

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            value = SpanUtils.ReadSize(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadSize(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSize(Span<byte> span, UInt32 value) => SpanUtils.WriteSize(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSize(Span<byte> span, UInt32 value, out int length) {
            length = SpanUtils.MeasureWriteSize(value);
            switch (length)
            {
                case 1: span[0] = (Byte)value; break;
                case 2: BinaryPrimitives.WriteUInt16BigEndian(span, (UInt16)(value | 0x4000U)); break;
                case 3: SpanUtils.WriteBE(span, (UInt24)(value | 0x800000U)); break;
                default: BinaryPrimitives.WriteUInt32BigEndian(span, value | 0xC0000000U); break;
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSize(Span<byte> span, UInt32 value, out int length) {
            length = 0;
            if (value > 0x3FFFFFFFU) return false;
            var required = SpanUtils.MeasureWriteSize(value);
            if (span.Length < required) return false;
            SpanUtils.WriteSize(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSize(Span<byte> span, UInt32 value) => SpanUtils.TryWriteSize(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(ref Span<byte> span) => SpanUtils.MoveReadSize(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(ref Span<byte> span, out int length) {
            var first = span[0];
            length = (first >> 6) + 1;
            UInt32 ret = length switch
            {
                1 => (UInt32)first,
                2 => BinaryPrimitives.ReadUInt16BigEndian(span) & 0x3FFFU,
                3 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0x3FFFFFU,
                _ => BinaryPrimitives.ReadUInt32BigEndian(span) & 0x3FFFFFFFU
            };
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(ref Span<byte> span, out UInt32 value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            value = SpanUtils.MoveReadSize(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadSize(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSize(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(ref ReadOnlySpan<byte> span, out int length) {
            var first = span[0];
            length = (first >> 6) + 1;
            UInt32 ret = length switch
            {
                1 => (UInt32)first,
                2 => BinaryPrimitives.ReadUInt16BigEndian(span) & 0x3FFFU,
                3 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0x3FFFFFU,
                _ => BinaryPrimitives.ReadUInt32BigEndian(span) & 0x3FFFFFFFU
            };
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            value = SpanUtils.MoveReadSize(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadSize(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSize(ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteSize(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSize(ref Span<byte> span, UInt32 value, out int length) {
            length = SpanUtils.MeasureWriteSize(value);
            switch (length)
            {
                case 1: span[0] = (Byte)value; break;
                case 2: BinaryPrimitives.WriteUInt16BigEndian(span, (UInt16)(value | 0x4000U)); break;
                case 3: SpanUtils.WriteBE(span, (UInt24)(value | 0x800000U)); break;
                default: BinaryPrimitives.WriteUInt32BigEndian(span, value | 0xC0000000U); break;
            }
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSize(ref Span<byte> span, UInt32 value, out int length) {
            length = 0;
            if (value > 0x3FFFFFFFU) return false;
            var required = SpanUtils.MeasureWriteSize(value);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteSize(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSize(ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteSize(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(Span<byte> span) => SpanUtils.ReadSizedBytes(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size).ToArray();
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(Span<byte> span, out Byte[] value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedBytes(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(Span<byte> span, out Byte[] value) => SpanUtils.TryReadSizedBytes(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(ReadOnlySpan<byte> span) => SpanUtils.ReadSizedBytes(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size).ToArray();
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(ReadOnlySpan<byte> span, out Byte[] value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedBytes(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(ReadOnlySpan<byte> span, out Byte[] value) => SpanUtils.TryReadSizedBytes(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, Byte[] value) => SpanUtils.WriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, Byte[] value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, Byte[] value, out int length) {
            length = 0;
            if (value == null) return false;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.WriteSized(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, Byte[] value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(ref Span<byte> span) => SpanUtils.MoveReadSizedBytes(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(ref Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size).ToArray();
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(ref Span<byte> span, out Byte[] value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedBytes(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(ref Span<byte> span, out Byte[] value) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedBytes(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(ref ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size).ToArray();
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(ref ReadOnlySpan<byte> span, out Byte[] value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedBytes(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(ref ReadOnlySpan<byte> span, out Byte[] value) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, Byte[] value) => SpanUtils.MoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, Byte[] value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, Byte[] value, out int length) {
            length = 0;
            if (value == null) return false;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteSized(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, Byte[] value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(Span<byte> span) => SpanUtils.ReadSizedString(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = Encoding.UTF8.GetString(span.Slice(prefix, size));
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(Span<byte> span, out String value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedString(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(Span<byte> span, out String value) => SpanUtils.TryReadSizedString(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(ReadOnlySpan<byte> span) => SpanUtils.ReadSizedString(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = Encoding.UTF8.GetString(span.Slice(prefix, size));
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(ReadOnlySpan<byte> span, out String value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedString(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(ReadOnlySpan<byte> span, out String value) => SpanUtils.TryReadSizedString(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, String value) => SpanUtils.WriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, String value, out int length) {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            var byteCount = Encoding.UTF8.GetByteCount(value);
            var prefix = SpanUtils.MeasureWriteSize((UInt32)byteCount);
            if (span.Length < prefix || byteCount > span.Length - prefix)
                throw new ArgumentException("String exceeds destination capacity.", nameof(span));
            Encoding.UTF8.GetBytes(value.AsSpan(), span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)byteCount);
            length = prefix + byteCount;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, String value, out int length) {
            length = 0;
            if (value == null) return false;
            var count = Encoding.UTF8.GetByteCount(value);
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.WriteSized(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, String value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(ref Span<byte> span) => SpanUtils.MoveReadSizedString(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(ref Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = Encoding.UTF8.GetString(span.Slice(prefix, size));
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(ref Span<byte> span, out String value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedString(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(ref Span<byte> span, out String value) => SpanUtils.TryMoveReadSizedString(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedString(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(ref ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = Encoding.UTF8.GetString(span.Slice(prefix, size));
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(ref ReadOnlySpan<byte> span, out String value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedString(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(ref ReadOnlySpan<byte> span, out String value) => SpanUtils.TryMoveReadSizedString(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, String value) => SpanUtils.MoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, String value, out int length) {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            var byteCount = Encoding.UTF8.GetByteCount(value);
            var prefix = SpanUtils.MeasureWriteSize((UInt32)byteCount);
            if (span.Length < prefix || byteCount > span.Length - prefix)
                throw new ArgumentException("String exceeds destination capacity.", nameof(span));
            Encoding.UTF8.GetBytes(value.AsSpan(), span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)byteCount);
            length = prefix + byteCount;
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, String value, out int length) {
            length = 0;
            if (value == null) return false;
            var count = Encoding.UTF8.GetByteCount(value);
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteSized(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, String value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSizedSpan(Span<byte> span) => SpanUtils.ReadSizedSpan(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSizedSpan(Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedSpan(Span<byte> span, out Span<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedSpan(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedSpan(Span<byte> span, out Span<byte> value) => SpanUtils.TryReadSizedSpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, Span<byte> value) => SpanUtils.WriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, Span<byte> value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, Span<byte> value, out int length) {
            length = 0;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.WriteSized(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, Span<byte> value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSizedSpan(ref Span<byte> span) => SpanUtils.MoveReadSizedSpan(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSizedSpan(ref Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedSpan(ref Span<byte> span, out Span<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedSpan(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedSpan(ref Span<byte> span, out Span<byte> value) => SpanUtils.TryMoveReadSizedSpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, Span<byte> value) => SpanUtils.MoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, Span<byte> value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, Span<byte> value, out int length) {
            length = 0;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteSized(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, Span<byte> value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(Span<byte> span) => SpanUtils.ReadSizedReadOnlySpan(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(Span<byte> span, out ReadOnlySpan<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedReadOnlySpan(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(Span<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(ReadOnlySpan<byte> span) => SpanUtils.ReadSizedReadOnlySpan(span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.ReadSizedReadOnlySpan(span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.WriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            length = 0;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.WriteSized(span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(ref Span<byte> span) => SpanUtils.MoveReadSizedReadOnlySpan(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(ref Span<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(ref Span<byte> span, out ReadOnlySpan<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedReadOnlySpan(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(ref Span<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedReadOnlySpan(ref span, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(ref ReadOnlySpan<byte> span, out int length) {
            var size = (int)SpanUtils.ReadSize(span, out var prefix);
            var ret = span.Slice(prefix, size);
            length = prefix + size;
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(ref ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value, out int length) {
            value = default; length = 0;
            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;
            var size = SpanUtils.ReadSize(span, out var prefix);
            if (size > (UInt32)(span.Length - prefix)) return false;
            value = SpanUtils.MoveReadSizedReadOnlySpan(ref span, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(ref ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.MoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(ref Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            var prefix = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            if (span.Length < prefix || value.Length > span.Length - prefix)
                throw new ArgumentException("Data exceeds destination capacity.", nameof(span));
            // Copy first so that an overlapping source is preserved before writing the prefix.
            value.CopyTo(span.Slice(prefix));
            SpanUtils.WriteSize(span, (UInt32)value.Length);
            length = prefix + value.Length;
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, ReadOnlySpan<byte> value, out int length) {
            length = 0;
            var count = value.Length;
            if (count > 0x3FFFFFFF) return false;
            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);
            if (span.Length < required) return false;
            SpanUtils.MoveWriteSized(ref span, value, out length);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(Span<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSByteLE(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByteLE(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(Span<byte> span, out SByte value) => SpanUtils.TryReadSByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSByteLE(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByteLE(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, SByte value) {
            span[0] = (Byte)value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, SByte value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, SByte value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(ref Span<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByteLE(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(ref Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByteLE(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(ref ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByteLE(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(ref ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByteLE(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, SByte value) {
            span[0] = (Byte)value;

            span = span.Slice(sizeof(SByte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, SByte value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, SByte value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(Span<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadByteLE(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByteLE(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(Span<byte> span, out Byte value) => SpanUtils.TryReadByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(ReadOnlySpan<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadByteLE(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByteLE(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Byte value) {
            span[0] = value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Byte value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Byte value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(ref Span<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByteLE(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(ref Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByteLE(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(ref ReadOnlySpan<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByteLE(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(ref ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByteLE(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Byte value) {
            span[0] = value;

            span = span.Slice(sizeof(Byte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Byte value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Byte value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16LE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16LE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16LE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16LE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt16 value) {
            BinaryPrimitives.WriteUInt16LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt16 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt16 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16LE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16LE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16LE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16LE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt16 value) {
            BinaryPrimitives.WriteUInt16LittleEndian(span, value);

            span = span.Slice(sizeof(UInt16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt16 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16LE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16LE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16LE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16LE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int16 value) {
            BinaryPrimitives.WriteInt16LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int16 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int16 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16LE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16LE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16LE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16LE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int16 value) {
            BinaryPrimitives.WriteInt16LittleEndian(span, value);

            span = span.Slice(sizeof(Int16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int16 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32LE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32LE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32LE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32LE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt32 value) {
            BinaryPrimitives.WriteUInt32LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt32 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt32 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32LE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32LE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32LE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32LE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt32 value) {
            BinaryPrimitives.WriteUInt32LittleEndian(span, value);

            span = span.Slice(sizeof(UInt32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt32 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32LE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32LE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32LE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32LE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int32 value) {
            BinaryPrimitives.WriteInt32LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int32 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int32 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32LE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32LE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32LE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32LE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int32 value) {
            BinaryPrimitives.WriteInt32LittleEndian(span, value);

            span = span.Slice(sizeof(Int32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64LE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64LE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64LE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64LE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt64 value) {
            BinaryPrimitives.WriteUInt64LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt64 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt64 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64LE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64LE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64LE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64LE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt64 value) {
            BinaryPrimitives.WriteUInt64LittleEndian(span, value);

            span = span.Slice(sizeof(UInt64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt64 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64LE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64LE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64LE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64LE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int64 value) {
            BinaryPrimitives.WriteInt64LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int64 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int64 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64LE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64LE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64LE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64LE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int64 value) {
            BinaryPrimitives.WriteInt64LittleEndian(span, value);

            span = span.Slice(sizeof(Int64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int64 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSingleLE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingleLE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(Span<byte> span, out Single value) => SpanUtils.TryReadSingleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSingleLE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingleLE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Single value) {
            SpanUtils.WriteLE(span, BitConverter.SingleToInt32Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Single value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Single value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingleLE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingleLE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingleLE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingleLE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Single value) {
            SpanUtils.WriteLE(span, BitConverter.SingleToInt32Bits(value));

            span = span.Slice(sizeof(Single));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Single value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Single value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDoubleLE(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDoubleLE(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(Span<byte> span, out Double value) => SpanUtils.TryReadDoubleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDoubleLE(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDoubleLE(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDoubleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Double value) {
            SpanUtils.WriteLE(span, BitConverter.DoubleToInt64Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Double value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Double value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(ref Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64LE(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDoubleLE(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(ref Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDoubleLE(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64LE(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDoubleLE(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(ref ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDoubleLE(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Double value) {
            SpanUtils.WriteLE(span, BitConverter.DoubleToInt64Bits(value));

            span = span.Slice(sizeof(Double));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Double value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Double value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(Span<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, false);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimalLE(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, false)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimalLE(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimalLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, false);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimalLE(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, false)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimalLE(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimalLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Decimal value) {
            SpanUtils.WriteDecimalPortable(span, value, false);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Decimal value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Decimal value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(ref Span<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, false);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimalLE(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(ref Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, false)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimalLE(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(ref ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, false);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimalLE(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(ref ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, false)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimalLE(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Decimal value) {
            SpanUtils.WriteDecimalPortable(span, value, false);

            span = span.Slice(sizeof(Decimal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Decimal value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBooleanLE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBooleanLE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(Span<byte> span, out Boolean value) => SpanUtils.TryReadBooleanLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBooleanLE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBooleanLE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBooleanLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Boolean value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Boolean value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBooleanLE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBooleanLE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBooleanLE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBooleanLE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;

            span = span.Slice(sizeof(Boolean));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Boolean value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16LE(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadCharLE(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadCharLE(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(Span<byte> span, out Char value) => SpanUtils.TryReadCharLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16LE(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadCharLE(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadCharLE(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadCharLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Char value) {
            SpanUtils.WriteLE(span, (UInt16)value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Char value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Char value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(ref Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16LE(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadCharLE(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(ref Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadCharLE(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadCharLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(ref ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16LE(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadCharLE(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(ref ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadCharLE(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadCharLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Char value) {
            SpanUtils.WriteLE(span, (UInt16)value);

            span = span.Slice(sizeof(Char));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Char value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Char value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadFloatLE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloatLE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(Span<byte> span, out Single value) => SpanUtils.TryReadFloatLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadFloatLE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloatLE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloatLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloatLE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloatLE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32LE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloatLE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloatLE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadShortLE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShortLE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(Span<byte> span, out Int16 value) => SpanUtils.TryReadShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadShortLE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShortLE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShortLE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShortLE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16LittleEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShortLE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShortLE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUShortLE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShortLE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUShortLE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShortLE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShortLE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShortLE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16LittleEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShortLE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShortLE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadIntLE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadIntLE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(Span<byte> span, out Int32 value) => SpanUtils.TryReadIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadIntLE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadIntLE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadIntLE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadIntLE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32LittleEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadIntLE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadIntLE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUIntLE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUIntLE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUIntLE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUIntLE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUIntLE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUIntLE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32LittleEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUIntLE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUIntLE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadLongLE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLongLE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(Span<byte> span, out Int64 value) => SpanUtils.TryReadLongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadLongLE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLongLE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLongLE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLongLE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64LittleEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLongLE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLongLE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadULongLE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULongLE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(Span<byte> span, out UInt64 value) => SpanUtils.TryReadULongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadULongLE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULongLE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULongLE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULongLE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64LittleEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULongLE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULongLE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolLE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolLE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolLE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolLE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolLE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolLE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolLE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolLE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(Span<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24LE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24LE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(ReadOnlySpan<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24LE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24LE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)((UInt32)value >> 16); span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt24 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt24 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(ref Span<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24LE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(ref Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24LE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(ref ReadOnlySpan<byte> span) {
            var ret = (UInt24)((span[2] << 16) | (span[1] << 8) | span[0]);

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24LE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(ref ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24LE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)((UInt32)value >> 16); span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)value;

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt24 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24LE(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24LE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24LE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24LE(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24LE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24LE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24LE(Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.WriteLE(span, (UInt24)((UInt32)value & 0xFFFFFFU));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24LE(Span<byte> span, Int32 value, out int length) {
            SpanUtils.WriteInt24LE(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24LE(Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.WriteInt24LE(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24LE(Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24LE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(ref Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24LE(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24LE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24LE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(ref ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24LE(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24LE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24LE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24LE(ref Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.WriteLE(span, (UInt24)((UInt32)value & 0xFFFFFFU));

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24LE(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWriteInt24LE(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24LE(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.MoveWriteInt24LE(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24LE(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24LE(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadHalfLE(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalfLE(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(Span<byte> span, out Half value) => SpanUtils.TryReadHalfLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16LE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadHalfLE(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalfLE(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalfLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Half value) {
            SpanUtils.WriteLE(span, BitConverter.HalfToInt16Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Half value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Half value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(ref Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16LE(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalfLE(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(ref Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalfLE(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16LE(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalfLE(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(ref ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalfLE(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Half value) {
            SpanUtils.WriteLE(span, BitConverter.HalfToInt16Bits(value));

            span = span.Slice(2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Half value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Half value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt128LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128LE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128LE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt128LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128LE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128LE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int128 value) {
            BinaryPrimitives.WriteInt128LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Int128 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Int128 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt128LittleEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128LE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(ref Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128LE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt128LittleEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128LE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(ref ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128LE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int128 value) {
            BinaryPrimitives.WriteInt128LittleEndian(span, value);

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Int128 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128LE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128LE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128LittleEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128LE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128LE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt128 value) {
            BinaryPrimitives.WriteUInt128LittleEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, UInt128 value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, UInt128 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128LittleEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128LE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(ref Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128LE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128LittleEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128LE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(ref ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128LE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt128 value) {
            BinaryPrimitives.WriteUInt128LittleEndian(span, value);

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, UInt128 value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(Span<byte> span) {
            var ret = new Guid(span.Slice(0, 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadGuidLE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuidLE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(Span<byte> span, out Guid value) => SpanUtils.TryReadGuidLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(ReadOnlySpan<byte> span) {
            var ret = new Guid(span.Slice(0, 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadGuidLE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuidLE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuidLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Guid value) {
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException(nameof(span));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(Span<byte> span, Guid value, out int length) {
            SpanUtils.WriteLE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteLE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(Span<byte> span, Guid value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(ref Span<byte> span) {
            var ret = new Guid(span.Slice(0, 16));

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuidLE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(ref Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuidLE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(ref ReadOnlySpan<byte> span) {
            var ret = new Guid(span.Slice(0, 16));

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuidLE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(ref ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuidLE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Guid value) {
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException(nameof(span));

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(ref Span<byte> span, Guid value, out int length) {
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteLE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(ref Span<byte> span, Guid value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(Span<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSByteBE(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByteBE(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(Span<byte> span, out SByte value) => SpanUtils.TryReadSByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSByteBE(span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSByteBE(span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, SByte value) {
            span[0] = (Byte)value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, SByte value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, SByte value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(ref Span<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByteBE(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(ref Span<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByteBE(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(ref ReadOnlySpan<byte> span) {
            var ret = (SByte)span[0];

            span = span.Slice(sizeof(SByte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSByteBE(ref span);
            length = sizeof(SByte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(ref ReadOnlySpan<byte> span, out SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSByteBE(ref span);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, SByte value) {
            span[0] = (Byte)value;

            span = span.Slice(sizeof(SByte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, SByte value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(SByte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, SByte value, out int length) {
            if (span.Length < sizeof(SByte)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(SByte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, SByte value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(Span<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadByteBE(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByteBE(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(Span<byte> span, out Byte value) => SpanUtils.TryReadByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(ReadOnlySpan<byte> span) {
            var ret = span[0];


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadByteBE(span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadByteBE(span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Byte value) {
            span[0] = value;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Byte value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Byte value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(ref Span<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByteBE(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(ref Span<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByteBE(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(ref ReadOnlySpan<byte> span) {
            var ret = span[0];

            span = span.Slice(sizeof(Byte));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadByteBE(ref span);
            length = sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(ref ReadOnlySpan<byte> span, out Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadByteBE(ref span);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Byte value) {
            span[0] = value;

            span = span.Slice(sizeof(Byte));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Byte value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Byte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Byte value, out int length) {
            if (span.Length < sizeof(Byte)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Byte);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Byte value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16BE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16BE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt16BE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt16BE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt16 value) {
            BinaryPrimitives.WriteUInt16BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt16 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt16 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16BE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16BE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt16BE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt16BE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt16 value) {
            BinaryPrimitives.WriteUInt16BigEndian(span, value);

            span = span.Slice(sizeof(UInt16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt16 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16BE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16BE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt16BE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt16BE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int16 value) {
            BinaryPrimitives.WriteInt16BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int16 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int16 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16BE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16BE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt16BE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt16BE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int16 value) {
            BinaryPrimitives.WriteInt16BigEndian(span, value);

            span = span.Slice(sizeof(Int16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int16 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32BE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32BE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt32BE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt32BE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt32 value) {
            BinaryPrimitives.WriteUInt32BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt32 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt32 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32BE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32BE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt32BE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt32BE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt32 value) {
            BinaryPrimitives.WriteUInt32BigEndian(span, value);

            span = span.Slice(sizeof(UInt32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt32 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32BE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32BE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt32BE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt32BE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int32 value) {
            BinaryPrimitives.WriteInt32BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int32 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int32 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32BE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32BE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt32BE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt32BE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int32 value) {
            BinaryPrimitives.WriteInt32BigEndian(span, value);

            span = span.Slice(sizeof(Int32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64BE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64BE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt64BE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt64BE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt64 value) {
            BinaryPrimitives.WriteUInt64BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt64 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt64 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64BE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64BE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt64BE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt64BE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt64 value) {
            BinaryPrimitives.WriteUInt64BigEndian(span, value);

            span = span.Slice(sizeof(UInt64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt64 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64BE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64BE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt64BE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt64BE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int64 value) {
            BinaryPrimitives.WriteInt64BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int64 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int64 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64BE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64BE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt64BE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt64BE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int64 value) {
            BinaryPrimitives.WriteInt64BigEndian(span, value);

            span = span.Slice(sizeof(Int64));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int64 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int64);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadSingleBE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingleBE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(Span<byte> span, out Single value) => SpanUtils.TryReadSingleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadSingleBE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadSingleBE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Single value) {
            SpanUtils.WriteBE(span, BitConverter.SingleToInt32Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Single value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Single value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingleBE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingleBE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadSingleBE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadSingleBE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Single value) {
            SpanUtils.WriteBE(span, BitConverter.SingleToInt32Bits(value));

            span = span.Slice(sizeof(Single));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Single value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Single);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Single value, out int length) {
            if (span.Length < sizeof(Single)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Single value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDoubleBE(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDoubleBE(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(Span<byte> span, out Double value) => SpanUtils.TryReadDoubleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDoubleBE(span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDoubleBE(span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDoubleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Double value) {
            SpanUtils.WriteBE(span, BitConverter.DoubleToInt64Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Double value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Double value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(ref Span<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDoubleBE(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(ref Span<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDoubleBE(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span));

            span = span.Slice(sizeof(Double));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDoubleBE(ref span);
            length = sizeof(Double);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(ref ReadOnlySpan<byte> span, out Double value, out int length) {
            if (span.Length < sizeof(Double)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDoubleBE(ref span);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Double value) {
            SpanUtils.WriteBE(span, BitConverter.DoubleToInt64Bits(value));

            span = span.Slice(sizeof(Double));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Double value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Double);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Double value, out int length) {
            if (span.Length < sizeof(Double)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Double);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Double value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(Span<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, true);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimalBE(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, true)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimalBE(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimalBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, true);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadDecimalBE(span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, true)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadDecimalBE(span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimalBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Decimal value) {
            SpanUtils.WriteDecimalPortable(span, value, true);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Decimal value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Decimal value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(ref Span<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, true);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimalBE(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(ref Span<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, true)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimalBE(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(ref ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadDecimalPortable(span, true);

            span = span.Slice(sizeof(Decimal));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadDecimalBE(ref span);
            length = sizeof(Decimal);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(ref ReadOnlySpan<byte> span, out Decimal value, out int length) {
            if (span.Length < sizeof(Decimal) || !SpanUtils.IsValidDecimalEncoding(span, true)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadDecimalBE(ref span);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Decimal value) {
            SpanUtils.WriteDecimalPortable(span, value, true);

            span = span.Slice(sizeof(Decimal));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Decimal value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Decimal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Decimal value, out int length) {
            if (span.Length < sizeof(Decimal)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Decimal);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBooleanBE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBooleanBE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(Span<byte> span, out Boolean value) => SpanUtils.TryReadBooleanBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBooleanBE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBooleanBE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBooleanBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Boolean value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Boolean value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBooleanBE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBooleanBE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBooleanBE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBooleanBE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Boolean value) {
            span[0] = value ? (Byte)1 : (Byte)0;

            span = span.Slice(sizeof(Boolean));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Boolean value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Boolean);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16BE(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadCharBE(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadCharBE(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(Span<byte> span, out Char value) => SpanUtils.TryReadCharBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16BE(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadCharBE(span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadCharBE(span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadCharBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Char value) {
            SpanUtils.WriteBE(span, (UInt16)value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Char value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Char value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(ref Span<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16BE(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadCharBE(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(ref Span<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadCharBE(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadCharBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(ref ReadOnlySpan<byte> span) {
            var ret = (Char)SpanUtils.ReadUInt16BE(span);

            span = span.Slice(sizeof(Char));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadCharBE(ref span);
            length = sizeof(Char);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(ref ReadOnlySpan<byte> span, out Char value, out int length) {
            if (span.Length < sizeof(Char)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadCharBE(ref span);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadCharBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Char value) {
            SpanUtils.WriteBE(span, (UInt16)value);

            span = span.Slice(sizeof(Char));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Char value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Char);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Char value, out int length) {
            if (span.Length < sizeof(Char)) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = sizeof(Char);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Char value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadFloatBE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloatBE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(Span<byte> span, out Single value) => SpanUtils.TryReadFloatBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadFloatBE(span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadFloatBE(span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloatBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(ref Span<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloatBE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(ref Span<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloatBE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span));

            span = span.Slice(sizeof(Single));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadFloatBE(ref span);
            length = sizeof(Single);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(ref ReadOnlySpan<byte> span, out Single value, out int length) {
            if (span.Length < sizeof(Single)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadFloatBE(ref span);
            length = sizeof(Single);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadShortBE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShortBE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(Span<byte> span, out Int16 value) => SpanUtils.TryReadShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadShortBE(span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadShortBE(span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShortBE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(ref Span<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShortBE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt16BigEndian(span);

            span = span.Slice(sizeof(Int16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadShortBE(ref span);
            length = sizeof(Int16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(ref ReadOnlySpan<byte> span, out Int16 value, out int length) {
            if (span.Length < sizeof(Int16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadShortBE(ref span);
            length = sizeof(Int16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUShortBE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShortBE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUShortBE(span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUShortBE(span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShortBE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(ref Span<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShortBE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt16BigEndian(span);

            span = span.Slice(sizeof(UInt16));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUShortBE(ref span);
            length = sizeof(UInt16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(ref ReadOnlySpan<byte> span, out UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUShortBE(ref span);
            length = sizeof(UInt16);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadIntBE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadIntBE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(Span<byte> span, out Int32 value) => SpanUtils.TryReadIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadIntBE(span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadIntBE(span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadIntBE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadIntBE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt32BigEndian(span);

            span = span.Slice(sizeof(Int32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadIntBE(ref span);
            length = sizeof(Int32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < sizeof(Int32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadIntBE(ref span);
            length = sizeof(Int32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUIntBE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUIntBE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(Span<byte> span, out UInt32 value) => SpanUtils.TryReadUIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUIntBE(span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUIntBE(span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUIntBE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(ref Span<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUIntBE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt32BigEndian(span);

            span = span.Slice(sizeof(UInt32));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUIntBE(ref span);
            length = sizeof(UInt32);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(ref ReadOnlySpan<byte> span, out UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUIntBE(ref span);
            length = sizeof(UInt32);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadLongBE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLongBE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(Span<byte> span, out Int64 value) => SpanUtils.TryReadLongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadLongBE(span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadLongBE(span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLongBE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(ref Span<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLongBE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt64BigEndian(span);

            span = span.Slice(sizeof(Int64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadLongBE(ref span);
            length = sizeof(Int64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(ref ReadOnlySpan<byte> span, out Int64 value, out int length) {
            if (span.Length < sizeof(Int64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadLongBE(ref span);
            length = sizeof(Int64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadULongBE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULongBE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(Span<byte> span, out UInt64 value) => SpanUtils.TryReadULongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadULongBE(span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadULongBE(span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULongBE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(ref Span<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULongBE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt64BigEndian(span);

            span = span.Slice(sizeof(UInt64));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadULongBE(ref span);
            length = sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(ref ReadOnlySpan<byte> span, out UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadULongBE(ref span);
            length = sizeof(UInt64);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(Span<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolBE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolBE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadBoolBE(span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.ReadBoolBE(span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(ref Span<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolBE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(ref Span<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolBE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(ref ReadOnlySpan<byte> span) {
            var ret = span[0] != 0;

            span = span.Slice(sizeof(Boolean));
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadBoolBE(ref span);
            length = sizeof(Boolean);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(ref ReadOnlySpan<byte> span, out Boolean value, out int length) {
            if (span.Length < sizeof(Boolean)) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadBoolBE(ref span);
            length = sizeof(Boolean);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(Span<byte> span) {
            var ret = (UInt24)(span[2] | (span[1] << 8) | (span[0] << 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24BE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24BE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(ReadOnlySpan<byte> span) {
            var ret = (UInt24)(span[2] | (span[1] << 8) | (span[0] << 16));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt24BE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt24BE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)value; span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)((UInt32)value >> 16);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt24 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt24 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(ref Span<byte> span) {
            var ret = (UInt24)(span[2] | (span[1] << 8) | (span[0] << 16));

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24BE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(ref Span<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24BE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(ref ReadOnlySpan<byte> span) {
            var ret = (UInt24)(span[2] | (span[1] << 8) | (span[0] << 16));

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt24BE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(ref ReadOnlySpan<byte> span, out UInt24 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt24BE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt24 value) {

            if ((UInt32)value > 0xFFFFFFU)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (span.Length < 3)
                throw new ArgumentOutOfRangeException(nameof(span));
            span[2] = (Byte)value; span[1] = (Byte)((UInt32)value >> 8); span[0] = (Byte)((UInt32)value >> 16);

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt24 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt24 value, out int length) {
            if (span.Length < 3 || (UInt32)value > 0xFFFFFFU) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24BE(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24BE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24BE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24BE(span) << 8) >> 8;


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt24BE(span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt24BE(span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24BE(Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.WriteBE(span, (UInt24)((UInt32)value & 0xFFFFFFU));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24BE(Span<byte> span, Int32 value, out int length) {
            SpanUtils.WriteInt24BE(span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24BE(Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.WriteInt24BE(span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24BE(Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24BE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(ref Span<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24BE(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24BE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(ref Span<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24BE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(ref ReadOnlySpan<byte> span) {
            var ret = ((Int32)SpanUtils.ReadUInt24BE(span) << 8) >> 8;

            span = span.Slice(3);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt24BE(ref span);
            length = 3;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(ref ReadOnlySpan<byte> span, out Int32 value, out int length) {
            if (span.Length < 3) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt24BE(ref span);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24BE(ref Span<byte> span, Int32 value) {

            if (value < -8388608 || value > 8388607)
                throw new ArgumentOutOfRangeException(nameof(value));
            SpanUtils.WriteBE(span, (UInt24)((UInt32)value & 0xFFFFFFU));

            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24BE(ref Span<byte> span, Int32 value, out int length) {
            SpanUtils.MoveWriteInt24BE(ref span, value);
            length = 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24BE(ref Span<byte> span, Int32 value, out int length) {
            if (span.Length < 3 || value < -8388608 || value > 8388607) { length = 0; return false; }
            SpanUtils.MoveWriteInt24BE(ref span, value);
            length = 3;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24BE(ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24BE(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadHalfBE(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalfBE(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(Span<byte> span, out Half value) => SpanUtils.TryReadHalfBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16BE(span));


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadHalfBE(span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.ReadHalfBE(span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalfBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Half value) {
            SpanUtils.WriteBE(span, BitConverter.HalfToInt16Bits(value));


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Half value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Half value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(ref Span<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16BE(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalfBE(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(ref Span<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalfBE(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(ref ReadOnlySpan<byte> span) {
            var ret = BitConverter.Int16BitsToHalf(SpanUtils.ReadInt16BE(span));

            span = span.Slice(2);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadHalfBE(ref span);
            length = 2;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(ref ReadOnlySpan<byte> span, out Half value, out int length) {
            if (span.Length < 2) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadHalfBE(ref span);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Half value) {
            SpanUtils.WriteBE(span, BitConverter.HalfToInt16Bits(value));

            span = span.Slice(2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Half value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Half value, out int length) {
            if (span.Length < 2) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = 2;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Half value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt128BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128BE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128BE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt128BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadInt128BE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadInt128BE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int128 value) {
            BinaryPrimitives.WriteInt128BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Int128 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Int128 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadInt128BigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128BE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(ref Span<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128BE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadInt128BigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadInt128BE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(ref ReadOnlySpan<byte> span, out Int128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadInt128BE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int128 value) {
            BinaryPrimitives.WriteInt128BigEndian(span, value);

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Int128 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128BE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128BE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128BigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadUInt128BE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadUInt128BE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt128 value) {
            BinaryPrimitives.WriteUInt128BigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, UInt128 value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, UInt128 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(ref Span<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128BigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128BE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(ref Span<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128BE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(ref ReadOnlySpan<byte> span) {
            var ret = BinaryPrimitives.ReadUInt128BigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadUInt128BE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(ref ReadOnlySpan<byte> span, out UInt128 value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadUInt128BE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt128 value) {
            BinaryPrimitives.WriteUInt128BigEndian(span, value);

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, UInt128 value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt128 value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(Span<byte> span) {
            var ret = SpanUtils.ReadGuidBigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(Span<byte> span, out int length) {
            var ret = SpanUtils.ReadGuidBE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuidBE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(Span<byte> span, out Guid value) => SpanUtils.TryReadGuidBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadGuidBigEndian(span);


            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.ReadGuidBE(span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.ReadGuidBE(span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuidBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Guid value) {
            SpanUtils.WriteGuidBigEndian(span, value);


        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(Span<byte> span, Guid value, out int length) {
            SpanUtils.WriteBE(span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.WriteBE(span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(Span<byte> span, Guid value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(ref Span<byte> span) {
            var ret = SpanUtils.ReadGuidBigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(ref Span<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuidBE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(ref Span<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuidBE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(ref ReadOnlySpan<byte> span) {
            var ret = SpanUtils.ReadGuidBigEndian(span);

            span = span.Slice(16);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = SpanUtils.MoveReadGuidBE(ref span);
            length = 16;
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(ref ReadOnlySpan<byte> span, out Guid value, out int length) {
            if (span.Length < 16) { value = default; length = 0; return false; }
            value = SpanUtils.MoveReadGuidBE(ref span);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Guid value) {
            SpanUtils.WriteGuidBigEndian(span, value);

            span = span.Slice(16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(ref Span<byte> span, Guid value, out int length) {
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Guid value, out int length) {
            if (span.Length < 16) { length = 0; return false; }
            SpanUtils.MoveWriteBE(ref span, value);
            length = 16;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(ref Span<byte> span, Guid value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

    }

}
