using System;
using System.Runtime.CompilerServices;
#if NET6_0_OR_GREATER
using System.Numerics;
#endif

namespace Tedd
{
    public static partial class SpanUtils
    {
        /// <summary>Returns the byte count of the compact 30-bit length prefix.</summary>
        /// <remarks>Time complexity: O(1) Space complexity: O(1).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureWriteSize(uint value)
        {
            if (value > 0x3FFFFFFF) throw new ArgumentOutOfRangeException(nameof(value), "Size exceeds the 30-bit format.");
#if NET6_0_OR_GREATER
            return (byte)(((33 - BitOperations.LeadingZeroCount(value | 1)) >> 3) + 1);
#else
            if (value <= 0x3F) return 1;
            if (value <= 0x3FFF) return 2;
            if (value <= 0x3FFFFF) return 3;
            return 4;
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(short value) => value == short.MinValue ? (byte)1 : MeasureVLQ((long)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(ushort value) => MeasureVLQ((ulong)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt24 value)
        {
            if ((uint)value > 0xFFFFFFU) throw new ArgumentOutOfRangeException(nameof(value));
            return MeasureVLQ((ulong)value);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(int value) => value == int.MinValue ? (byte)1 : MeasureVLQ((long)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(uint value) => MeasureVLQ((ulong)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(long value)
        {
            if (value == long.MinValue) return 1;
            var magnitude = (ulong)(value < 0 ? -value : value);
#if NET6_0_OR_GREATER
            return (byte)((65 - BitOperations.LeadingZeroCount(magnitude | 1UL) + 6) / 7);
#else
            var length = 1;
            for (magnitude >>= 6; magnitude != 0; magnitude >>= 7) length++;
            return (byte)length;
#endif
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(ulong value)
        {
#if NET6_0_OR_GREATER
            return (byte)((64 - BitOperations.LeadingZeroCount(value | 1UL) + 6) / 7);
#else
            var length = 1;
            while (value >= 0x80) { value >>= 7; length++; }
            return (byte)length;
#endif
        }
    }
}
