using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>
    /// Since .Net already has a System.IO.MemoryStream this is named MemoryStreamer.
    /// It does the same as MemoryStream, but with Memory&lt;byte&gt;.
    /// Additionally has all the read/write methods of this library. Read/write will progress position.
    /// </summary>
    public partial class ReadOnlyMemoryStreamer : Stream
    {

        private ReadOnlyMemory<byte> Memory;
        private int _position { get; set; }
        private int _length;

        public ReadOnlyMemoryStreamer(ReadOnlyMemory<byte> memory)
        {
            Memory = memory;
            _length = memory.Length;
        }
        public int MaxLength => Memory.Length;

        /// <summary>
        /// Fills span with zero.
        /// </summary>
        /// <param name="all">Normally only clears until Length, set all to true to clear the whole underlying span.</param>
        public void Clear(bool all = false)
        {
            throw new ReadOnlyException("Memory is read-only.");
        }

        #region Overrides of Stream

        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        /// <returns>true if the stream supports reading; otherwise, false.</returns>
        public override bool CanRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        /// <returns>true if the stream supports seeking; otherwise, false.</returns>
        public override bool CanSeek
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }


        /// <summary>Gets a value indicating whether the current stream supports writing.</summary>
        /// <returns>true if the stream supports writing; otherwise, false.</returns>
        public override bool CanWrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => false;
        }


        /// <summary>Gets the length in bytes of the stream.</summary>
        /// <returns>A long value representing the length of the stream in bytes.</returns>
        public override long Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _length;
        }

        /// <summary>Gets or sets the position within the current stream.</summary>
        /// <returns>The current position within the stream.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The requested position is outside of range for the underlying Memory.</exception>
        public override long Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _position;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                // value != 0 && 
                if (value > Memory.Span.Length || value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Position));
                _position = (int)value;
                if (_position > Length)
                    _length = _position;
            }
        }


        /// <summary>Sets the position within the current stream.</summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">A value of type <see cref="T:System.IO.SeekOrigin"></see> indicating the reference point used to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The requested position is outside of range for the underlying Memory.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Seek(long offset, SeekOrigin origin)
        {
            if (origin == SeekOrigin.Begin)
                Position = offset;
            else if (origin == SeekOrigin.End)
                Position = Memory.Length - 1 - offset;
            else if (origin == SeekOrigin.Current)
                Position += offset;

            return Position;
        }

        /// <summary>Sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Attempt to set length that exceeds the underlying span.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void SetLength(long value)
        {
            if (value > Memory.Length || value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            _length = (int)value;
        }


        /// <summary>Has no effect on Span.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Flush() { }

        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public override int Read(byte[] buffer, int offset, int count)
        {
            //if (offset + count > buffer.Length)
            //    throw new ArgumentException($"The sum of offset and count is greater than the buffer length.");
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));
            //if (offset < 0)
            //    throw new ArgumentOutOfRangeException(nameof(offset));
            //if (count < 0)
            //    throw new ArgumentOutOfRangeException(nameof(count));

            var dst = ((Span<byte>)buffer).Slice(offset, count);
            var src = Memory.Span.Slice((int)_position, Math.Min(count, (int)Memory.Length - (int)_position));
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
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new ReadOnlyException("Memory is read-only.");
        }

        #endregion

    }
}