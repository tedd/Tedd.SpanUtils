namespace Tedd
{
    public readonly struct VInt
    {
        public readonly int Length;
        public readonly ulong EncodedValue;
        public readonly ulong Value;
        public readonly int Size;

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
#if NET8_0_OR_GREATER
            // O(1) time and space complexity using intrinsics instead of O(n) loop.
            // NOTE: The original O(n) loop implementation contained an infinite loop bug for large values
            // (e.g. ulong.MaxValue - 1) due to C# bitshift operators masking the shift count to 63 bits.
            // When octets * 7 >= 64, it wrapped around, causing `((value + 1) >> octets * 7) != 0` to infinitely be true.
            // This optimized implementation fixes that bug by utilizing a constant time intrinsic mapping.
            if (value == ulong.MaxValue) return 10;
            int bits = 64 - System.Numerics.BitOperations.LeadingZeroCount(value + 1);
            return (bits + 6) / 7;
#else
            int octets = 1;
            while ((value + 1) >> octets * 7 != 0)
            {
                ++octets;
                // Patching the infinite loop bug in legacy targets
                if (octets >= 10) return 10;
            }

            return octets;
#endif
        }

        public override string ToString()
        {
            return $"VInt, value = {Value}, length = {Length}, encoded = {EncodedValue:X}";
        }
    }
}
