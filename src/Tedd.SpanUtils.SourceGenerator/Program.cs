using System;
using System.IO;
using System.Linq;

namespace Tedd.SpanUtils.SourceGenerator
{
    internal static class Program
    {
        public static int Main(string[] args)
        {
            var root = args.FirstOrDefault(a => !a.StartsWith("--", StringComparison.Ordinal));
            if (root == null)
            {
                var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
                while (directory != null && !Directory.Exists(Path.Combine(directory.FullName, "src", "Tedd.SpanUtils")))
                    directory = directory.Parent;
                if (directory == null)
                    throw new DirectoryNotFoundException("Pass the library source directory or run within the repository.");
                root = Path.Combine(directory.FullName, "src", "Tedd.SpanUtils");
            }
            CodeGenBodies.Initialize();
            if (!args.Contains("--streams"))
                CodeGenSpanUtilsSpanReadOnlySpan.GenerateSpanMethods("SpanUtils", root);
            if (!args.Contains("--core"))
                CodeGenStreams.Generate(root);
            return 0;
        }
    }
}
