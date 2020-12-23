using Xunit;

namespace Tedd.SpanUtils.Tests.ReadOnlySpan
{
    public class FailTest
    {
        [Fact]
        public void TestSByte()
        {
            Assert.True(false, "Should fail");
        }
    }
}