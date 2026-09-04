using System;

namespace Tedd
{
    public static class SpanWrite
    {
        public static int WriteVInt(this Span<byte> span, ulong value) => SpanUtils.WriteVInt(span, value);
        public static bool TryWriteVInt(this Span<byte> span, ulong value, out int length) => SpanUtils.TryWriteVInt(span, value, out length);
    }
}
