using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class SpanWrite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, byte value) => span[0] = value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, sbyte value) => span[0] = (byte)value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, Int16 value) => span.Write((UInt16)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, UInt16 value)
        {
            //MemoryMarshal.Cast<byte, UInt16>(span)[0] = value;
            span[0] = (byte)(value >> (8 * 1));
            span[1] = (byte)(value & 0xFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, UInt24 value)
        {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[0] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            span[2] = (byte)((Int32)value & 0xFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, Int32 value) => span.Write((UInt32)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, UInt32 value)
        {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            span[3] = (byte)(value & 0xFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, Int64 value) => span.Write((UInt64)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, UInt64 value)
        {
            //MemoryMarshal.Cast<byte, UInt64>(span)[0] = value;
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            span[7] = (byte)(value & 0xFF);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, Guid value)
        {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            var bytes = new Span<byte>(value.ToByteArray());
            bytes.CopyTo(span);
        }
    }
}
