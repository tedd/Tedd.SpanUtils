using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Tedd
{
    public static partial class SpanUtils
    {
        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<short> source, Span<short> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<ushort> source, Span<ushort> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<int> source, Span<int> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<uint> source, Span<uint> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<long> source, Span<long> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<ulong> source, Span<ulong> destination)
        {
#if NET10_0_OR_GREATER
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
#else
            if (destination.Length < source.Length)
                throw new ArgumentException("Destination is shorter than source.", nameof(destination));
            if (source.Overlaps(destination, out int offset) && offset > 0)
            {
                for (int i = source.Length - 1; i >= 0; i--)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
            else
            {
                for (int i = 0; i < source.Length; i++)
                    destination[i] = BinaryPrimitives.ReverseEndianness(source[i]);
            }
#endif
        }

#if NET10_0_OR_GREATER
        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<Int128> source, Span<Int128> destination)
        {
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
        }
#endif

#if NET10_0_OR_GREATER
        /// <summary>Copies values while reversing byte order. Supports in-place and overlapping buffers.</summary>
        /// <exception cref="ArgumentException">Destination is shorter than source.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReverseEndianness(ReadOnlySpan<UInt128> source, Span<UInt128> destination)
        {
            // The runtime selects vector width and instruction set, including on .NET 11.
            BinaryPrimitives.ReverseEndianness(source, destination);
        }
#endif

    }
}
