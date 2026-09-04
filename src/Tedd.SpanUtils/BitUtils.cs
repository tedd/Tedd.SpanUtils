using System;
using System.Runtime.CompilerServices;

namespace Tedd
{
    internal static class BitUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeadingZeroCount(this ref ulong value)
        {
#if NET6_0_OR_GREATER
            // Selects the appropriate intrinsic on both x86 and ARM.
            return System.Numerics.BitOperations.LeadingZeroCount(value);
#else
            return LzCntSoftwareFallback(value);
#endif
        }

        internal static int LzCntSoftwareFallback(ulong value)
        {
            if (value == 0) return 64;
            uint high = (uint)(value >> 32);
            return high != 0 ? 31 - Log2SoftwareFallback(high) : 63 - Log2SoftwareFallback((uint)value);
        }

        internal static int Log2SoftwareFallback(uint value)
        {
            int bits = 0;
            if (value >= 1U << 16) { value >>= 16; bits += 16; }
            if (value >= 1U << 8) { value >>= 8; bits += 8; }
            if (value >= 1U << 4) { value >>= 4; bits += 4; }
            if (value >= 1U << 2) { value >>= 2; bits += 2; }
            if (value >= 1U << 1) bits++;
            return bits;
        }
    }
}
