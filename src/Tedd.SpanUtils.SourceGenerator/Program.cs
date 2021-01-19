using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    class Program
    {
        public static int Main(string[] args)
        {
            var root = @"..\..\..\..\Tedd.SpanUtils";

            CodeGenBodies.Initialize();
            CodeGenSpanUtilsSpanReadOnlySpan.GenerateSpanMethods("SpanUtils", root);
            CodeGenStreams.Generate(root);
            return 0;
        }
    }
}

