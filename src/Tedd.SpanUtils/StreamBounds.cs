using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    internal static class StreamBounds
    {
        internal static void ValidateBuffer(byte[] buffer, int offset, int count)
        {
            if (buffer is null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (offset > buffer.Length || count > buffer.Length - offset)
                throw new ArgumentException("Offset and count exceed the buffer length.");
        }

        internal static int Seek(int position, int length, int capacity, long offset, SeekOrigin origin)
        {
            int start = origin switch
            {
                SeekOrigin.Begin => 0,
                SeekOrigin.Current => position,
                SeekOrigin.End => length,
                _ => throw new ArgumentOutOfRangeException(nameof(origin))
            };
            if (offset < -((long)start) || offset > (long)capacity - start)
                throw new ArgumentOutOfRangeException(nameof(offset));
            return start + (int)offset;
        }
    }
}
