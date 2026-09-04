// This file is auto-generated. Do not modify.

using System;
using System.Buffers.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
namespace Tedd {
    public static partial class SpanUtilsExtensionMethods {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(this ref Span<byte> span, int length) => SpanUtils.Move(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(this ref ReadOnlySpan<byte> span, int length) => SpanUtils.Move(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(this Span<byte> span) => SpanUtils.ReadSByte(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(this Span<byte> span, out int length) => SpanUtils.ReadSByte(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(this Span<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByte(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(this Span<byte> span, out SByte value) => SpanUtils.TryReadSByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(this ReadOnlySpan<byte> span) => SpanUtils.ReadSByte(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByte(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSByte(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(this ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByte(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByte(this ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, SByte value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, SByte value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, SByte value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, SByte value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(this ref Span<byte> span) => SpanUtils.MoveReadSByte(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSByte(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(this ref Span<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByte(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(this ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSByte(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByte(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSByte(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(this ref ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByte(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByte(this ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, SByte value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, SByte value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, SByte value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, SByte value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(this Span<byte> span) => SpanUtils.ReadByte(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(this Span<byte> span, out int length) => SpanUtils.ReadByte(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(this Span<byte> span, out Byte value, out int length) => SpanUtils.TryReadByte(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(this Span<byte> span, out Byte value) => SpanUtils.TryReadByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(this ReadOnlySpan<byte> span) => SpanUtils.ReadByte(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByte(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadByte(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(this ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryReadByte(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByte(this ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByte(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Byte value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Byte value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Byte value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Byte value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(this ref Span<byte> span) => SpanUtils.MoveReadByte(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(this ref Span<byte> span, out int length) => SpanUtils.MoveReadByte(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(this ref Span<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByte(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(this ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadByte(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByte(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadByte(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(this ref ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByte(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByte(this ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByte(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Byte value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Byte value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Byte value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Byte value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this Span<byte> span) => SpanUtils.ReadUInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this Span<byte> span, out int length) => SpanUtils.ReadUInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt16 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt16 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt16 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt16 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(this ref Span<byte> span) => SpanUtils.MoveReadUInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt16 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this Span<byte> span) => SpanUtils.ReadInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this Span<byte> span, out int length) => SpanUtils.ReadInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(this Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int16 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int16 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int16 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int16 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(this ref Span<byte> span) => SpanUtils.MoveReadInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int16 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this Span<byte> span) => SpanUtils.ReadUInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this Span<byte> span, out int length) => SpanUtils.ReadUInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt32 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt32 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt32 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt32 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(this ref Span<byte> span) => SpanUtils.MoveReadUInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt32 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this Span<byte> span) => SpanUtils.ReadInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this Span<byte> span, out int length) => SpanUtils.ReadInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int32 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int32 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int32 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(this ref Span<byte> span) => SpanUtils.MoveReadInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this Span<byte> span) => SpanUtils.ReadUInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this Span<byte> span, out int length) => SpanUtils.ReadUInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt64 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt64 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt64 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt64 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(this ref Span<byte> span) => SpanUtils.MoveReadUInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt64 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this Span<byte> span) => SpanUtils.ReadInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this Span<byte> span, out int length) => SpanUtils.ReadInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(this Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int64 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int64 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int64 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int64 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(this ref Span<byte> span) => SpanUtils.MoveReadInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int64 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(this Span<byte> span) => SpanUtils.ReadSingle(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(this Span<byte> span, out int length) => SpanUtils.ReadSingle(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadSingle(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(this Span<byte> span, out Single value) => SpanUtils.TryReadSingle(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(this ReadOnlySpan<byte> span) => SpanUtils.ReadSingle(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingle(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSingle(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadSingle(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingle(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingle(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Single value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Single value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Single value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Single value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(this ref Span<byte> span) => SpanUtils.MoveReadSingle(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSingle(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingle(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingle(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSingle(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingle(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSingle(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingle(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingle(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingle(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Single value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Single value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Single value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Single value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(this Span<byte> span) => SpanUtils.ReadDouble(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(this Span<byte> span, out int length) => SpanUtils.ReadDouble(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(this Span<byte> span, out Double value, out int length) => SpanUtils.TryReadDouble(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(this Span<byte> span, out Double value) => SpanUtils.TryReadDouble(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(this ReadOnlySpan<byte> span) => SpanUtils.ReadDouble(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDouble(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(this ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryReadDouble(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDouble(this ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDouble(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Double value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Double value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Double value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Double value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(this ref Span<byte> span) => SpanUtils.MoveReadDouble(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDouble(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(this ref Span<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDouble(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(this ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDouble(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDouble(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDouble(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDouble(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(this ref ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDouble(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDouble(this ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDouble(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Double value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Double value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Double value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Double value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(this Span<byte> span) => SpanUtils.ReadDecimal(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(this Span<byte> span, out int length) => SpanUtils.ReadDecimal(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(this Span<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimal(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(this Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimal(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(this ReadOnlySpan<byte> span) => SpanUtils.ReadDecimal(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimal(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDecimal(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(this ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimal(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimal(this ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimal(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Decimal value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Decimal value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Decimal value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Decimal value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(this ref Span<byte> span) => SpanUtils.MoveReadDecimal(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDecimal(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(this ref Span<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimal(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(this ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimal(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDecimal(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimal(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDecimal(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(this ref ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimal(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimal(this ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimal(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Decimal value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(this Span<byte> span) => SpanUtils.ReadBoolean(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(this Span<byte> span, out int length) => SpanUtils.ReadBoolean(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolean(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolean(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(this ReadOnlySpan<byte> span) => SpanUtils.ReadBoolean(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolean(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBoolean(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolean(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolean(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolean(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Boolean value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Boolean value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Boolean value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Boolean value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(this ref Span<byte> span) => SpanUtils.MoveReadBoolean(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBoolean(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolean(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolean(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBoolean(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolean(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBoolean(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolean(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolean(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolean(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Boolean value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(this Span<byte> span) => SpanUtils.ReadChar(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(this Span<byte> span, out int length) => SpanUtils.ReadChar(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(this Span<byte> span, out Char value, out int length) => SpanUtils.TryReadChar(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(this Span<byte> span, out Char value) => SpanUtils.TryReadChar(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(this ReadOnlySpan<byte> span) => SpanUtils.ReadChar(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadChar(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadChar(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(this ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryReadChar(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadChar(this ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadChar(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Char value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Char value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Char value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Char value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(this ref Span<byte> span) => SpanUtils.MoveReadChar(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(this ref Span<byte> span, out int length) => SpanUtils.MoveReadChar(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(this ref Span<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadChar(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(this ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadChar(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadChar(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadChar(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadChar(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(this ref ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadChar(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadChar(this ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadChar(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Char value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Char value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Char value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Char value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(this Span<byte> span) => SpanUtils.ReadFloat(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(this Span<byte> span, out int length) => SpanUtils.ReadFloat(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadFloat(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(this Span<byte> span, out Single value) => SpanUtils.TryReadFloat(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(this ReadOnlySpan<byte> span) => SpanUtils.ReadFloat(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadFloat(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadFloat(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloat(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloat(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(this ref Span<byte> span) => SpanUtils.MoveReadFloat(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(this ref Span<byte> span, out int length) => SpanUtils.MoveReadFloat(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloat(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloat(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadFloat(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloat(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadFloat(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloat(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloat(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloat(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(this Span<byte> span) => SpanUtils.ReadShort(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(this Span<byte> span, out int length) => SpanUtils.ReadShort(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShort(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(this Span<byte> span, out Int16 value) => SpanUtils.TryReadShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(this ReadOnlySpan<byte> span) => SpanUtils.ReadShort(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadShort(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShort(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShort(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(this ref Span<byte> span) => SpanUtils.MoveReadShort(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(this ref Span<byte> span, out int length) => SpanUtils.MoveReadShort(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShort(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadShort(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShort(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadShort(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShort(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShort(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(this Span<byte> span) => SpanUtils.ReadUShort(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(this Span<byte> span, out int length) => SpanUtils.ReadUShort(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShort(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(this ReadOnlySpan<byte> span) => SpanUtils.ReadUShort(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUShort(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShort(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShort(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShort(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(this ref Span<byte> span) => SpanUtils.MoveReadUShort(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUShort(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShort(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUShort(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShort(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUShort(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShort(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShort(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShort(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(this Span<byte> span) => SpanUtils.ReadInt(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(this Span<byte> span, out int length) => SpanUtils.ReadInt(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(this ref Span<byte> span) => SpanUtils.MoveReadInt(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(this Span<byte> span) => SpanUtils.ReadUInt(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(this Span<byte> span, out int length) => SpanUtils.ReadUInt(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(this ref Span<byte> span) => SpanUtils.MoveReadUInt(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(this Span<byte> span) => SpanUtils.ReadLong(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(this Span<byte> span, out int length) => SpanUtils.ReadLong(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLong(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(this Span<byte> span, out Int64 value) => SpanUtils.TryReadLong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(this ReadOnlySpan<byte> span) => SpanUtils.ReadLong(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadLong(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLong(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLong(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(this ref Span<byte> span) => SpanUtils.MoveReadLong(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(this ref Span<byte> span, out int length) => SpanUtils.MoveReadLong(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLong(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadLong(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLong(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadLong(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLong(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLong(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(this Span<byte> span) => SpanUtils.ReadULong(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(this Span<byte> span, out int length) => SpanUtils.ReadULong(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULong(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadULong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(this ReadOnlySpan<byte> span) => SpanUtils.ReadULong(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadULong(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULong(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULong(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULong(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(this ref Span<byte> span) => SpanUtils.MoveReadULong(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(this ref Span<byte> span, out int length) => SpanUtils.MoveReadULong(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULong(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadULong(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULong(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadULong(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULong(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULong(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULong(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(this Span<byte> span) => SpanUtils.ReadBool(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(this Span<byte> span, out int length) => SpanUtils.ReadBool(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBool(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBool(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(this ReadOnlySpan<byte> span) => SpanUtils.ReadBool(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBool(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBool(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBool(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBool(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBool(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(this ref Span<byte> span) => SpanUtils.MoveReadBool(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBool(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBool(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBool(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBool(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBool(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBool(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBool(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBool(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBool(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(this Span<byte> span) => SpanUtils.ReadUInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(this Span<byte> span, out int length) => SpanUtils.ReadUInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(this Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(this Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(this ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24(this ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt24 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt24 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt24 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt24 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(this ref Span<byte> span) => SpanUtils.MoveReadUInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(this ref Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(this ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(this ref ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24(this ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt24 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(this Span<byte> span) => SpanUtils.ReadInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(this Span<byte> span, out int length) => SpanUtils.ReadInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24(this Span<byte> span, Int32 value) => SpanUtils.WriteInt24(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteInt24(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteInt24(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24(this Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(this ref Span<byte> span) => SpanUtils.MoveReadInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteInt24(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteInt24(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteInt24(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(this Span<byte> span) => SpanUtils.ReadHalf(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(this Span<byte> span, out int length) => SpanUtils.ReadHalf(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(this Span<byte> span, out Half value, out int length) => SpanUtils.TryReadHalf(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(this Span<byte> span, out Half value) => SpanUtils.TryReadHalf(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(this ReadOnlySpan<byte> span) => SpanUtils.ReadHalf(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalf(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadHalf(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(this ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryReadHalf(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalf(this ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalf(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Half value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Half value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Half value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Half value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(this ref Span<byte> span) => SpanUtils.MoveReadHalf(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(this ref Span<byte> span, out int length) => SpanUtils.MoveReadHalf(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(this ref Span<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalf(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(this ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalf(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadHalf(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalf(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadHalf(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(this ref ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalf(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalf(this ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalf(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Half value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Half value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Half value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Half value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(this Span<byte> span) => SpanUtils.ReadInt128(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(this Span<byte> span, out int length) => SpanUtils.ReadInt128(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(this Span<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(this Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt128(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt128(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(this ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128(this ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int128 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Int128 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int128 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Int128 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(this ref Span<byte> span) => SpanUtils.MoveReadInt128(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt128(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(this ref Span<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(this ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt128(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt128(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(this ref ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128(this ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int128 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(this Span<byte> span) => SpanUtils.ReadUInt128(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(this Span<byte> span, out int length) => SpanUtils.ReadUInt128(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(this Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(this Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt128(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt128(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(this ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128(this ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt128 value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, UInt128 value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt128 value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, UInt128 value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(this ref Span<byte> span) => SpanUtils.MoveReadUInt128(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt128(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(this ref Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(this ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt128(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt128(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(this ref ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128(this ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt128 value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWrite(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(this Span<byte> span) => SpanUtils.ReadGuid(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(this Span<byte> span, out int length) => SpanUtils.ReadGuid(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(this Span<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuid(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(this Span<byte> span, out Guid value) => SpanUtils.TryReadGuid(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(this ReadOnlySpan<byte> span) => SpanUtils.ReadGuid(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadGuid(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(this ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuid(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuid(this ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuid(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Guid value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Guid value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Guid value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Guid value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(this ref Span<byte> span) => SpanUtils.MoveReadGuid(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(this ref Span<byte> span, out int length) => SpanUtils.MoveReadGuid(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(this ref Span<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuid(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(this ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuid(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadGuid(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadGuid(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(this ref ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuid(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuid(this ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuid(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Guid value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Guid value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Guid value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Guid value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(this Span<byte> span) => SpanUtils.ReadVLQUInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(this Span<byte> span, out int length) => SpanUtils.ReadVLQUInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadVLQUInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadVLQUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadVLQUInt16(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQUInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadVLQUInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt16(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadVLQUInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt16 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt16 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt16 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt16 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(this ref Span<byte> span) => SpanUtils.MoveReadVLQUInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQUInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQUInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt16(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadVLQUInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt16 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(this Span<byte> span) => SpanUtils.ReadVLQInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(this Span<byte> span, out int length) => SpanUtils.ReadVLQInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadVLQInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(this Span<byte> span, out Int16 value) => SpanUtils.TryReadVLQInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt16(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQInt16(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadVLQInt16(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt16(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadVLQInt16(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int16 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int16 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int16 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int16 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(this ref Span<byte> span) => SpanUtils.MoveReadVLQInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt16(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQInt16(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt16(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadVLQInt16(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int16 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(this Span<byte> span) => SpanUtils.ReadVLQUInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(this Span<byte> span, out int length) => SpanUtils.ReadVLQUInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadVLQUInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadVLQUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadVLQUInt32(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQUInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadVLQUInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt32(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadVLQUInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt32 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt32 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt32 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt32 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(this ref Span<byte> span) => SpanUtils.MoveReadVLQUInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQUInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQUInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt32(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadVLQUInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(this Span<byte> span) => SpanUtils.ReadVLQInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(this Span<byte> span, out int length) => SpanUtils.ReadVLQInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadVLQInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(this Span<byte> span, out Int32 value) => SpanUtils.TryReadVLQInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt32(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQInt32(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadVLQInt32(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt32(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadVLQInt32(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int32 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int32 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(this ref Span<byte> span) => SpanUtils.MoveReadVLQInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt32(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQInt32(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt32(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadVLQInt32(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(this Span<byte> span) => SpanUtils.ReadVLQUInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(this Span<byte> span, out int length) => SpanUtils.ReadVLQUInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadVLQUInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadVLQUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadVLQUInt64(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQUInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadVLQUInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt64(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadVLQUInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt64 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt64 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt64 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt64 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(this ref Span<byte> span) => SpanUtils.MoveReadVLQUInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQUInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQUInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt64(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadVLQUInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt64 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(this Span<byte> span) => SpanUtils.ReadVLQInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(this Span<byte> span, out int length) => SpanUtils.ReadVLQInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadVLQInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(this Span<byte> span, out Int64 value) => SpanUtils.TryReadVLQInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQInt64(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQInt64(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadVLQInt64(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQInt64(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadVLQInt64(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int64 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, Int64 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int64 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, Int64 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(this ref Span<byte> span) => SpanUtils.MoveReadVLQInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQInt64(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQInt64(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQInt64(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadVLQInt64(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int64 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(this Span<byte> span) => SpanUtils.ReadVLQUInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(this Span<byte> span, out int length) => SpanUtils.ReadVLQUInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(this Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadVLQUInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(this Span<byte> span, out UInt24 value) => SpanUtils.TryReadVLQUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(this ReadOnlySpan<byte> span) => SpanUtils.ReadVLQUInt24(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadVLQUInt24(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadVLQUInt24(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(this ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadVLQUInt24(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadVLQUInt24(this ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadVLQUInt24(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt24 value) => SpanUtils.WriteVLQ(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteVLQ(this Span<byte> span, UInt24 value, out int length) => SpanUtils.WriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt24 value, out int length) => SpanUtils.TryWriteVLQ(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteVLQ(this Span<byte> span, UInt24 value) => SpanUtils.TryWriteVLQ(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(this ref Span<byte> span) => SpanUtils.MoveReadVLQUInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(this ref Span<byte> span, out int length) => SpanUtils.MoveReadVLQUInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(this ref Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(this ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadVLQUInt24(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadVLQUInt24(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(this ref ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadVLQUInt24(this ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadVLQUInt24(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt24 value) => SpanUtils.MoveWriteVLQ(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteVLQ(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.MoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.TryMoveWriteVLQ(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteVLQ(this ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteVLQ(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(this Span<byte> span, int length) => SpanUtils.ReadBytes(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBytes(this Span<byte> span, int length, out Byte[] value) => SpanUtils.TryReadBytes(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(this ReadOnlySpan<byte> span, int length) => SpanUtils.ReadBytes(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBytes(this ReadOnlySpan<byte> span, int length, out Byte[] value) => SpanUtils.TryReadBytes(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Byte[] value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Byte[] value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Byte[] value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Byte[] value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadBytes(this ref Span<byte> span, int length) => SpanUtils.MoveReadBytes(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBytes(this ref Span<byte> span, int length, out Byte[] value) => SpanUtils.TryMoveReadBytes(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadBytes(this ref ReadOnlySpan<byte> span, int length) => SpanUtils.MoveReadBytes(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBytes(this ref ReadOnlySpan<byte> span, int length, out Byte[] value) => SpanUtils.TryMoveReadBytes(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Byte[] value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Byte[] value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Byte[] value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Byte[] value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSpan(this Span<byte> span, int length) => SpanUtils.ReadSpan(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSpan(this Span<byte> span, int length, out Span<byte> value) => SpanUtils.TryReadSpan(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Span<byte> value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, Span<byte> value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Span<byte> value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, Span<byte> value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSpan(this ref Span<byte> span, int length) => SpanUtils.MoveReadSpan(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSpan(this ref Span<byte> span, int length, out Span<byte> value) => SpanUtils.TryMoveReadSpan(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Span<byte> value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, Span<byte> value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Span<byte> value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, Span<byte> value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadReadOnlySpan(this Span<byte> span, int length) => SpanUtils.ReadReadOnlySpan(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadReadOnlySpan(this Span<byte> span, int length, out ReadOnlySpan<byte> value) => SpanUtils.TryReadReadOnlySpan(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadReadOnlySpan(this ReadOnlySpan<byte> span, int length) => SpanUtils.ReadReadOnlySpan(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadReadOnlySpan(this ReadOnlySpan<byte> span, int length, out ReadOnlySpan<byte> value) => SpanUtils.TryReadReadOnlySpan(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.Write(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(this Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.Write(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.TryWrite(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWrite(this Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryWrite(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadReadOnlySpan(this ref Span<byte> span, int length) => SpanUtils.MoveReadReadOnlySpan(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadReadOnlySpan(this ref Span<byte> span, int length, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadReadOnlySpan(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadReadOnlySpan(this ref ReadOnlySpan<byte> span, int length) => SpanUtils.MoveReadReadOnlySpan(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadReadOnlySpan(this ref ReadOnlySpan<byte> span, int length, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadReadOnlySpan(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.MoveWrite(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(this ref Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.MoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.TryMoveWrite(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWrite(this ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryMoveWrite(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(this Span<byte> span, int length) => SpanUtils.ReadString(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadString(this Span<byte> span, int length, out String value) => SpanUtils.TryReadString(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(this ReadOnlySpan<byte> span, int length) => SpanUtils.ReadString(span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadString(this ReadOnlySpan<byte> span, int length, out String value) => SpanUtils.TryReadString(span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteString(this Span<byte> span, String value) => SpanUtils.WriteString(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteString(this Span<byte> span, String value, out int length) => SpanUtils.WriteString(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteString(this Span<byte> span, String value, out int length) => SpanUtils.TryWriteString(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteString(this Span<byte> span, String value) => SpanUtils.TryWriteString(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadString(this ref Span<byte> span, int length) => SpanUtils.MoveReadString(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadString(this ref Span<byte> span, int length, out String value) => SpanUtils.TryMoveReadString(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadString(this ref ReadOnlySpan<byte> span, int length) => SpanUtils.MoveReadString(ref span, length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadString(this ref ReadOnlySpan<byte> span, int length, out String value) => SpanUtils.TryMoveReadString(ref span, length, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteString(this ref Span<byte> span, String value) => SpanUtils.MoveWriteString(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteString(this ref Span<byte> span, String value, out int length) => SpanUtils.MoveWriteString(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteString(this ref Span<byte> span, String value, out int length) => SpanUtils.TryMoveWriteString(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteString(this ref Span<byte> span, String value) => SpanUtils.TryMoveWriteString(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(this Span<byte> span) => SpanUtils.ReadSize(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(this Span<byte> span, out int length) => SpanUtils.ReadSize(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadSize(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadSize(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(this ReadOnlySpan<byte> span) => SpanUtils.ReadSize(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSize(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadSize(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSize(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadSize(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSize(this Span<byte> span, UInt32 value) => SpanUtils.WriteSize(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSize(this Span<byte> span, UInt32 value, out int length) => SpanUtils.WriteSize(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSize(this Span<byte> span, UInt32 value, out int length) => SpanUtils.TryWriteSize(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSize(this Span<byte> span, UInt32 value) => SpanUtils.TryWriteSize(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(this ref Span<byte> span) => SpanUtils.MoveReadSize(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSize(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadSize(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadSize(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSize(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSize(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadSize(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSize(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadSize(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSize(this ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteSize(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSize(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.MoveWriteSize(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSize(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.TryMoveWriteSize(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSize(this ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteSize(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(this Span<byte> span) => SpanUtils.ReadSizedBytes(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(this Span<byte> span, out int length) => SpanUtils.ReadSizedBytes(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(this Span<byte> span, out Byte[] value, out int length) => SpanUtils.TryReadSizedBytes(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(this Span<byte> span, out Byte[] value) => SpanUtils.TryReadSizedBytes(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(this ReadOnlySpan<byte> span) => SpanUtils.ReadSizedBytes(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadSizedBytes(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSizedBytes(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(this ReadOnlySpan<byte> span, out Byte[] value, out int length) => SpanUtils.TryReadSizedBytes(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedBytes(this ReadOnlySpan<byte> span, out Byte[] value) => SpanUtils.TryReadSizedBytes(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, Byte[] value) => SpanUtils.WriteSized(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, Byte[] value, out int length) => SpanUtils.WriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, Byte[] value, out int length) => SpanUtils.TryWriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, Byte[] value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(this ref Span<byte> span) => SpanUtils.MoveReadSizedBytes(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSizedBytes(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(this ref Span<byte> span, out Byte[] value, out int length) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(this ref Span<byte> span, out Byte[] value) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedBytes(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] MoveReadSizedBytes(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSizedBytes(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(this ref ReadOnlySpan<byte> span, out Byte[] value, out int length) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedBytes(this ref ReadOnlySpan<byte> span, out Byte[] value) => SpanUtils.TryMoveReadSizedBytes(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, Byte[] value) => SpanUtils.MoveWriteSized(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, Byte[] value, out int length) => SpanUtils.MoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, Byte[] value, out int length) => SpanUtils.TryMoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, Byte[] value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(this Span<byte> span) => SpanUtils.ReadSizedString(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(this Span<byte> span, out int length) => SpanUtils.ReadSizedString(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(this Span<byte> span, out String value, out int length) => SpanUtils.TryReadSizedString(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(this Span<byte> span, out String value) => SpanUtils.TryReadSizedString(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(this ReadOnlySpan<byte> span) => SpanUtils.ReadSizedString(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadSizedString(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSizedString(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(this ReadOnlySpan<byte> span, out String value, out int length) => SpanUtils.TryReadSizedString(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedString(this ReadOnlySpan<byte> span, out String value) => SpanUtils.TryReadSizedString(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, String value) => SpanUtils.WriteSized(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, String value, out int length) => SpanUtils.WriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, String value, out int length) => SpanUtils.TryWriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, String value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(this ref Span<byte> span) => SpanUtils.MoveReadSizedString(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSizedString(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(this ref Span<byte> span, out String value, out int length) => SpanUtils.TryMoveReadSizedString(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(this ref Span<byte> span, out String value) => SpanUtils.TryMoveReadSizedString(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedString(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String MoveReadSizedString(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSizedString(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(this ref ReadOnlySpan<byte> span, out String value, out int length) => SpanUtils.TryMoveReadSizedString(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedString(this ref ReadOnlySpan<byte> span, out String value) => SpanUtils.TryMoveReadSizedString(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, String value) => SpanUtils.MoveWriteSized(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, String value, out int length) => SpanUtils.MoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, String value, out int length) => SpanUtils.TryMoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, String value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSizedSpan(this Span<byte> span) => SpanUtils.ReadSizedSpan(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> ReadSizedSpan(this Span<byte> span, out int length) => SpanUtils.ReadSizedSpan(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedSpan(this Span<byte> span, out Span<byte> value, out int length) => SpanUtils.TryReadSizedSpan(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedSpan(this Span<byte> span, out Span<byte> value) => SpanUtils.TryReadSizedSpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, Span<byte> value) => SpanUtils.WriteSized(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, Span<byte> value, out int length) => SpanUtils.WriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, Span<byte> value, out int length) => SpanUtils.TryWriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, Span<byte> value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSizedSpan(this ref Span<byte> span) => SpanUtils.MoveReadSizedSpan(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Span<byte> MoveReadSizedSpan(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSizedSpan(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedSpan(this ref Span<byte> span, out Span<byte> value, out int length) => SpanUtils.TryMoveReadSizedSpan(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedSpan(this ref Span<byte> span, out Span<byte> value) => SpanUtils.TryMoveReadSizedSpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, Span<byte> value) => SpanUtils.MoveWriteSized(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, Span<byte> value, out int length) => SpanUtils.MoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, Span<byte> value, out int length) => SpanUtils.TryMoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, Span<byte> value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(this Span<byte> span) => SpanUtils.ReadSizedReadOnlySpan(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(this Span<byte> span, out int length) => SpanUtils.ReadSizedReadOnlySpan(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(this Span<byte> span, out ReadOnlySpan<byte> value, out int length) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(this Span<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(this ReadOnlySpan<byte> span) => SpanUtils.ReadSizedReadOnlySpan(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> ReadSizedReadOnlySpan(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSizedReadOnlySpan(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(this ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value, out int length) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSizedReadOnlySpan(this ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryReadSizedReadOnlySpan(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.WriteSized(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSized(this Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.WriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.TryWriteSized(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteSized(this Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryWriteSized(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(this ref Span<byte> span) => SpanUtils.MoveReadSizedReadOnlySpan(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSizedReadOnlySpan(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(this ref Span<byte> span, out ReadOnlySpan<byte> value, out int length) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(this ref Span<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSizedReadOnlySpan(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadOnlySpan<byte> MoveReadSizedReadOnlySpan(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSizedReadOnlySpan(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(this ref ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value, out int length) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSizedReadOnlySpan(this ref ReadOnlySpan<byte> span, out ReadOnlySpan<byte> value) => SpanUtils.TryMoveReadSizedReadOnlySpan(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.MoveWriteSized(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteSized(this ref Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.MoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, ReadOnlySpan<byte> value, out int length) => SpanUtils.TryMoveWriteSized(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteSized(this ref Span<byte> span, ReadOnlySpan<byte> value) => SpanUtils.TryMoveWriteSized(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(this Span<byte> span) => SpanUtils.ReadSByteLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(this Span<byte> span, out int length) => SpanUtils.ReadSByteLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(this Span<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByteLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(this Span<byte> span, out SByte value) => SpanUtils.TryReadSByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadSByteLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSByteLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(this ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByteLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteLE(this ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, SByte value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, SByte value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, SByte value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, SByte value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(this ref Span<byte> span) => SpanUtils.MoveReadSByteLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSByteLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(this ref Span<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(this ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSByteLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSByteLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(this ref ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteLE(this ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, SByte value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, SByte value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, SByte value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, SByte value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(this Span<byte> span) => SpanUtils.ReadByteLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(this Span<byte> span, out int length) => SpanUtils.ReadByteLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(this Span<byte> span, out Byte value, out int length) => SpanUtils.TryReadByteLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(this Span<byte> span, out Byte value) => SpanUtils.TryReadByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadByteLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadByteLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(this ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryReadByteLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteLE(this ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByteLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Byte value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Byte value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Byte value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Byte value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(this ref Span<byte> span) => SpanUtils.MoveReadByteLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadByteLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(this ref Span<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByteLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(this ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadByteLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadByteLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(this ref ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByteLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteLE(this ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByteLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Byte value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Byte value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Byte value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Byte value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(this Span<byte> span) => SpanUtils.ReadUInt16LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(this Span<byte> span, out int length) => SpanUtils.ReadUInt16LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt16LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt16LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16LE(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt16 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt16 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt16 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt16 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(this ref Span<byte> span) => SpanUtils.MoveReadUInt16LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt16LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt16LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt16LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16LE(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt16 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(this Span<byte> span) => SpanUtils.ReadInt16LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(this Span<byte> span, out int length) => SpanUtils.ReadInt16LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(this Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt16LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt16LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16LE(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int16 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int16 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int16 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int16 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(this ref Span<byte> span) => SpanUtils.MoveReadInt16LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt16LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt16LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt16LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16LE(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int16 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(this Span<byte> span) => SpanUtils.ReadUInt32LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(this Span<byte> span, out int length) => SpanUtils.ReadUInt32LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt32LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt32LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32LE(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt32 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt32 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt32 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt32 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(this ref Span<byte> span) => SpanUtils.MoveReadUInt32LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt32LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt32LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt32LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32LE(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(this Span<byte> span) => SpanUtils.ReadInt32LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(this Span<byte> span, out int length) => SpanUtils.ReadInt32LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt32LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt32LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32LE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int32 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int32 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(this ref Span<byte> span) => SpanUtils.MoveReadInt32LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt32LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt32LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt32LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32LE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(this Span<byte> span) => SpanUtils.ReadUInt64LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(this Span<byte> span, out int length) => SpanUtils.ReadUInt64LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt64LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt64LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64LE(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt64 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt64 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt64 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt64 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(this ref Span<byte> span) => SpanUtils.MoveReadUInt64LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt64LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt64LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt64LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64LE(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt64 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(this Span<byte> span) => SpanUtils.ReadInt64LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(this Span<byte> span, out int length) => SpanUtils.ReadInt64LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(this Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt64LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt64LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64LE(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int64 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int64 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int64 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int64 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(this ref Span<byte> span) => SpanUtils.MoveReadInt64LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt64LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt64LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt64LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64LE(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int64 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(this Span<byte> span) => SpanUtils.ReadSingleLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(this Span<byte> span, out int length) => SpanUtils.ReadSingleLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadSingleLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(this Span<byte> span, out Single value) => SpanUtils.TryReadSingleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadSingleLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSingleLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadSingleLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleLE(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Single value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Single value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Single value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Single value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(this ref Span<byte> span) => SpanUtils.MoveReadSingleLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSingleLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSingleLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSingleLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleLE(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Single value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Single value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Single value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Single value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(this Span<byte> span) => SpanUtils.ReadDoubleLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(this Span<byte> span, out int length) => SpanUtils.ReadDoubleLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(this Span<byte> span, out Double value, out int length) => SpanUtils.TryReadDoubleLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(this Span<byte> span, out Double value) => SpanUtils.TryReadDoubleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadDoubleLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDoubleLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(this ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryReadDoubleLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleLE(this ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDoubleLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Double value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Double value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Double value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Double value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(this ref Span<byte> span) => SpanUtils.MoveReadDoubleLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDoubleLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(this ref Span<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(this ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDoubleLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDoubleLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(this ref ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleLE(this ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Double value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Double value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Double value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Double value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(this Span<byte> span) => SpanUtils.ReadDecimalLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(this Span<byte> span, out int length) => SpanUtils.ReadDecimalLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(this Span<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimalLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(this Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimalLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadDecimalLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDecimalLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(this ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimalLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalLE(this ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimalLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Decimal value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Decimal value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Decimal value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Decimal value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(this ref Span<byte> span) => SpanUtils.MoveReadDecimalLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDecimalLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(this ref Span<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(this ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDecimalLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDecimalLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(this ref ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalLE(this ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Decimal value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(this Span<byte> span) => SpanUtils.ReadBooleanLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(this Span<byte> span, out int length) => SpanUtils.ReadBooleanLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBooleanLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBooleanLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadBooleanLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBooleanLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBooleanLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanLE(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBooleanLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Boolean value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Boolean value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Boolean value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Boolean value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(this ref Span<byte> span) => SpanUtils.MoveReadBooleanLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBooleanLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBooleanLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBooleanLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanLE(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Boolean value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(this Span<byte> span) => SpanUtils.ReadCharLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(this Span<byte> span, out int length) => SpanUtils.ReadCharLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(this Span<byte> span, out Char value, out int length) => SpanUtils.TryReadCharLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(this Span<byte> span, out Char value) => SpanUtils.TryReadCharLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadCharLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadCharLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(this ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryReadCharLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharLE(this ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadCharLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Char value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Char value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Char value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Char value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(this ref Span<byte> span) => SpanUtils.MoveReadCharLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadCharLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(this ref Span<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadCharLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(this ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadCharLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadCharLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadCharLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(this ref ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadCharLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharLE(this ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadCharLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Char value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Char value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Char value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Char value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(this Span<byte> span) => SpanUtils.ReadFloatLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(this Span<byte> span, out int length) => SpanUtils.ReadFloatLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadFloatLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(this Span<byte> span, out Single value) => SpanUtils.TryReadFloatLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadFloatLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadFloatLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadFloatLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatLE(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloatLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(this ref Span<byte> span) => SpanUtils.MoveReadFloatLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadFloatLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadFloatLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadFloatLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatLE(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloatLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(this Span<byte> span) => SpanUtils.ReadShortLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(this Span<byte> span, out int length) => SpanUtils.ReadShortLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShortLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(this Span<byte> span, out Int16 value) => SpanUtils.TryReadShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadShortLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadShortLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShortLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortLE(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(this ref Span<byte> span) => SpanUtils.MoveReadShortLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadShortLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShortLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadShortLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadShortLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShortLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortLE(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(this Span<byte> span) => SpanUtils.ReadUShortLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(this Span<byte> span, out int length) => SpanUtils.ReadUShortLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShortLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUShortLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUShortLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShortLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortLE(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShortLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(this ref Span<byte> span) => SpanUtils.MoveReadUShortLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUShortLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUShortLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUShortLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortLE(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(this Span<byte> span) => SpanUtils.ReadIntLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(this Span<byte> span, out int length) => SpanUtils.ReadIntLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadIntLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadIntLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadIntLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadIntLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntLE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(this ref Span<byte> span) => SpanUtils.MoveReadIntLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadIntLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadIntLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadIntLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadIntLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadIntLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntLE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(this Span<byte> span) => SpanUtils.ReadUIntLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(this Span<byte> span, out int length) => SpanUtils.ReadUIntLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUIntLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUIntLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUIntLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUIntLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntLE(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUIntLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(this ref Span<byte> span) => SpanUtils.MoveReadUIntLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUIntLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUIntLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUIntLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntLE(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(this Span<byte> span) => SpanUtils.ReadLongLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(this Span<byte> span, out int length) => SpanUtils.ReadLongLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLongLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(this Span<byte> span, out Int64 value) => SpanUtils.TryReadLongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadLongLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadLongLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLongLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongLE(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(this ref Span<byte> span) => SpanUtils.MoveReadLongLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadLongLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLongLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadLongLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadLongLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLongLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongLE(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(this Span<byte> span) => SpanUtils.ReadULongLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(this Span<byte> span, out int length) => SpanUtils.ReadULongLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULongLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadULongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadULongLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadULongLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULongLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongLE(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULongLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(this ref Span<byte> span) => SpanUtils.MoveReadULongLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadULongLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULongLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadULongLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadULongLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULongLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongLE(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(this Span<byte> span) => SpanUtils.ReadBoolLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(this Span<byte> span, out int length) => SpanUtils.ReadBoolLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadBoolLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBoolLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolLE(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(this ref Span<byte> span) => SpanUtils.MoveReadBoolLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBoolLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBoolLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBoolLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolLE(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(this Span<byte> span) => SpanUtils.ReadUInt24LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(this Span<byte> span, out int length) => SpanUtils.ReadUInt24LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(this Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(this Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt24LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt24LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(this ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24LE(this ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt24 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt24 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt24 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt24 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(this ref Span<byte> span) => SpanUtils.MoveReadUInt24LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt24LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(this ref Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(this ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt24LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt24LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(this ref ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24LE(this ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt24 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(this Span<byte> span) => SpanUtils.ReadInt24LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(this Span<byte> span, out int length) => SpanUtils.ReadInt24LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt24LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt24LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24LE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24LE(this Span<byte> span, Int32 value) => SpanUtils.WriteInt24LE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24LE(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteInt24LE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24LE(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteInt24LE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24LE(this Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24LE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(this ref Span<byte> span) => SpanUtils.MoveReadInt24LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt24LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt24LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt24LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24LE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24LE(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteInt24LE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24LE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteInt24LE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24LE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteInt24LE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24LE(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24LE(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(this Span<byte> span) => SpanUtils.ReadHalfLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(this Span<byte> span, out int length) => SpanUtils.ReadHalfLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(this Span<byte> span, out Half value, out int length) => SpanUtils.TryReadHalfLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(this Span<byte> span, out Half value) => SpanUtils.TryReadHalfLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadHalfLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadHalfLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(this ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryReadHalfLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfLE(this ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalfLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Half value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Half value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Half value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Half value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(this ref Span<byte> span) => SpanUtils.MoveReadHalfLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadHalfLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(this ref Span<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(this ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadHalfLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadHalfLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(this ref ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfLE(this ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalfLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Half value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Half value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Half value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Half value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(this Span<byte> span) => SpanUtils.ReadInt128LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(this Span<byte> span, out int length) => SpanUtils.ReadInt128LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(this Span<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(this Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt128LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt128LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(this ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128LE(this ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int128 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Int128 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int128 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Int128 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(this ref Span<byte> span) => SpanUtils.MoveReadInt128LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt128LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(this ref Span<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(this ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt128LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt128LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(this ref ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128LE(this ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int128 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(this Span<byte> span) => SpanUtils.ReadUInt128LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(this Span<byte> span, out int length) => SpanUtils.ReadUInt128LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(this Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(this Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt128LE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128LE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt128LE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(this ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128LE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128LE(this ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128LE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt128 value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, UInt128 value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt128 value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, UInt128 value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(this ref Span<byte> span) => SpanUtils.MoveReadUInt128LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt128LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(this ref Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(this ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt128LE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128LE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt128LE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(this ref ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128LE(this ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128LE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt128 value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(this Span<byte> span) => SpanUtils.ReadGuidLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(this Span<byte> span, out int length) => SpanUtils.ReadGuidLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(this Span<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuidLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(this Span<byte> span, out Guid value) => SpanUtils.TryReadGuidLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(this ReadOnlySpan<byte> span) => SpanUtils.ReadGuidLE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidLE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadGuidLE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(this ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuidLE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidLE(this ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuidLE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Guid value) => SpanUtils.WriteLE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLE(this Span<byte> span, Guid value, out int length) => SpanUtils.WriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Guid value, out int length) => SpanUtils.TryWriteLE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteLE(this Span<byte> span, Guid value) => SpanUtils.TryWriteLE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(this ref Span<byte> span) => SpanUtils.MoveReadGuidLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadGuidLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(this ref Span<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(this ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadGuidLE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidLE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadGuidLE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(this ref ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidLE(this ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidLE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Guid value) => SpanUtils.MoveWriteLE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteLE(this ref Span<byte> span, Guid value, out int length) => SpanUtils.MoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Guid value, out int length) => SpanUtils.TryMoveWriteLE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteLE(this ref Span<byte> span, Guid value) => SpanUtils.TryMoveWriteLE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(this Span<byte> span) => SpanUtils.ReadSByteBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(this Span<byte> span, out int length) => SpanUtils.ReadSByteBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(this Span<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByteBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(this Span<byte> span, out SByte value) => SpanUtils.TryReadSByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadSByteBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte ReadSByteBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSByteBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(this ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryReadSByteBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSByteBE(this ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryReadSByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, SByte value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, SByte value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, SByte value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, SByte value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(this ref Span<byte> span) => SpanUtils.MoveReadSByteBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSByteBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(this ref Span<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(this ref Span<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSByteBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte MoveReadSByteBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSByteBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(this ref ReadOnlySpan<byte> span, out SByte value, out int length) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSByteBE(this ref ReadOnlySpan<byte> span, out SByte value) => SpanUtils.TryMoveReadSByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, SByte value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, SByte value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, SByte value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, SByte value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(this Span<byte> span) => SpanUtils.ReadByteBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(this Span<byte> span, out int length) => SpanUtils.ReadByteBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(this Span<byte> span, out Byte value, out int length) => SpanUtils.TryReadByteBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(this Span<byte> span, out Byte value) => SpanUtils.TryReadByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadByteBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte ReadByteBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadByteBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(this ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryReadByteBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadByteBE(this ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryReadByteBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Byte value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Byte value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Byte value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Byte value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(this ref Span<byte> span) => SpanUtils.MoveReadByteBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadByteBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(this ref Span<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByteBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(this ref Span<byte> span, out Byte value) => SpanUtils.TryMoveReadByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadByteBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte MoveReadByteBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadByteBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(this ref ReadOnlySpan<byte> span, out Byte value, out int length) => SpanUtils.TryMoveReadByteBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadByteBE(this ref ReadOnlySpan<byte> span, out Byte value) => SpanUtils.TryMoveReadByteBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Byte value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Byte value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Byte value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Byte value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(this Span<byte> span) => SpanUtils.ReadUInt16BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(this Span<byte> span, out int length) => SpanUtils.ReadUInt16BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt16BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt16BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUInt16BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt16BE(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt16 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt16 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt16 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt16 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(this ref Span<byte> span) => SpanUtils.MoveReadUInt16BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt16BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt16BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt16BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt16BE(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt16 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt16 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt16 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(this Span<byte> span) => SpanUtils.ReadInt16BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(this Span<byte> span, out int length) => SpanUtils.ReadInt16BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(this Span<byte> span, out Int16 value) => SpanUtils.TryReadInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt16BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt16BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadInt16BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt16BE(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadInt16BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int16 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int16 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int16 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int16 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(this ref Span<byte> span) => SpanUtils.MoveReadInt16BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt16BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt16BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt16BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt16BE(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadInt16BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int16 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int16 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int16 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(this Span<byte> span) => SpanUtils.ReadUInt32BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(this Span<byte> span, out int length) => SpanUtils.ReadUInt32BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt32BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt32BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUInt32BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt32BE(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt32 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt32 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt32 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt32 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(this ref Span<byte> span) => SpanUtils.MoveReadUInt32BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt32BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt32BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt32BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt32BE(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt32 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt32 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt32 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(this Span<byte> span) => SpanUtils.ReadInt32BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(this Span<byte> span, out int length) => SpanUtils.ReadInt32BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt32BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt32BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt32BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt32BE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt32BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int32 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int32 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(this ref Span<byte> span) => SpanUtils.MoveReadInt32BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt32BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt32BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt32BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt32BE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt32BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(this Span<byte> span) => SpanUtils.ReadUInt64BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(this Span<byte> span, out int length) => SpanUtils.ReadUInt64BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt64BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt64BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadUInt64BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt64BE(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadUInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt64 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt64 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt64 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt64 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(this ref Span<byte> span) => SpanUtils.MoveReadUInt64BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt64BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt64BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt64BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt64BE(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadUInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt64 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt64 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt64 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(this Span<byte> span) => SpanUtils.ReadInt64BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(this Span<byte> span, out int length) => SpanUtils.ReadInt64BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(this Span<byte> span, out Int64 value) => SpanUtils.TryReadInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt64BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt64BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadInt64BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt64BE(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadInt64BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int64 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int64 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int64 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int64 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(this ref Span<byte> span) => SpanUtils.MoveReadInt64BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt64BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt64BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt64BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt64BE(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadInt64BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int64 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int64 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int64 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(this Span<byte> span) => SpanUtils.ReadSingleBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(this Span<byte> span, out int length) => SpanUtils.ReadSingleBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadSingleBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(this Span<byte> span, out Single value) => SpanUtils.TryReadSingleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadSingleBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadSingleBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadSingleBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadSingleBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadSingleBE(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadSingleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Single value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Single value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Single value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Single value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(this ref Span<byte> span) => SpanUtils.MoveReadSingleBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadSingleBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadSingleBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadSingleBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadSingleBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadSingleBE(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadSingleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Single value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Single value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Single value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Single value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(this Span<byte> span) => SpanUtils.ReadDoubleBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(this Span<byte> span, out int length) => SpanUtils.ReadDoubleBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(this Span<byte> span, out Double value, out int length) => SpanUtils.TryReadDoubleBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(this Span<byte> span, out Double value) => SpanUtils.TryReadDoubleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadDoubleBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDoubleBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDoubleBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(this ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryReadDoubleBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDoubleBE(this ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryReadDoubleBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Double value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Double value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Double value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Double value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(this ref Span<byte> span) => SpanUtils.MoveReadDoubleBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDoubleBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(this ref Span<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(this ref Span<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDoubleBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double MoveReadDoubleBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDoubleBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(this ref ReadOnlySpan<byte> span, out Double value, out int length) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDoubleBE(this ref ReadOnlySpan<byte> span, out Double value) => SpanUtils.TryMoveReadDoubleBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Double value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Double value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Double value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Double value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(this Span<byte> span) => SpanUtils.ReadDecimalBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(this Span<byte> span, out int length) => SpanUtils.ReadDecimalBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(this Span<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimalBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(this Span<byte> span, out Decimal value) => SpanUtils.TryReadDecimalBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadDecimalBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal ReadDecimalBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadDecimalBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(this ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryReadDecimalBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadDecimalBE(this ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryReadDecimalBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Decimal value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Decimal value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Decimal value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Decimal value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(this ref Span<byte> span) => SpanUtils.MoveReadDecimalBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadDecimalBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(this ref Span<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(this ref Span<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadDecimalBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Decimal MoveReadDecimalBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadDecimalBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(this ref ReadOnlySpan<byte> span, out Decimal value, out int length) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadDecimalBE(this ref ReadOnlySpan<byte> span, out Decimal value) => SpanUtils.TryMoveReadDecimalBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Decimal value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Decimal value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Decimal value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(this Span<byte> span) => SpanUtils.ReadBooleanBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(this Span<byte> span, out int length) => SpanUtils.ReadBooleanBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBooleanBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBooleanBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadBooleanBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBooleanBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBooleanBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBooleanBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBooleanBE(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBooleanBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Boolean value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Boolean value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Boolean value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Boolean value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(this ref Span<byte> span) => SpanUtils.MoveReadBooleanBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBooleanBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBooleanBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBooleanBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBooleanBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBooleanBE(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBooleanBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Boolean value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Boolean value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Boolean value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(this Span<byte> span) => SpanUtils.ReadCharBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(this Span<byte> span, out int length) => SpanUtils.ReadCharBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(this Span<byte> span, out Char value, out int length) => SpanUtils.TryReadCharBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(this Span<byte> span, out Char value) => SpanUtils.TryReadCharBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadCharBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char ReadCharBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadCharBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(this ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryReadCharBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadCharBE(this ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryReadCharBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Char value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Char value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Char value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Char value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(this ref Span<byte> span) => SpanUtils.MoveReadCharBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadCharBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(this ref Span<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadCharBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(this ref Span<byte> span, out Char value) => SpanUtils.TryMoveReadCharBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadCharBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Char MoveReadCharBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadCharBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(this ref ReadOnlySpan<byte> span, out Char value, out int length) => SpanUtils.TryMoveReadCharBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadCharBE(this ref ReadOnlySpan<byte> span, out Char value) => SpanUtils.TryMoveReadCharBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Char value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Char value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Char value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Char value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(this Span<byte> span) => SpanUtils.ReadFloatBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(this Span<byte> span, out int length) => SpanUtils.ReadFloatBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(this Span<byte> span, out Single value, out int length) => SpanUtils.TryReadFloatBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(this Span<byte> span, out Single value) => SpanUtils.TryReadFloatBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadFloatBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloatBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadFloatBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(this ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryReadFloatBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadFloatBE(this ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryReadFloatBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(this ref Span<byte> span) => SpanUtils.MoveReadFloatBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadFloatBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(this ref Span<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(this ref Span<byte> span, out Single value) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadFloatBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single MoveReadFloatBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadFloatBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(this ref ReadOnlySpan<byte> span, out Single value, out int length) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadFloatBE(this ref ReadOnlySpan<byte> span, out Single value) => SpanUtils.TryMoveReadFloatBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(this Span<byte> span) => SpanUtils.ReadShortBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(this Span<byte> span, out int length) => SpanUtils.ReadShortBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(this Span<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShortBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(this Span<byte> span, out Int16 value) => SpanUtils.TryReadShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadShortBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShortBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadShortBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(this ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryReadShortBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadShortBE(this ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryReadShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(this ref Span<byte> span) => SpanUtils.MoveReadShortBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadShortBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(this ref Span<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShortBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(this ref Span<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadShortBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadShortBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadShortBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(this ref ReadOnlySpan<byte> span, out Int16 value, out int length) => SpanUtils.TryMoveReadShortBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadShortBE(this ref ReadOnlySpan<byte> span, out Int16 value) => SpanUtils.TryMoveReadShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(this Span<byte> span) => SpanUtils.ReadUShortBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(this Span<byte> span, out int length) => SpanUtils.ReadUShortBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(this Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShortBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(this Span<byte> span, out UInt16 value) => SpanUtils.TryReadUShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUShortBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShortBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUShortBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(this ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryReadUShortBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUShortBE(this ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryReadUShortBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(this ref Span<byte> span) => SpanUtils.MoveReadUShortBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUShortBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(this ref Span<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(this ref Span<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUShortBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUShortBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUShortBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(this ref ReadOnlySpan<byte> span, out UInt16 value, out int length) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUShortBE(this ref ReadOnlySpan<byte> span, out UInt16 value) => SpanUtils.TryMoveReadUShortBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(this Span<byte> span) => SpanUtils.ReadIntBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(this Span<byte> span, out int length) => SpanUtils.ReadIntBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadIntBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadIntBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadIntBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadIntBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadIntBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadIntBE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(this ref Span<byte> span) => SpanUtils.MoveReadIntBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadIntBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadIntBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadIntBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadIntBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadIntBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadIntBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadIntBE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(this Span<byte> span) => SpanUtils.ReadUIntBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(this Span<byte> span, out int length) => SpanUtils.ReadUIntBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(this Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUIntBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(this Span<byte> span, out UInt32 value) => SpanUtils.TryReadUIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUIntBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUIntBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUIntBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(this ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryReadUIntBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUIntBE(this ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryReadUIntBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(this ref Span<byte> span) => SpanUtils.MoveReadUIntBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUIntBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(this ref Span<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(this ref Span<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUIntBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUIntBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUIntBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(this ref ReadOnlySpan<byte> span, out UInt32 value, out int length) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUIntBE(this ref ReadOnlySpan<byte> span, out UInt32 value) => SpanUtils.TryMoveReadUIntBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(this Span<byte> span) => SpanUtils.ReadLongBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(this Span<byte> span, out int length) => SpanUtils.ReadLongBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(this Span<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLongBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(this Span<byte> span, out Int64 value) => SpanUtils.TryReadLongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadLongBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLongBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadLongBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(this ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryReadLongBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadLongBE(this ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryReadLongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(this ref Span<byte> span) => SpanUtils.MoveReadLongBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadLongBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(this ref Span<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLongBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(this ref Span<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadLongBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadLongBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadLongBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(this ref ReadOnlySpan<byte> span, out Int64 value, out int length) => SpanUtils.TryMoveReadLongBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadLongBE(this ref ReadOnlySpan<byte> span, out Int64 value) => SpanUtils.TryMoveReadLongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(this Span<byte> span) => SpanUtils.ReadULongBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(this Span<byte> span, out int length) => SpanUtils.ReadULongBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(this Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULongBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(this Span<byte> span, out UInt64 value) => SpanUtils.TryReadULongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadULongBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULongBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadULongBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(this ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryReadULongBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadULongBE(this ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryReadULongBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(this ref Span<byte> span) => SpanUtils.MoveReadULongBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadULongBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(this ref Span<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULongBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(this ref Span<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadULongBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadULongBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadULongBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(this ref ReadOnlySpan<byte> span, out UInt64 value, out int length) => SpanUtils.TryMoveReadULongBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadULongBE(this ref ReadOnlySpan<byte> span, out UInt64 value) => SpanUtils.TryMoveReadULongBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(this Span<byte> span) => SpanUtils.ReadBoolBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(this Span<byte> span, out int length) => SpanUtils.ReadBoolBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(this Span<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(this Span<byte> span, out Boolean value) => SpanUtils.TryReadBoolBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadBoolBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean ReadBoolBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadBoolBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(this ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryReadBoolBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadBoolBE(this ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryReadBoolBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(this ref Span<byte> span) => SpanUtils.MoveReadBoolBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadBoolBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(this ref Span<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(this ref Span<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadBoolBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean MoveReadBoolBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadBoolBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(this ref ReadOnlySpan<byte> span, out Boolean value, out int length) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadBoolBE(this ref ReadOnlySpan<byte> span, out Boolean value) => SpanUtils.TryMoveReadBoolBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(this Span<byte> span) => SpanUtils.ReadUInt24BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(this Span<byte> span, out int length) => SpanUtils.ReadUInt24BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(this Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(this Span<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt24BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt24BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(this ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryReadUInt24BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt24BE(this ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryReadUInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt24 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt24 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt24 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt24 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(this ref Span<byte> span) => SpanUtils.MoveReadUInt24BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt24BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(this ref Span<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(this ref Span<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt24BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt24BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(this ref ReadOnlySpan<byte> span, out UInt24 value, out int length) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt24BE(this ref ReadOnlySpan<byte> span, out UInt24 value) => SpanUtils.TryMoveReadUInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt24 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt24 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt24 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(this Span<byte> span) => SpanUtils.ReadInt24BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(this Span<byte> span, out int length) => SpanUtils.ReadInt24BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(this Span<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(this Span<byte> span, out Int32 value) => SpanUtils.TryReadInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt24BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt24BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt24BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(this ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryReadInt24BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt24BE(this ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryReadInt24BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24BE(this Span<byte> span, Int32 value) => SpanUtils.WriteInt24BE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt24BE(this Span<byte> span, Int32 value, out int length) => SpanUtils.WriteInt24BE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24BE(this Span<byte> span, Int32 value, out int length) => SpanUtils.TryWriteInt24BE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteInt24BE(this Span<byte> span, Int32 value) => SpanUtils.TryWriteInt24BE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(this ref Span<byte> span) => SpanUtils.MoveReadInt24BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt24BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(this ref Span<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(this ref Span<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt24BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt24BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt24BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(this ref ReadOnlySpan<byte> span, out Int32 value, out int length) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt24BE(this ref ReadOnlySpan<byte> span, out Int32 value) => SpanUtils.TryMoveReadInt24BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24BE(this ref Span<byte> span, Int32 value) => SpanUtils.MoveWriteInt24BE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteInt24BE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.MoveWriteInt24BE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24BE(this ref Span<byte> span, Int32 value, out int length) => SpanUtils.TryMoveWriteInt24BE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteInt24BE(this ref Span<byte> span, Int32 value) => SpanUtils.TryMoveWriteInt24BE(ref span, value, out _);
#if NET6_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(this Span<byte> span) => SpanUtils.ReadHalfBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(this Span<byte> span, out int length) => SpanUtils.ReadHalfBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(this Span<byte> span, out Half value, out int length) => SpanUtils.TryReadHalfBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(this Span<byte> span, out Half value) => SpanUtils.TryReadHalfBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadHalfBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half ReadHalfBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadHalfBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(this ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryReadHalfBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadHalfBE(this ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryReadHalfBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Half value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Half value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Half value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Half value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(this ref Span<byte> span) => SpanUtils.MoveReadHalfBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadHalfBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(this ref Span<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(this ref Span<byte> span, out Half value) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadHalfBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half MoveReadHalfBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadHalfBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(this ref ReadOnlySpan<byte> span, out Half value, out int length) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadHalfBE(this ref ReadOnlySpan<byte> span, out Half value) => SpanUtils.TryMoveReadHalfBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Half value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Half value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Half value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Half value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(this Span<byte> span) => SpanUtils.ReadInt128BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(this Span<byte> span, out int length) => SpanUtils.ReadInt128BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(this Span<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(this Span<byte> span, out Int128 value) => SpanUtils.TryReadInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadInt128BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 ReadInt128BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadInt128BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(this ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryReadInt128BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadInt128BE(this ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryReadInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int128 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Int128 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int128 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Int128 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(this ref Span<byte> span) => SpanUtils.MoveReadInt128BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadInt128BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(this ref Span<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(this ref Span<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadInt128BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 MoveReadInt128BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadInt128BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(this ref ReadOnlySpan<byte> span, out Int128 value, out int length) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadInt128BE(this ref ReadOnlySpan<byte> span, out Int128 value) => SpanUtils.TryMoveReadInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int128 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int128 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Int128 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif
#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(this Span<byte> span) => SpanUtils.ReadUInt128BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(this Span<byte> span, out int length) => SpanUtils.ReadUInt128BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(this Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(this Span<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(this ReadOnlySpan<byte> span) => SpanUtils.ReadUInt128BE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 ReadUInt128BE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadUInt128BE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(this ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryReadUInt128BE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadUInt128BE(this ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryReadUInt128BE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt128 value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, UInt128 value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt128 value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, UInt128 value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(this ref Span<byte> span) => SpanUtils.MoveReadUInt128BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadUInt128BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(this ref Span<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(this ref Span<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadUInt128BE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 MoveReadUInt128BE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadUInt128BE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(this ref ReadOnlySpan<byte> span, out UInt128 value, out int length) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadUInt128BE(this ref ReadOnlySpan<byte> span, out UInt128 value) => SpanUtils.TryMoveReadUInt128BE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt128 value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt128 value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, UInt128 value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(this Span<byte> span) => SpanUtils.ReadGuidBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(this Span<byte> span, out int length) => SpanUtils.ReadGuidBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(this Span<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuidBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(this Span<byte> span, out Guid value) => SpanUtils.TryReadGuidBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(this ReadOnlySpan<byte> span) => SpanUtils.ReadGuidBE(span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuidBE(this ReadOnlySpan<byte> span, out int length) => SpanUtils.ReadGuidBE(span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(this ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryReadGuidBE(span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryReadGuidBE(this ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryReadGuidBE(span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Guid value) => SpanUtils.WriteBE(span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBE(this Span<byte> span, Guid value, out int length) => SpanUtils.WriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Guid value, out int length) => SpanUtils.TryWriteBE(span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryWriteBE(this Span<byte> span, Guid value) => SpanUtils.TryWriteBE(span, value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(this ref Span<byte> span) => SpanUtils.MoveReadGuidBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(this ref Span<byte> span, out int length) => SpanUtils.MoveReadGuidBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(this ref Span<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(this ref Span<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(this ref ReadOnlySpan<byte> span) => SpanUtils.MoveReadGuidBE(ref span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuidBE(this ref ReadOnlySpan<byte> span, out int length) => SpanUtils.MoveReadGuidBE(ref span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(this ref ReadOnlySpan<byte> span, out Guid value, out int length) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveReadGuidBE(this ref ReadOnlySpan<byte> span, out Guid value) => SpanUtils.TryMoveReadGuidBE(ref span, out value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Guid value) => SpanUtils.MoveWriteBE(ref span, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWriteBE(this ref Span<byte> span, Guid value, out int length) => SpanUtils.MoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Guid value, out int length) => SpanUtils.TryMoveWriteBE(ref span, value, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryMoveWriteBE(this ref Span<byte> span, Guid value) => SpanUtils.TryMoveWriteBE(ref span, value, out _);

    }

}
