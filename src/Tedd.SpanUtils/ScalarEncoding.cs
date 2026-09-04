using System;
using System.Buffers.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Tedd
{
    public static partial class SpanUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static decimal ReadDecimalPortable(ReadOnlySpan<byte> span, bool bigEndian)
        {
            span = span.Slice(0, 16);
            var flags = bigEndian ? BinaryPrimitives.ReadInt32BigEndian(span.Slice(12)) : BinaryPrimitives.ReadInt32LittleEndian(span.Slice(12));
            if ((flags & 0x7F00FFFF) != 0 || ((flags >> 16) & 0xFF) > 28)
                throw new InvalidDataException("Invalid decimal flags or scale.");
            return new decimal(
                bigEndian ? BinaryPrimitives.ReadInt32BigEndian(span) : BinaryPrimitives.ReadInt32LittleEndian(span),
                bigEndian ? BinaryPrimitives.ReadInt32BigEndian(span.Slice(4)) : BinaryPrimitives.ReadInt32LittleEndian(span.Slice(4)),
                bigEndian ? BinaryPrimitives.ReadInt32BigEndian(span.Slice(8)) : BinaryPrimitives.ReadInt32LittleEndian(span.Slice(8)),
                flags < 0, (byte)(flags >> 16));
        }

        internal static bool IsValidDecimalEncoding(ReadOnlySpan<byte> span, bool bigEndian)
        {
            var flags = bigEndian ? BinaryPrimitives.ReadUInt32BigEndian(span.Slice(12)) : BinaryPrimitives.ReadUInt32LittleEndian(span.Slice(12));
            return (flags & 0x7F00FFFFU) == 0 && ((flags >> 16) & 0xFF) <= 28;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteDecimalPortable(Span<byte> span, decimal value, bool bigEndian)
        {
            span = span.Slice(0, 16);
#if NET6_0_OR_GREATER
            Span<int> bits = stackalloc int[4];
            decimal.GetBits(value, bits);
#else
            // .NET Standard 2.1 exposes only the allocating GetBits overload.
            var bits = decimal.GetBits(value);
#endif
            if (bigEndian)
            {
                BinaryPrimitives.WriteInt32BigEndian(span, bits[0]);
                BinaryPrimitives.WriteInt32BigEndian(span.Slice(4), bits[1]);
                BinaryPrimitives.WriteInt32BigEndian(span.Slice(8), bits[2]);
                BinaryPrimitives.WriteInt32BigEndian(span.Slice(12), bits[3]);
            }
            else
            {
                BinaryPrimitives.WriteInt32LittleEndian(span, bits[0]);
                BinaryPrimitives.WriteInt32LittleEndian(span.Slice(4), bits[1]);
                BinaryPrimitives.WriteInt32LittleEndian(span.Slice(8), bits[2]);
                BinaryPrimitives.WriteInt32LittleEndian(span.Slice(12), bits[3]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Guid ReadGuidBigEndian(ReadOnlySpan<byte> span)
        {
#if NET8_0_OR_GREATER
            return new Guid(span.Slice(0, 16), bigEndian: true);
#else
            span = span.Slice(0, 16);
            return new Guid(BinaryPrimitives.ReadInt32BigEndian(span), BinaryPrimitives.ReadInt16BigEndian(span.Slice(4)),
                BinaryPrimitives.ReadInt16BigEndian(span.Slice(6)), span[8], span[9], span[10], span[11], span[12], span[13], span[14], span[15]);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void WriteGuidBigEndian(Span<byte> span, Guid value)
        {
#if NET8_0_OR_GREATER
            if (!value.TryWriteBytes(span, bigEndian: true, out _))
                throw new ArgumentOutOfRangeException(nameof(span));
#else
            span = span.Slice(0, 16);
            value.TryWriteBytes(span);
            var first = BinaryPrimitives.ReadInt32LittleEndian(span);
            var second = BinaryPrimitives.ReadInt16LittleEndian(span.Slice(4));
            var third = BinaryPrimitives.ReadInt16LittleEndian(span.Slice(6));
            BinaryPrimitives.WriteInt32BigEndian(span, first);
            BinaryPrimitives.WriteInt16BigEndian(span.Slice(4), second);
            BinaryPrimitives.WriteInt16BigEndian(span.Slice(6), third);
#endif
        }

        internal static ulong ReadUnsignedVLQ(ReadOnlySpan<byte> span, int bits, out int length)
        {
            if (TryReadUnsignedVLQCore(span, bits, out var value, out length, out var overflow)) return value;
            if (overflow) throw new OverflowException("VLQ exceeds the target integer range.");
            throw new EndOfStreamException("Incomplete VLQ value.");
        }

        internal static long ReadSignedVLQ(ReadOnlySpan<byte> span, int bits, out int length)
        {
            if (TryReadSignedVLQCore(span, bits, out var value, out length, out var overflow)) return value;
            if (overflow) throw new OverflowException("VLQ exceeds the target integer range.");
            throw new EndOfStreamException("Incomplete VLQ value.");
        }

        internal static bool TryReadUnsignedVLQCore(ReadOnlySpan<byte> span, int bits, out ulong value, out int length, out bool overflow)
        {
            value = 0; length = 0; overflow = false;
            if (span.IsEmpty) return false;
            var first = span[0];
            if (first < 0x80) { value = first; length = 1; return true; }
            var maximum = bits == 64 ? ulong.MaxValue : (1UL << bits) - 1;
            var maxBytes = (bits + 6) / 7;
            ulong result = 0;
            for (var index = 0; index < maxBytes; index++)
            {
                if (index >= span.Length) return false;
                var current = span[index];
                var payload = (ulong)(current & 0x7F);
                var shift = index * 7;
                if (payload > (maximum >> shift)) { overflow = true; return false; }
                result |= payload << shift;
                if ((current & 0x80) == 0) { value = result; length = index + 1; return true; }
            }
            overflow = true;
            return false;
        }

        internal static bool TryReadSignedVLQCore(ReadOnlySpan<byte> span, int bits, out long value, out int length, out bool overflow)
        {
            value = 0; length = 0; overflow = false;
            if (span.IsEmpty) return false;
            var first = span[0];
            if (first == 0x40) { value = bits == 64 ? long.MinValue : -(1L << (bits - 1)); length = 1; return true; }
            var negative = (first & 0x40) != 0;
            ulong result = (ulong)(first & 0x3F);
            if (first < 0x80) { value = negative ? -(long)result : (long)result; length = 1; return true; }
            var maximum = (1UL << (bits - 1)) - 1;
            var maxBytes = (bits + 6) / 7;
            for (var index = 1; index < maxBytes; index++)
            {
                if (index >= span.Length) return false;
                var current = span[index];
                var shift = index * 7 - 1;
                var payload = (ulong)(current & 0x7F);
                if (payload > (maximum >> shift)) { overflow = true; return false; }
                result |= payload << shift;
                if ((current & 0x80) == 0)
                {
                    value = negative ? -(long)result : (long)result;
                    length = index + 1;
                    return true;
                }
            }
            overflow = true;
            return false;
        }

        internal static int WriteUnsignedVLQ(Span<byte> span, ulong value)
        {
            var length = MeasureVLQ(value);
            if (span.Length < length) throw new ArgumentOutOfRangeException(nameof(span));
            var index = 0;
            while (value >= 0x80)
            {
                span[index++] = (byte)(value | 0x80);
                value >>= 7;
            }
            span[index] = (byte)value;
            return length;
        }

        internal static int WriteSignedVLQ(Span<byte> span, long value, long minimum)
        {
            if (value == minimum) { span[0] = 0x40; return 1; }
            var length = MeasureVLQ(value);
            if (span.Length < length) throw new ArgumentOutOfRangeException(nameof(span));
            var negative = value < 0;
            var magnitude = (ulong)(negative ? -value : value);
            span[0] = (byte)((magnitude & 0x3F) | (negative ? 0x40UL : 0));
            magnitude >>= 6;
            var index = 0;
            while (magnitude != 0)
            {
                span[index++] |= 0x80;
                span[index] = (byte)(magnitude & 0x7F);
                magnitude >>= 7;
            }
            return length;
        }
    }
}
