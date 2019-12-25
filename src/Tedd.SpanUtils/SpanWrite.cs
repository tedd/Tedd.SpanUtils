using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
            span.Write(value.ToByteArray());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, byte[] value) => span.Write(new Span<byte>(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, string value)
        {
#if NETCOREAPP || NETSTANDARD
            // We use GetByteCount followed by direct copy to avoid creating a byte array (avoid GC).
            // For larger strings this could cause 
            span.WriteSize((UInt32)Encoding.UTF8.GetByteCount(value));
            Encoding.UTF8.GetBytes(value, span);
#else
            span.Write(Encoding.UTF8.GetBytes(value));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, Span<byte> value)
        {
            span.WriteSize((UInt32)value.Length);
            value.CopyTo(span);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Write(ref this Span<byte> span, ReadOnlySpan<byte> value)
        {
            span.WriteSize((UInt32)value.Length);
            value.CopyTo(span);
        }

        /// <summary>
        /// Writes a UInt32 up to 29-bit using 1 to 4 bytes.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteSize(ref this Span<byte> span, UInt32 value)
        {
            // If small (up to 63) we store length as 1 byte
            if (value <= 0b00111111)
                span.Write((Byte)value);
            // Slightly larger (up to 16K) we store length as 2 bytes
            else if (value <= 0b00111111_11111111)
                span.Write((UInt16)((UInt16)value | (0b01 << 14)));
            // Even larger (up to 4,2M) we store length as 3 bytes
            else if (value <= 0b00111111_11111111_11111111)
                span.Write((UInt24)((UInt32)value | (0b10 << 22)));
            // Largest (up to 1M) we store length as 4 bytes
            else if (value <= 0b00111111_11111111_11111111_11111111)
                span.Write((UInt32)((UInt32)value | (0b11 << 30)));
            else
                throw new Exception("Size too large.");

        }



    }
}
