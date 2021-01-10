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
    }
}