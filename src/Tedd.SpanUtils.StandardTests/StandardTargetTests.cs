using System.Runtime.Versioning;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class StandardTargetTests
    {
        [Fact]
        public void RunsAgainstStandardAsset()
        {
            var target = (TargetFrameworkAttribute)System.Attribute.GetCustomAttribute(
                typeof(SpanUtils).Assembly, typeof(TargetFrameworkAttribute));
            Assert.Equal(".NETStandard,Version=v2.1", target.FrameworkName);
        }
    }
}
