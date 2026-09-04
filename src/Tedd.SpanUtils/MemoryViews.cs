using System;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public partial class MemoryStreamer
    {
        /// <summary>Returns a writable view of the next bytes without copying and advances the cursor.</summary>
        /// <remarks>The view shares the caller-owned buffer and remains valid independently of this adapter.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Memory<byte> ReadMemory(int length)
        {
            if ((uint)length > (uint)Remaining) throw new ArgumentOutOfRangeException(nameof(length));
            var value = Memory.Slice(_position, length);
            _position += length;
            return value;
        }

        /// <summary>Returns a view only when all requested bytes remain in the logical content.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadMemory(int length, out Memory<byte> value)
        {
            if ((uint)length > (uint)Remaining) { value = default; return false; }
            value = Memory.Slice(_position, length);
            _position += length;
            return true;
        }

        /// <summary>Reads a length-prefixed payload as a writable view without copying.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Memory<byte> ReadSizedMemory() => ReadSizedMemory(out _);

        /// <summary>Reads a payload view and reports the combined prefix and payload length.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Memory<byte> ReadSizedMemory(out int length)
        {
            var payload = SpanUtils.ReadSizedReadOnlySpan(ReadBuffer, out length);
            var value = Memory.Slice(_position + length - payload.Length, payload.Length);
            _position += length;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedMemory(out Memory<byte> value) => TryReadSizedMemory(out value, out _);

        /// <summary>Reads a complete payload view, leaving the cursor unchanged for truncated data.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedMemory(out Memory<byte> value, out int length)
        {
            if (!SpanUtils.TryReadSizedReadOnlySpan(ReadBuffer, out var payload, out length))
            {
                value = default;
                return false;
            }
            value = Memory.Slice(_position + length - payload.Length, payload.Length);
            _position += length;
            return true;
        }

        /// <summary>Copies memory to the current position and advances after a successful write.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteMemory(ReadOnlyMemory<byte> value) => Write(value.Span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteMemory(ReadOnlyMemory<byte> value, out int length) => Write(value.Span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteMemory(ReadOnlyMemory<byte> value) => TryWrite(value.Span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteMemory(ReadOnlyMemory<byte> value, out int length) => TryWrite(value.Span, out length);

        /// <summary>Copies memory with a byte-length prefix, preserving overlapping source data.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSizedMemory(ReadOnlyMemory<byte> value) => WriteSized(value.Span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteSizedMemory(ReadOnlyMemory<byte> value, out int length) => WriteSized(value.Span, out length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSizedMemory(ReadOnlyMemory<byte> value) => TryWriteSized(value.Span);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryWriteSizedMemory(ReadOnlyMemory<byte> value, out int length) => TryWriteSized(value.Span, out length);
    }

    public partial class ReadOnlyMemoryStreamer
    {
        /// <summary>Returns a read-only view of the next bytes without copying and advances the cursor.</summary>
        /// <remarks>The view shares the caller-owned buffer and remains valid independently of this adapter.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlyMemory<byte> ReadMemory(int length)
        {
            if ((uint)length > (uint)Remaining) throw new ArgumentOutOfRangeException(nameof(length));
            var value = Memory.Slice(_position, length);
            _position += length;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadMemory(int length, out ReadOnlyMemory<byte> value)
        {
            if ((uint)length > (uint)Remaining) { value = default; return false; }
            value = Memory.Slice(_position, length);
            _position += length;
            return true;
        }

        /// <summary>Reads a length-prefixed payload as a read-only view without copying.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlyMemory<byte> ReadSizedMemory() => ReadSizedMemory(out _);

        /// <summary>Reads a payload view and reports the combined prefix and payload length.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlyMemory<byte> ReadSizedMemory(out int length)
        {
            var payload = SpanUtils.ReadSizedReadOnlySpan(ReadBuffer, out length);
            var value = Memory.Slice(_position + length - payload.Length, payload.Length);
            _position += length;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedMemory(out ReadOnlyMemory<byte> value) => TryReadSizedMemory(out value, out _);

        /// <summary>Reads a complete payload view, leaving the cursor unchanged for truncated data.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryReadSizedMemory(out ReadOnlyMemory<byte> value, out int length)
        {
            if (!SpanUtils.TryReadSizedReadOnlySpan(ReadBuffer, out var payload, out length))
            {
                value = default;
                return false;
            }
            value = Memory.Slice(_position + length - payload.Length, payload.Length);
            _position += length;
            return true;
        }
    }
}
