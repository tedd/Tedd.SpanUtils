using System;
using System.Runtime.CompilerServices;

namespace Tedd.Archive
{
    public static partial class SpanUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureVLQ(Int64 value)
        {
            if (value == Int64.MinValue)
                return 1;

            if (value < 0)
                value *= -1;
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
        }

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
