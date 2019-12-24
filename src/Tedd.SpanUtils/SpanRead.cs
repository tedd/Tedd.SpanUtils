using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Tedd.SpanUtils;

namespace Tedd
{
    public static class SpanRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(ref this Span<byte> span) => span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(ref this Span<byte> span) => (sbyte)span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(ref this Span<byte> span) => (Int16)span.ReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(ref this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt16>(span)[0];
            return (UInt16)(
                ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(ref this Span<byte> span)
        {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            return (UInt24)(Int32)(
                  ((UInt32)span[0] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[2]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(ref this Span<byte> span) => (Int32)span.ReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(ref this Span<byte> span)
        {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            return (UInt32)(
                ((UInt32)span[0] << (8 * 3))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[3]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(ref this Span<byte> span) => (Int64)span.ReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(ref this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            return (UInt64)(
                ((UInt64)span[0] << (8 * 7))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[7]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(ref this Span<byte> span) => new Guid(span.Slice(0, 16).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(ref this Span<byte> span)
        {
            var b1 = span.ReadByte();
            var s = b1 >> 6;

#pragma warning disable 8509
            return s switch
#pragma warning restore 8509
            {
                0 => (UInt32)b1 & 0b00111111,
                1 => (UInt32)span.ReadUInt16() & 0b00111111_11111111,
                2 => (UInt32)span.ReadUInt24() & 0b00111111_11111111_11111111,
                3 => (UInt32)span.ReadUInt32() & 0b00111111_11111111_11111111_11111111
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] ReadBytes(ref this Span<byte> span)
        {
            var size = span.ReadSize();
            return span.Slice(0, (int)size).ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ReadString(ref this Span<byte> span)
        {
            var size = span.ReadSize();
#if NETCOREAPP || NETSTANDARD
            var ros = (ReadOnlySpan<byte>)span.Slice(0, (int) size);
            return Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(0, (int) size).ToArray();
            return Encoding.UTF8.GetString(bytes);
#endif
        }


    }
}