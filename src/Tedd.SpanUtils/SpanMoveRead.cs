using System;
using System.Runtime.CompilerServices;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class SpanMoveRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MoveReadByte(ref this Span<byte> span)
        {
            var b = span[0];
            span = span.Slice(1);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte MoveReadSByte(ref this Span<byte> span)
        {
            var b = (sbyte)span[0];
            span = span.Slice(1);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref this Span<byte> span) => (Int16)span.MoveReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref this Span<byte> span)
        {
            var i = span.ReadUInt16();
            span = span.Slice(2);
            return i;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref this Span<byte> span)
        {
            var i = span.ReadUInt24();
            span = span.Slice(3);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref this Span<byte> span) => (Int32)span.MoveReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref this Span<byte> span)
        {
            var i = span.ReadUInt32();
            span = span.Slice(4);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref this Span<byte> span) => (Int64)span.MoveReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref this Span<byte> span)
        {
            var i = span.ReadUInt64();

            span = span.Slice(8);
            return i;
        }

    }
}