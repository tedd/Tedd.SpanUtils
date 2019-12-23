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
        /// Convert Int32 to UInt24, will perform & 0xFFFFF to truncate Int32.
        /// WARNING: Negative values will be lost, and are not restored with .ToInt32().
        /// </summary>
        /// <remarks>Negative values will be lost, and are not restored with .ToInt32().</remarks>
        /// <param name="value">Value to convert.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ToUInt24(this Int32 value) => (UInt24)(value & 0xFFFFFF);
        /// <summary>
        /// Converts UInt24 to UInt32.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ToUInt32(this UInt24 value) => (UInt32)value;

        /// <summary>
        /// Converts UInt24 to Int32.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ToInt32(this UInt24 value) => (Int32)value;


    }
}