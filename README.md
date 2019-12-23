# Tedd.SpanUtils
Utilities for reading/writing to span.

Span<byte> extension methods to read or write SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64.
There is also an UInt24 type which can be cast to/from UInt32 and used for reading/writing 3-byte numbers.

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