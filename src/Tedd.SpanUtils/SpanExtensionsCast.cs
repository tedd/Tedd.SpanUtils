using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Tedd
{
    public static class SpanUtilsCast
    {
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Span<TTo> Cast<TFrom, TTo>(this Span<TFrom> span) where TFrom : struct where TTo : struct => MemoryMarshal.Cast<TFrom, TTo>(span);
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(this ReadOnlySpan<TFrom> span) where TFrom : struct where TTo : struct => MemoryMarshal.Cast<TFrom, TTo>(span);
    }
}