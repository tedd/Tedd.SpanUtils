using System;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class RuntimeTargetTests
    {
        [Fact]
        public void UsesRequestedRuntimeWithoutMajorVersionRollForward()
        {
#if NET11_0
            Assert.Equal(11, Environment.Version.Major);
#elif NET10_0
            Assert.Equal(10, Environment.Version.Major);
#elif NET6_0
            Assert.Equal(6, Environment.Version.Major);
#endif
        }
    }
}
