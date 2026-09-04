using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public static partial class SpanUtils
    {
        public static VInt ReadVInt(ReadOnlySpan<byte> span, int maxLength = 8)
        {
            if (TryReadVInt(span, out var value, maxLength)) return value;
            throw new InvalidDataException("Invalid or incomplete EBML variable-length integer.");
        }

        public static bool TryReadVInt(ReadOnlySpan<byte> span, out VInt value, int maxLength = 8)
        {
            if ((uint)(maxLength - 1) >= 8) throw new ArgumentOutOfRangeException(nameof(maxLength));
            value = default;
            if (span.IsEmpty || span[0] == 0) return false;
            var first = span[0];
            var marker = 0x80;
            var length = 1;
            while ((first & marker) == 0) { marker >>= 1; length++; }
            if (length > maxLength || span.Length < length) return false;
            ulong raw = first;
            ulong payload = (ulong)(first & (marker - 1));
            for (var index = 1; index < length; index++)
            {
                raw = (raw << 8) | span[index];
                payload = (payload << 8) | span[index];
            }
            value = new VInt(length, raw, payload);
            return true;
        }

        public static int WriteVInt(Span<byte> span, ulong value)
        {
            var size = VInt.GetSize(value);
            if (span.Length < size) throw new ArgumentOutOfRangeException(nameof(span));
            var encoded = value | (1UL << (7 * size));
            for (var index = size - 1; index >= 0; index--)
            {
                span[index] = (byte)encoded;
                encoded >>= 8;
            }
            return size;
        }

        public static bool TryWriteVInt(Span<byte> span, ulong value, out int length)
        {
            length = 0;
            if (value > VInt.MaxValue || span.Length < VInt.GetSize(value)) return false;
            length = WriteVInt(span, value);
            return true;
        }

        public static VInt MoveReadVInt(ref Span<byte> span, int maxLength = 8)
        {
            var value = ReadVInt(span, maxLength);
            span = span.Slice(value.Length);
            return value;
        }
        public static VInt MoveReadVInt(ref ReadOnlySpan<byte> span, int maxLength = 8)
        {
            var value = ReadVInt(span, maxLength);
            span = span.Slice(value.Length);
            return value;
        }
        public static bool TryMoveReadVInt(ref Span<byte> span, out VInt value, int maxLength = 8)
        {
            if (!TryReadVInt(span, out value, maxLength)) return false;
            span = span.Slice(value.Length);
            return true;
        }
        public static bool TryMoveReadVInt(ref ReadOnlySpan<byte> span, out VInt value, int maxLength = 8)
        {
            if (!TryReadVInt(span, out value, maxLength)) return false;
            span = span.Slice(value.Length);
            return true;
        }
        public static int MoveWriteVInt(ref Span<byte> span, ulong value)
        {
            var length = WriteVInt(span, value);
            span = span.Slice(length);
            return length;
        }
        public static bool TryMoveWriteVInt(ref Span<byte> span, ulong value, out int length)
        {
            if (!TryWriteVInt(span, value, out length)) return false;
            span = span.Slice(length);
            return true;
        }
    }

    public static partial class SpanRead
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VInt ReadVInt(this Span<byte> span, int maxLength = 8) => SpanUtils.ReadVInt(span, maxLength);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VInt ReadVInt(this ReadOnlySpan<byte> span, int maxLength = 8) => SpanUtils.ReadVInt(span, maxLength);
        public static bool TryReadVInt(this Span<byte> span, out VInt value, int maxLength = 8) => SpanUtils.TryReadVInt(span, out value, maxLength);
        public static bool TryReadVInt(this ReadOnlySpan<byte> span, out VInt value, int maxLength = 8) => SpanUtils.TryReadVInt(span, out value, maxLength);
        public static VInt MoveReadVInt(this ref Span<byte> span, int maxLength = 8) => SpanUtils.MoveReadVInt(ref span, maxLength);
        public static VInt MoveReadVInt(this ref ReadOnlySpan<byte> span, int maxLength = 8) => SpanUtils.MoveReadVInt(ref span, maxLength);
        public static bool TryMoveReadVInt(this ref Span<byte> span, out VInt value, int maxLength = 8) => SpanUtils.TryMoveReadVInt(ref span, out value, maxLength);
        public static bool TryMoveReadVInt(this ref ReadOnlySpan<byte> span, out VInt value, int maxLength = 8) => SpanUtils.TryMoveReadVInt(ref span, out value, maxLength);
    }
}
