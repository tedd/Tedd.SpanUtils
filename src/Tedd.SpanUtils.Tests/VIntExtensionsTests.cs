using System;
using Xunit;

namespace Tedd.Tests.VInt
{
    public class VIntExtensionsTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        [InlineData(16382, 2)]
        [InlineData(16383, 3)]
        [InlineData(0x00FFFFFFFFFFFFFEUL, 8)]
        public void MoveWriteVInt_TryMoveWriteVInt_WritesCorrectly(ulong value, int expectedSize)
        {
            byte[] buffer = new byte[10];

            // MoveWriteVInt on Span<byte>
            Span<byte> span1 = buffer;
            int size1 = span1.MoveWriteVInt(value);
            Assert.Equal(expectedSize, size1);
            Assert.Equal(10 - expectedSize, span1.Length);

            // TryMoveWriteVInt on Span<byte>
            Array.Clear(buffer, 0, buffer.Length);
            Span<byte> span2 = buffer;
            bool success2 = span2.TryMoveWriteVInt(value, out int size2);
            Assert.True(success2);
            Assert.Equal(expectedSize, size2);
            Assert.Equal(10 - expectedSize, span2.Length);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        public void MoveReadVInt_TryMoveReadVInt_ReadsCorrectly(ulong value, int expectedSize)
        {
            byte[] buffer = new byte[10];
            buffer.AsSpan().WriteVInt(value);

            // MoveReadVInt on Span<byte>
            Span<byte> span1 = buffer;
            var decoded1 = span1.MoveReadVInt();
            Assert.Equal(value, decoded1.Value);
            Assert.Equal(expectedSize, decoded1.Length);
            Assert.Equal(10 - expectedSize, span1.Length);

            // MoveReadVInt on ReadOnlySpan<byte>
            ReadOnlySpan<byte> span2 = buffer;
            var decoded2 = span2.MoveReadVInt();
            Assert.Equal(value, decoded2.Value);
            Assert.Equal(expectedSize, decoded2.Length);
            Assert.Equal(10 - expectedSize, span2.Length);

            // TryMoveReadVInt on Span<byte>
            Span<byte> span3 = buffer;
            bool success3 = span3.TryMoveReadVInt(out var decoded3);
            Assert.True(success3);
            Assert.Equal(value, decoded3.Value);
            Assert.Equal(10 - expectedSize, span3.Length);

            // TryMoveReadVInt on ReadOnlySpan<byte>
            ReadOnlySpan<byte> span4 = buffer;
            bool success4 = span4.TryMoveReadVInt(out var decoded4);
            Assert.True(success4);
            Assert.Equal(value, decoded4.Value);
            Assert.Equal(10 - expectedSize, span4.Length);
        }

        [Theory]
        [InlineData(new byte[0])]
        [InlineData(new byte[] { 0x40 })]
        public void TryReadVInt_Failures(byte[] buffer)
        {
            Span<byte> span1 = buffer;
            ReadOnlySpan<byte> span2 = buffer;

            Assert.False(span1.TryReadVInt(out _));
            Assert.False(span2.TryReadVInt(out _));

            Assert.False(span1.TryMoveReadVInt(out _));
            Assert.Equal(buffer.Length, span1.Length);

            Assert.False(span2.TryMoveReadVInt(out _));
            Assert.Equal(buffer.Length, span2.Length);
        }

        [Theory]
        [InlineData(ulong.MaxValue)]
        public void TryWriteVInt_Failures(ulong value)
        {
            Span<byte> span1 = stackalloc byte[8];
            Assert.False(span1.TryMoveWriteVInt(value, out _));
            Assert.Equal(8, span1.Length);

            Span<byte> span2 = stackalloc byte[1];
            Assert.False(span2.TryMoveWriteVInt(127, out _));
            Assert.Equal(1, span2.Length);
        }

        [Fact]
        public void TryReadVInt_InvalidMaxLength()
        {
             bool exceptionThrown1 = false;
             try
             {
                 Span<byte> span = new byte[] { 0xFF };
                 span.TryReadVInt(out _, 9);
             }
             catch(ArgumentOutOfRangeException)
             {
                 exceptionThrown1 = true;
             }
             Assert.True(exceptionThrown1);

             bool exceptionThrown2 = false;
             try
             {
                 ReadOnlySpan<byte> spanRo = new byte[] { 0xFF };
                 spanRo.TryReadVInt(out _, 9);
             }
             catch(ArgumentOutOfRangeException)
             {
                 exceptionThrown2 = true;
             }
             Assert.True(exceptionThrown2);
        }

        [Fact]
        public void VInt_Constructor_ArgumentExceptions()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Tedd.VInt(9, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Tedd.VInt(1, 0, 128));
        }

        [Theory]
        [InlineData(1, 0x80, 0, "VInt, value = 0, length = 1, encoded = 80")]
        [InlineData(1, 0xFF, 127, "VInt, value = 127, length = 1, encoded = FF")]
        [InlineData(2, 0x407F, 127, "VInt, value = 127, length = 2, encoded = 407F")]
        public void VInt_ToString(int length, ulong encoded, ulong value, string expected)
        {
             Tedd.VInt v = new Tedd.VInt(length, encoded, value);
             Assert.Equal(expected, v.ToString());
        }

        [Fact]
        public void ReadVInt_ExtensionMethods_SpanAndReadOnlySpan()
        {
            byte[] buffer = new byte[10];
            buffer.AsSpan().WriteVInt(127);

            Span<byte> span1 = buffer;
            Tedd.VInt v1 = span1.ReadVInt();
            Assert.Equal(127UL, v1.Value);

            ReadOnlySpan<byte> span2 = buffer;
            Tedd.VInt v2 = span2.ReadVInt();
            Assert.Equal(127UL, v2.Value);
        }
    }
}
