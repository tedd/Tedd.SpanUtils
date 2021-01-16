using System;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public static class SpanMoveWrite
    {

        //#region Primitives
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, byte value)
        //{
        //    span[0] = value;
        //    span = span.Slice(1);
        //    return 1;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, sbyte value)
        //{
        //    span[0] = (byte)value;
        //    span = span.Slice(1);
        //    return 1;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, Int16 value) => span.MoveWrite((UInt16)value);

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, UInt16 value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, UInt24 value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, Int32 value) => span.MoveWrite((UInt32)value);

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, UInt32 value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, Int64 value) => span.MoveWrite((UInt64)value);

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, UInt64 value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //#endregion

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, bool value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, Guid value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //#region Arrays
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, Span<byte> value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, ReadOnlySpan<byte> value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWrite(ref this Span<byte> span, byte[] value)
        //{
        //    var len = span.Write(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveSizedWrite(ref this Span<byte> span, Span<byte> value)
        //{
        //    var len = span.SizedWrite(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveSizedWrite(ref this Span<byte> span, ReadOnlySpan<byte> value)
        //{
        //    var len = span.SizedWrite(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveSizedWrite(ref this Span<byte> span, byte[] value)
        //{
        //    var len = span.SizedWrite(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveSizedWrite(ref this Span<byte> span, string value)
        //{
        //    var len = span.SizedWrite(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //#endregion

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int MoveWriteSize(ref this Span<byte> span, UInt32 value)
        //{
        //    span.WriteSize(value, out var len);
        //    span = span.Slice(len);
        //    return len;
        //}

        //#region VLQ
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, Int16 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, UInt16 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, UInt24 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, Int32 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, UInt32 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, Int64 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static byte MoveWriteVLQ(ref this Span<byte> span, UInt64 value)
        //{
        //    var len = span.WriteVLQ(value);
        //    span = span.Slice(len);
        //    return len;
        //}
        //#endregion

    }
}