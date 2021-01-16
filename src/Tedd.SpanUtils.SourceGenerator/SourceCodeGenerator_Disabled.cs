//using System;
//using System.Diagnostics;
//using System.IO;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.Text;

//namespace Tedd.SpanUtils.SourceGenerator
//{
//    [Generator]
//    public class SourceCodeGenerator: ISourceGenerator
//    {
//        private SyntaxReceiver _syntaxReceiver;

//        #region Implementation of ISourceGenerator

//        /// <summary>
//        /// Called before generation occurs. A generator can use the <paramref name="context" />
//        /// to register callbacks required to perform generation.
//        /// </summary>
//        /// <param name="context">The <see cref="T:Microsoft.CodeAnalysis.GeneratorInitializationContext" /> to register callbacks on</param>
//        public void Initialize(GeneratorInitializationContext context)
//        {
//          //  Debugger.Launch();
//            _syntaxReceiver = new SyntaxReceiver();
//            context.RegisterForSyntaxNotifications(() => _syntaxReceiver);
//        }

//        /// <summary>
//        /// Called to perform source generation. A generator can use the <paramref name="context" />
//        /// to add source files via the <see cref="M:Microsoft.CodeAnalysis.GeneratorExecutionContext.AddSource(System.String,Microsoft.CodeAnalysis.Text.SourceText)" />
//        /// method.
//        /// </summary>
//        /// <param name="context">The <see cref="T:Microsoft.CodeAnalysis.GeneratorExecutionContext" /> to add source to</param>
//        /// <remarks>
//        /// This call represents the main generation step. It is called after a <see cref="T:Microsoft.CodeAnalysis.Compilation" /> is
//        /// created that contains the user written code.
//        /// A generator can use the <see cref="P:Microsoft.CodeAnalysis.GeneratorExecutionContext.Compilation" /> property to
//        /// discover information about the users compilation and make decisions on what source to
//        /// provide.
//        /// </remarks>
//        public void Execute(GeneratorExecutionContext context)
//        {
//            //foreach (var af in context.AdditionalFiles)
//            //{
//            //    Console.WriteLine(af.Path);
//            //}

//            context.AddSource("ReadOnlySpanRead.generated.cs",
//                SourceText.From(File.ReadAllText("SpanRead.cs")
//                        //.Replace("public static ", "public static partial ")
//                        .Replace("Span<byte>", "ReadOnlySpan<byte>")
//                        .Replace("public static class SpanRead", "public static class ReadOnlySpanRead")));
//            context.AddSource("MoveReadOnlySpanRead.generated.cs", 
//                SourceText.From(File.ReadAllText("SpanMoveRead.cs")
//                    //.Replace("public static ", "public static partial ")
//                        .Replace("Span<byte>", "ReadOnlySpan<byte>")
//                        .Replace("public static class SpanMoveRead", "public static class ReadOnlySpanMoveRead")));
//        }

//        #endregion
//    }

//    public class SyntaxReceiver : ISyntaxReceiver
//    {
//        #region Implementation of ISyntaxReceiver

//        /// <summary>
//        /// Called for each <see cref="T:Microsoft.CodeAnalysis.SyntaxNode" /> in the compilation
//        /// </summary>
//        /// <param name="syntaxNode">The current <see cref="T:Microsoft.CodeAnalysis.SyntaxNode" /> being visited</param>
//        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
//        {
            
//        }

//        #endregion
//    }
//}
