using System;

namespace Tedd
{
    public static class SpanMoveWrite
    {
        public static int MoveWriteVInt(this ref Span<byte> span, ulong value) => SpanUtils.MoveWriteVInt(ref span, value);
        public static bool TryMoveWriteVInt(this ref Span<byte> span, ulong value, out int length) => SpanUtils.TryMoveWriteVInt(ref span, value, out length);
    }
}
