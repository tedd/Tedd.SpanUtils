using System;
using System.Runtime.CompilerServices;
using System.Text;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class ReadOnlySpanMoveRead
    {
        /// <summary>
        /// Same as MoveReadSize, except doesn't process and return the data.
        /// </summary>
        /// <param name="span"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveSize(ref this ReadOnlySpan<byte> span)
        {
            span = span.Slice((span[0] >> 6) + 1);
        }

        /// <summary>
        /// Same as MoveReadSize, except doesn't process and return the data.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="count">Repeat count</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MoveSize(ref this ReadOnlySpan<byte> span, int count)
        {
            for (var i = 0; i < count; i++)
                span = span.Slice((span[0] >> 6) + 1);
        }

        /// <summary>
        /// Simply moves span pointer ahead by this number of bytes.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="length"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Move(ref this ReadOnlySpan<byte> span, int length)
        {
            span = span.Slice(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MoveReadByte(ref this ReadOnlySpan<byte> span)
        {
            var b = span[0];
            span = span.Slice(1);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte MoveReadSByte(ref this ReadOnlySpan<byte> span)
        {
            var b = (sbyte)span[0];
            span = span.Slice(1);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadInt16(ref this ReadOnlySpan<byte> span) => (Int16)span.MoveReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadUInt16(ref this ReadOnlySpan<byte> span)
        {
            var i = span.ReadUInt16();
            span = span.Slice(2);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadUInt24(ref this ReadOnlySpan<byte> span)
        {
            var i = span.ReadUInt24();
            span = span.Slice(3);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadInt32(ref this ReadOnlySpan<byte> span) => (Int32)span.MoveReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadUInt32(ref this ReadOnlySpan<byte> span)
        {
            var i = span.ReadUInt32();
            span = span.Slice(4);
            return i;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadInt64(ref this ReadOnlySpan<byte> span) => (Int64)span.MoveReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadUInt64(ref this ReadOnlySpan<byte> span)
        {
            var i = span.ReadUInt64();

            span = span.Slice(8);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid MoveReadGuid(ref this ReadOnlySpan<byte> span)
        {
            var i = span.ReadGuid();
            span = span.Slice(16);
            return i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadSize(ref this ReadOnlySpan<byte> span, out int totalLength)
        {
            var size = span.ReadSize(out totalLength);
            span = span.Slice(totalLength);
            return size;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] MoveReadBytes(ref this ReadOnlySpan<byte> span, int length)
        {
            var ret = span.Slice(0, length).ToArray();
            span = span.Slice(length);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string MoveSizedReadString(ref this ReadOnlySpan<byte> span, out int totalLength)
        {
            var size = span.ReadSize(out var len);
            totalLength = (int)size + len;
#if NETCOREAPP || NETSTANDARD
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            span = span.Slice((int)totalLength);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] MoveSizedReadBytes(ref this ReadOnlySpan<byte> span, out int totalLength)
        {
            var size = span.ReadSize(out var len);
            totalLength = (int)size + len;
            var ret = span.Slice(len, (int)size).ToArray();
            span = span.Slice((int)totalLength);
            return ret;
        }

        #region VLQ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 MoveReadVLQInt16(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQInt16(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 MoveReadVLQUInt16(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQUInt16(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 MoveReadVLQUInt24(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQUInt24(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 MoveReadVLQInt32(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQInt32(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 MoveReadVLQUInt32(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQUInt32(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 MoveReadVLQInt64(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQInt64(out length);
            span = span.Slice(length);
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 MoveReadVLQUInt64(ref this ReadOnlySpan<byte> span, out int length)
        {
            var value = span.ReadVLQUInt64(out length);
            span = span.Slice(length);
            return value;
        }

        #endregion
    }
}