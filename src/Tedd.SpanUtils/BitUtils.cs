using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tedd
{
    internal static class BitUtils
    {
#if !BEFORENETCOREAPP3
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 LeadingZeroCount(ref this UInt64 value) => System.Runtime.Intrinsics.X86.Lzcnt.IsSupported ? (Int32)System.Runtime.Intrinsics.X86.Lzcnt.X64.LeadingZeroCount((UInt64)value) : LzCntSoftwareFallback((UInt64)value);
#else
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 LeadingZeroCount(ref this UInt64 value) => LzCntSoftwareFallback((UInt64)value);
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int LzCntSoftwareFallback(UInt64 value)
        {
            // Unguarded fallback contract is 0->63
            if (value == 0)
                return 64;

            var n = Log2SoftwareFallback((UInt32)(value >> 32));
            if (n > 0)
                n += 32;
            else
                n = Log2SoftwareFallback((UInt32)value);

            return 63 - n;
        }
#if !BEFORENETCOREAPP3
        // https://github.com/dotnet/roslyn/pull/24621
        private static ReadOnlySpan<byte> Log2DeBruijn => new byte[32]
#else
        private static byte[] Log2DeBruijn =
#endif
        {
            00, 09, 01, 10, 13, 21, 02, 29,
            11, 14, 16, 18, 22, 25, 03, 30,
            08, 12, 20, 28, 15, 17, 24, 07,
            19, 27, 23, 06, 26, 05, 04, 31
        };
        private static int Log2SoftwareFallback(uint value)
        {
            // No AggressiveInlining due to large method size
            // Has conventional contract 0->0 (Log(0) is undefined)

            // Fill trailing zeros with ones, eg 00010010 becomes 00011111
            value |= value >> 01;
            value |= value >> 02;
            value |= value >> 04;
            value |= value >> 08;
            value |= value >> 16;

#if !BEFORENETCOREAPP3
            // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
            return Unsafe.AddByteOffset(
                // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_1100_0100_1010_1100_1101_1101u
                ref MemoryMarshal.GetReference(Log2DeBruijn),
                // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
                (IntPtr)(int)((value * 0x07C4ACDDu) >> 27));
#else
            return Log2DeBruijn[(value * 0x07C4ACDDu) >> 27];
#endif
        }

    }
}
