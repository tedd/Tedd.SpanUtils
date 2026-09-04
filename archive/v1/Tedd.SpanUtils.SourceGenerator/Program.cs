using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Text;
using Tedd.SpanUtils.SourceGenerator.TestGenerators;

namespace Tedd.SpanUtils.SourceGenerator
{
    class Program
    {
        public static int Main(string[] args)
        {
            var root = @"..\..\..\..\Tedd.SpanUtils";
            var testRoot = @"..\..\..\..\Tedd.SpanUtils.Tests";
            
            CodeGenBodies.Initialize();
            CodeGenSpanUtilsSpanReadOnlySpan.GenerateSpanMethods("SpanUtils", root);
            CodeGenStreams.Generate(root);
            TestGen.Create(testRoot);
            return 0;
        }
    }
}

