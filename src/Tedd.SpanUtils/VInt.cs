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
            if (value < (1UL << 7) - 1) return 1;
            if (value < (1UL << 14) - 1) return 2;
            if (value < (1UL << 21) - 1) return 3;
            if (value < (1UL << 28) - 1) return 4;
            if (value < (1UL << 35) - 1) return 5;
            if (value < (1UL << 42) - 1) return 6;
            if (value < (1UL << 49) - 1) return 7;
            if (value < (1UL << 56) - 1) return 8;
            if (value < (1UL << 63) - 1) return 9;
            return 10;
        }

        public override string ToString()
        {
            return $"VInt, value = {Value}, length = {Length}, encoded = {EncodedValue:X}";
        }
    }
}