using System;

namespace Tedd
{
    public readonly struct VInt : IEquatable<VInt>
    {
        public int Length { get; }
        public ulong EncodedValue { get; }
        public ulong Value { get; }
        public int Size { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VInt"/> struct.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="encoded">The encoded.</param>
        /// <param name="value">The value.</param>
        public VInt(int length, ulong encoded, ulong value)
        {
            Length = length;
            EncodedValue = encoded;
            Value = value;
            Size = GetSize(Value);
        }

        /// <summary>
        /// Returns the length of the VInt encoding for the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The length</returns>
        public static int GetSize(ulong value)
        {
            int octets = 1;
            while ((value + 1) >> octets * 7 != 0)
            {
                ++octets;
            }

            return octets;
        }

        public override string ToString()
        {
            return $"VInt, value = {Value}, length = {Length}, encoded = {EncodedValue:X}";
        }

        public override bool Equals(object obj)
        {
            return obj is VInt other && Equals(other);
        }

        public bool Equals(VInt other)
        {
            return Length == other.Length &&
                   EncodedValue == other.EncodedValue &&
                   Value == other.Value &&
                   Size == other.Size;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + Length.GetHashCode();
            hash = hash * 31 + EncodedValue.GetHashCode();
            hash = hash * 31 + Value.GetHashCode();
            hash = hash * 31 + Size.GetHashCode();
            return hash;
        }

        public static bool operator ==(VInt left, VInt right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VInt left, VInt right)
        {
            return !(left == right);
        }
    }
}
