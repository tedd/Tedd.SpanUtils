using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Tedd
{
    public static class SpanRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(ref this Span<byte> span) => span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(ref this Span<byte> span) => (sbyte) span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(ref this Span<byte> span) => (Int16) span.ReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(ref this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt16>(span)[0];
            return (UInt16) (
                ((UInt16) span[0] << (8 * 1))
                | ((UInt16) span[1]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(ref this Span<byte> span) => (Int32) span.ReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(ref this Span<byte> span)
        {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            return (UInt32) (
                ((UInt32) span[0] << (8 * 3))
                | ((UInt32) span[1] << (8 * 2))
                | ((UInt32) span[2] << (8 * 1))
                | ((UInt32) span[3]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(ref this Span<byte> span) => (Int64) span.ReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(ref this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            return (UInt64) (
                ((UInt64) span[0] << (8 * 7))
                | ((UInt64) span[1] << (8 * 6))
                | ((UInt64) span[2] << (8 * 5))
                | ((UInt64) span[3] << (8 * 4))
                | ((UInt64) span[4] << (8 * 3))
                | ((UInt64) span[5] << (8 * 2))
                | ((UInt64) span[6] << (8 * 1))
                | ((UInt64) span[7]));
        }

    }
}