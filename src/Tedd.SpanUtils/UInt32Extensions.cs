using System;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public static class UInt32Extensions
    {
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte MeasureWriteSize(this UInt32 value) => Utils.MeasureWriteSize(value);
    }
}