using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tedd.SpanUtils { }
namespace Tedd
{
    public static class Utils
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int16 value) => MeasureVLQ((UInt64)(UInt16)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt16 value) => MeasureVLQ((UInt64)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt24 value) => MeasureVLQ((UInt64)((UInt32)value & 0xFFFFFF));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int32 value) => MeasureVLQ((UInt64)(UInt32)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt32 value) => MeasureVLQ((UInt64)value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int64 value) => MeasureVLQ((UInt64)value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(UInt64 value)
        {
            byte i = 1;
            while (value >= 0b10000000)
            {
                i++;
                value >>= 7;
            }
            return i;
        }

    }
}
