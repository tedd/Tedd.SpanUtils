using System;

namespace Tedd
{
    // Supressing CA1028 because changing the underlying type to Int32 would break any code expecting an unsigned value behavior.
#pragma warning disable CA1028 // Enum Storage should be Int32
    public enum UInt24 : UInt32
    {
        MinValue = 0,
        MaxValue = 0xFFFFFF,
        Size = 3
    }
#pragma warning restore CA1028
}
