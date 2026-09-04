# Tedd.SpanUtils
Utilities for reading/writing to span.

Available on NuGet: https://www.nuget.org/packages/Tedd.SpanUtils

Span<byte> extension methods to read or write SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, String, byte\[\], span<byte>.
There is also an UInt24 type which can be cast to/from UInt32 and used for reading/writing 3-byte integers.

`MoveWrite()` and `MoveRead*()` moves Span pointer ahead so that the span function as a stream streamwriter and streamreader.

100% code coverate in unit tests.

# Example
```csharp
var mem = new byte[1000];
var span = new Span<byte>(mem);

Int32 a = 1234;
span.Write(a);
var b = span.ReadInt32(i);
// a == b


// Move* methods moves Span-pointer as they read or write.
Int16 a1 = 10;
Int32 a2 = 20;
Int64 a3 = 30;
span.MoveWrite(a1);
span.MoveWrite(a2);
span.MoveWrite(a3);

// To start reading from start we need a new reference for reader pointing to start of memory area.
var span2 = new Span<byte(mem);

var b1 = span2.MoveReadInt16();
var b2 = span2.MoveReadInt32();
var b3 = span2.MoveReadInt64();

// a1 == b1
// a2 == b2
// a3 == b3

```



# Move read/write
Move read/write will slice the current span so that it moves forward in memory area.
## Example
```csharp
var mem = new byte[10];
var span = new Span<byte>(mem);
// span now points to position 0 of mem. Span is 10 bytes long.
var i = span.MoveReadInt32();
// Since Int32 is 4 bytes span was moved ahead 4 bytes.
// span now points to position 4 of mem and is 6 bytes long.
```

# WriteSize() / ReadSize()
`WriteSize()` and `ReadSize()` to write and read size to span. These use a simple compression technique where the 2 first bits are used to describe how many bytes are used for size.

If the number is 6 bits or less (less than 64) then 1 byte is used.<br />
If the number is 14 bits or less (less than 16K) then 2 bytes is used.<br />
If the number is 22 bits or less (less than 4M) then 3 bytes is used.<br />
If the number is 30 bits or less (less than 1B) then 4 bytes is used.<br />

This means that if you use `SizedWrite("hello")` then 1 byte is used for size header and 4 bytes are used for the string. While if you to `SizedWrite(new byte[20_000])` then 3 bytes are used for size header;

If you want to know how many bytes the number is, simply do (firstByte>>6)+1. The result is 1-4.

# Sized writes
String, byte\[\], Span<> and ReadOnlySpan<> can be written using `SizedWrite()`. This will put a 1-4 byte size descriptor in front of the actual data, meaning you do not have to know the size when you read it back using `SizedRead*()`;

# Variable-Length Quantity
Sized writes give an advantage when processing data, since you only need the first two bits to know length. So on first byte you know how much data you need to read for the full number. It is though capped at 30-bit integers since two bits are used for size description.

Another way to store numbers are Variable-Length Quantity. This existists in some variations, but mainly is encoded so that first bit in each byte tells if there is another byte in the sequence. For signed integeres, the second bit of first byte is the signed bit.

WriteVLQ() and ReadVLQ\*() methods provide this functionality.

16-bit: 1-3 bytes.
32-bit: 1-5 bytes.
64-bit: 1-10 bytes.

## String
Strings are converted to UTF8 before being written to span.

For .Net Core allocation-free copying is used to avoid large GC objects. Since UTF8 has variable size the size is first calculated using `Encoding.UTF8.GetByteCount`. This means two passes are made over the string, first calculating then copying to span.

For .Net 4.x a short-lived byte array is used for buffering UTF8 before writing.

## NOTE
Since these methods are implemented as extension methods they cause a defensive copy of a few bytes upon each call. This is a weakness/feature of C#.
