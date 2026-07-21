using System;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public static partial class SpanUtils
    {
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureWriteSize(UInt32 value)
        {
            // If small (up to 63) we store length as 1 byte
            if (value <= 0b00111111) return 1;
            // Slightly larger (up to 16K) we store length as 2 bytes
            if (value <= 0b00111111_11111111) return 2;
            // Even larger (up to 4,2M) we store length as 3 bytes
            if (value <= 0b00111111_11111111_11111111) return 3;
            // Largest (up to 1M) we store length as 4 bytes
            if (value <= 0b00111111_11111111_11111111_11111111) return 4;
            // Above that is unsupported. This is intended to be a compact representation of unknown size.
            throw new ArgumentException("Size too large, use WriteUInt32 or WriteUInt64 instead.", nameof(value));
        }

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int16 value)
        {
            if (value == Int16.MinValue)
                return 1;
            return MeasureVLQ((Int64)value);
        }

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt16 value) => MeasureVLQ((UInt64)value);

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt24 value) => MeasureVLQ((UInt64)((UInt32)value & 0xFFFFFF));

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int32 value)
        {
            if (value == Int32.MinValue)
                return 1;
            return MeasureVLQ((Int64)value);
        }

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt32 value) => MeasureVLQ((UInt64)value);

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int64 value)
        {
            if (value == Int64.MinValue) return 1;

#if NET5_0_OR_GREATER || NETCOREAPP3_0_OR_GREATER
            UInt64 uvalue = (UInt64)(value < 0 ? -value : value);
            if (uvalue < 0b01000000) return 1;
            return (byte)((System.Numerics.BitOperations.Log2(uvalue) - 6) / 7 + 2);
#else
            if (value < 0) value *= -1;
            byte i = 1;
            if (value >= 0b01000000)
            {
                i++;
                value >>= 6;
            }
            while (value >= 0b10000000)
            {
                i++;
                value >>= 7;
            }
            return i;
#endif
        }

        /// <summary>
        /// Counts how many bytes WriteVLQ will use for a given value.
        /// Big O Time Complexity: O(1) in modern .NET via hardware intrinsics, O(N) fallback in legacy where N is length in bytes.
        /// Big O Space Complexity: O(1)
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt64 value)
        {
#if NET5_0_OR_GREATER || NETCOREAPP3_0_OR_GREATER
            if (value == 0) return 1;
            return (byte)((System.Numerics.BitOperations.Log2(value) + 7) / 7);
#else
            byte i = 1;
            while (value >= 0b10000000)
            {
                i++;
                value >>= 7;
            }
            return i;
#endif
        }
    }
}
