using System;
using System.Runtime.CompilerServices;

namespace Tedd.SpanUtils
{
    public static class UInt24Extensions
    {
        /// <summary>
        /// Convert UInt32 to UInt24, will perform & 0xFFFFF to truncate Int32.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ToUInt24(this UInt32 value) => (UInt24)(value & 0xFFFFFF);

        /// <summary>
        /// Converts UInt24 to UInt32.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ToInt32(this UInt24 value) => (UInt32)value;

    }
}