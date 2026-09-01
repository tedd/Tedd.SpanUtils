## 2024-09-01 - Modernize NuGet Dependencies and Frameworks

**Observation:** Identified outdated NuGet dependencies across multiple projects, and deprecated `net5.0` target frameworks in executable projects (`Tedd.SpanUtils.SourceGenerator` and `Tedd.SpanUtils.Benchmark`). Also observed an obsolete reference to `Microsoft.NETCore.App` in the test project.

**Strategic Action:**
- Upgraded `net5.0` to `net8.0` in `Tedd.SpanUtils.SourceGenerator` and `Tedd.SpanUtils.Benchmark` to resolve `NETSDK1138` compatibility warnings and utilize current LTS targets.
- Updated `System.Memory` to 4.5.5 and `System.Runtime.CompilerServices.Unsafe` to 6.0.0 in `Tedd.SpanUtils` and `Tedd.SpanUtils.DotNet4Tests`.
- Removed `Microsoft.NETCore.App` from `Tedd.SpanUtils.Tests`.
- Updated test dependencies (`coverlet.collector`, `Microsoft.NET.Test.Sdk`, `Tedd.RandomUtils`, `xunit`, `xunit.runner.console`, `xunit.runner.visualstudio`) to latest stable versions.
- Updated benchmark dependencies (`BenchmarkDotNet`, `BenchmarkDotNet.Diagnostics.Windows`) and analyzer dependencies (`Microsoft.CodeAnalysis.Analyzers`, `Microsoft.CodeAnalysis.CSharp.Workspaces`) to latest stable versions.
