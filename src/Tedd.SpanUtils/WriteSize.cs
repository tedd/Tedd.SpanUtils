using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tedd.SpanUtils
{
    internal static class Utils
    {
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MeasureWriteSize(UInt32 value)
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
    }
}
