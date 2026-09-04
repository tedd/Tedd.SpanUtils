using System;
using System.Runtime.CompilerServices;
#if NET6_0_OR_GREATER
using System.Numerics;
#endif

namespace Tedd
{
    /// <summary>An EBML variable-length integer, including its original wire representation.</summary>
    public readonly struct VInt
    {
        public const ulong MaxValue = 0x00FFFFFFFFFFFFFEUL;
        public readonly int Length;
        public readonly ulong EncodedValue;
        public readonly ulong Value;
        public readonly int Size;
        /// <summary>True when every payload bit is one: the EBML unknown-size marker.</summary>
        public bool IsUnknown => Length > 0 && Value == (1UL << (Length * 7)) - 1;

        public VInt(int length, ulong encoded, ulong value)
        {
            if ((uint)(length - 1) >= 8) throw new ArgumentOutOfRangeException(nameof(length));
            if (value > (1UL << (length * 7)) - 1) throw new ArgumentOutOfRangeException(nameof(value));
            Length = length;
            EncodedValue = encoded;
            Value = value;
            Size = value == (1UL << (length * 7)) - 1 ? length : GetSize(value);
        }

        /// <summary>Returns the smallest 1–8 byte encoding, reserving all-one payloads for unknown sizes.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetSize(ulong value)
        {
            if (value > MaxValue) throw new ArgumentOutOfRangeException(nameof(value), "EBML data integers have at most 56 payload bits, with the all-one value reserved.");
#if NET6_0_OR_GREATER
            return (64 - BitOperations.LeadingZeroCount(value + 1) + 6) / 7;
#else
            var size = 1;
            while (((value + 1) >> (size * 7)) != 0) size++;
            return size;
#endif
        }

        public override string ToString() => $"VInt, value = {Value}, length = {Length}, encoded = {EncodedValue:X}";
    }
}
