using System;
using System.Runtime.CompilerServices;

namespace Tedd.SpanUtils
{
    public static class UInt32Extensions
    {
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MeasureWriteSize(this UInt32 value) => Utils.MeasureWriteSize(value);
    }
}