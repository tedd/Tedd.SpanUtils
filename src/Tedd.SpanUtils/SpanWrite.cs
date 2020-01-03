using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class SpanWrite
    {
        #region Primitives
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, byte value)
        {
            span[0] = value;
            return 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, sbyte value)
        {
            span[0] = (byte)value;
            return 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, Int16 value) => span.Write((UInt16)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, UInt16 value)
        {
            //MemoryMarshal.Cast<byte, UInt16>(span)[0] = value;
            span[0] = (byte)(value >> (8 * 1));
            span[1] = (byte)(value & 0xFF);

            return 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, UInt24 value)
        {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[0] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            span[2] = (byte)((Int32)value & 0xFF);

            return 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, Int32 value) => span.Write((UInt32)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, UInt32 value)
        {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            span[3] = (byte)(value & 0xFF);

            return 4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, Int64 value) => span.Write((UInt64)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, UInt64 value)
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

            return 8;
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, Guid value)
        {
            var array = new Span<byte>(value.ToByteArray());
            array.CopyTo(span);

            return 16;
        }


        #region Arrays
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, byte[] value) => span.Write(new Span<byte>(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, Span<byte> value)
        {
            value.CopyTo(span);
            return value.Length;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Write(ref this Span<byte> span, ReadOnlySpan<byte> value)
        {
            value.CopyTo(span);
            return value.Length;
        }



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SizedWrite(ref this Span<byte> span, byte[] value) => span.SizedWrite(new Span<byte>(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SizedWrite(ref this Span<byte> span, string value)
        {
#if NETCOREAPP || NETSTANDARD
            // We use GetByteCount followed by direct copy to avoid creating a byte array (avoid GC).
            // For larger strings this could cause 
            var strSize = (UInt32)Encoding.UTF8.GetByteCount(value);
            var mbs = span.MeasureWriteSize((UInt32)strSize);
            var len = (int)mbs + (int)strSize;
            if (len > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));

            _ = span.WriteSize(strSize);

            Encoding.UTF8.GetBytes(value, span.Slice(mbs));
#else
            var bytes = Encoding.UTF8.GetBytes(value);
            if (bytes.Length > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));

            var mbs = span.WriteSize((UInt32)bytes.Length);
            var len = (int)mbs + bytes.Length;
            var s = span.Slice(mbs, bytes.Length);
            s.Write(bytes);
#endif

            return len;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SizedWrite(ref this Span<byte> span, Span<byte> value)
        {
            var mbs = span.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));

            _ = span.WriteSize((UInt32)value.Length);
            value.CopyTo(span.Slice(mbs));

            return len;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SizedWrite(ref this Span<byte> span, ReadOnlySpan<byte> value)
        {
            var mbs = span.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));
            _ = span.WriteSize((UInt32)value.Length);
            value.CopyTo(span.Slice(mbs));

            return len;
        }
        #endregion

        #region WriteSize
        /// <summary>
        /// Writes a UInt32 up to 29-bit using 1 to 4 bytes.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WriteSize(ref this Span<byte> span, UInt32 value)
        {
            var bs = span.MeasureWriteSize(value);
            if (bs == 1)
                span.Write((Byte)value);
            else if (bs == 2)
                span.Write((UInt16)((UInt16)value | (0b01 << 14)));
            // Even larger (up to 4,2M) we store length as 3 bytes
            else if (bs == 3)
                span.Write((UInt24)((UInt32)value | (0b10 << 22)));
            else if (bs == 4)
                span.Write((UInt32)((UInt32)value | (0b11 << 30)));

            return bs;
        }

        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MeasureWriteSize(ref this Span<byte> span, UInt32 value) => value.MeasureWriteSize();
        #endregion

    }
}
