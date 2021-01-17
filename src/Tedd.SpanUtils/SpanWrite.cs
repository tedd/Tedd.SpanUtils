using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Tedd
{
    public static class SpanWrite
    {
        #region VInt
        /// <summary>
		/// Writes a VInt (EBML Variable Length Integer) to the specified span.
		/// </summary>
		/// <returns>The number of bytes written.</returns>
		public static int WriteVInt(this Span<byte> span, ulong value)
        {
            int position = 0;
            int size = VInt.GetSize(value);

            value |= 1UL << (7 * size);
            for (int i = size - 1; i >= 0; --i)
            {
                span[position++] = (byte)(value >> (8 * i));
            }

            return position;
        }
        #endregion
    }
}
