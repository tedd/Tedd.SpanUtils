using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tedd.SpanUtils
{
    public enum Int24 : Int32
    {
    }

    public static class Int24Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int24 ToInt24(this Int32 value) => (Int24)(value & 0xFFFFFF);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ToInt32(this Int24 value) => (Int32)value;

    }
}
