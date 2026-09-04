using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedd.SpanUtils.SourceGenerator.TestGenerators
{
    public static class TestGen
    {
        public static void Create(string root)
        {
            var sb = new StringBuilder();
            sb.AppendLine("        private Random _rnd = new Random();");

            foreach (var ds in CodeGenBodies.DataStructures)
            {
                if (ds.IsAlias)
                    continue;


                var code = $@"
        public void Test{ds.TypeString}() {{
            var val = _rnd.Next{ds.TypeString}();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.Read{ds.TypeString}();
            Assert.Equal(val, back);
        }}
";
                sb.Append(code);

            }

            var str = Helper.CreateClass(false, "ReadWriteTests", sb.ToString(), "");
            var ns = Helper.CreateNamespace("Tedd", str, CodeGenBodies.usings+ @"
using Xunit;
");

            File.WriteAllText(Path.Combine(root, "ReadWriteTests.generated.cs"), ns);

        }
    }
}
