using System;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class DocumentationExamplesTests
    {
        [Fact]
        public void QuickStartWritesAndReadsOnlyLogicalContent()
        {
            Span<byte> buffer = stackalloc byte[128];
            var writer = new SpanStream(buffer, length: 0);
            writer.WriteBE(42);
            writer.WriteSized("Hello, world!");
            var reader = new ReadOnlySpanStream(writer.WrittenSpan);
            Assert.Equal(42, reader.ReadInt32BE());
            Assert.Equal("Hello, world!", reader.ReadSizedString());
            Assert.Equal(0, reader.Remaining);
        }

        [Fact]
        public void MovingExampleUsesCompleteWrittenLength()
        {
            Span<byte> storage = stackalloc byte[32];
            Span<byte> output = storage;
            output.MoveWriteLE(123);
            output.MoveWriteVLQ(300UL);
            ReadOnlySpan<byte> input = storage.Slice(0, storage.Length - output.Length);
            Assert.Equal(123, input.MoveReadInt32LE());
            Assert.Equal(300UL, input.MoveReadVLQUInt64());
            Assert.True(input.IsEmpty);
        }
    }
}
