using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>
    /// A ref struct (allocated on stack) that gives similar functionality as System.IO.Stream.
    /// Additionally has all the read methods of this library. Read will progress position.
    /// </summary>
    public ref partial struct ReadOnlySpanStream
    {
        private ReadOnlySpan<byte> Span;
        private int _position;
        public int Length;

        public int Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _position;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                // value != 0 && 
                if (value > Span.Length || value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Position));
                _position = value;
                if (_position > Length)
                    Length = _position;
            }
        }

        public ReadOnlySpanStream(ReadOnlySpan<byte> span)
        {
            Span = span;
            _position = 0;
            Length = span.Length;
        }

        /// <summary>Sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Attempt to set length that exceeds the underlying span.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLength(long value)
        {
            if (value > Span.Length || value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            Length = (int)value;
        }


        /// <summary>Has no effect on Span.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flush() { }



        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        /// <returns>true if the stream supports reading; otherwise, false.</returns>
        public bool CanRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        /// <returns>true if the stream supports seeking; otherwise, false.</returns>
        public bool CanSeek
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }


        /// <summary>Gets a value indicating whether the current stream supports writing.</summary>
        /// <returns>true if the stream supports writing; otherwise, false.</returns>
        public bool CanWrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => false;

        }

        #region Read / Write byte[]
        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public int Read(byte[] buffer, int offset, int count)
        {
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));

            var dst = ((Span<byte>)buffer).Slice(offset, count);
            var src = Span.Slice((int)_position, Math.Min(count, (int)Span.Length - (int)_position));
            src.CopyTo(dst);
            _position += src.Length;
            return src.Length;
        }

        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public void Write(byte[] buffer, int offset, int count)
        {
            throw new ReadOnlyException("Span is read-only.");
        }

        #endregion


    }
}