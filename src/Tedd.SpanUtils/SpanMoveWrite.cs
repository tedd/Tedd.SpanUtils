using System;
using System.Runtime.CompilerServices;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class SpanMoveWrite
    {


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, byte value)
        {
            span[0] = value;
            span = span.Slice(1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, sbyte value)
        {
            span[0] = (byte)value;
            span = span.Slice(1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, Int16 value) => span.MoveWrite((UInt16)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, UInt16 value)
        {
            span.Write(value);
            span = span.Slice(2);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, UInt24 value)
        {
            span.Write(value);
            span = span.Slice(3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, Int32 value) => span.MoveWrite((UInt32)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, UInt32 value)
        {
            span.Write(value);
            span = span.Slice(4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, Int64 value) => span.MoveWrite((UInt64)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, UInt64 value)
        {
            span.Write(value);
            span = span.Slice(8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveWrite(ref this Span<byte> span, Guid value)
        {
            span.Write(value);
            span = span.Slice(16);
        }
    }
}