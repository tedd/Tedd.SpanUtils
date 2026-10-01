## 2026-10-01 - Modernize Test and Benchmark Dependencies

**Observation:** `dotnet list package --outdated` on the solution identifies several outdated testing and benchmark dependencies across multiple projects (`Tedd.SpanUtils.Tests`, `Tedd.SpanUtils.StandardTests`, `Tedd.SpanUtils.Benchmark`).
- `Microsoft.NET.Test.Sdk` is requested at `17.12.0`, resolved latest is `18.10.1`.
- `xunit.runner.visualstudio` is requested at `2.8.2`, resolved latest is `4.0.0`.
- `BenchmarkDotNet` is requested at `0.14.0` / `0.15.8`, resolved latest is `0.15.8`. Note `Tedd.SpanUtils.Benchmark` uses different versions based on the target framework. For `net10.0`, it uses `0.15.8`. For `net6.0`, it uses `0.14.0`. The latter could be updated to `0.14.4` or `0.15.x` depending on compatibility. However, BenchmarkDotNet `0.15.x` and `0.14.x` have different API footprints, we should be careful. We can safely update testing packages across projects without affecting the public NuGet package contract.

**Strategic Action:** Update `Microsoft.NET.Test.Sdk` to latest (`18.10.1`) and `xunit.runner.visualstudio` to latest (`4.0.0`) in `Tedd.SpanUtils.Tests.csproj` and `Tedd.SpanUtils.StandardTests.csproj`. Update `BenchmarkDotNet` in `Tedd.SpanUtils.Benchmark.csproj` to latest stable (`0.15.8` across the board unless blocked by net6.0, but BenchmarkDotNet supports `net6.0` on `0.15.8`). Since the main library `Tedd.SpanUtils.csproj` has no dependencies (only framework targets), its package contract is unaffected. We will update the `Directory.Build.props` or project files directly for testing dependencies.
## 2026-10-01 - Resolve Net6.0 Support for Test/Benchmark Packages

**Observation:** Updating `Microsoft.NET.Test.Sdk` to `18.10.1` broke the `net6.0` build of `Tedd.SpanUtils.Tests.csproj` with the error `Microsoft.NET.Test.Sdk doesn't support net6.0 and has not been tested with it`. Similarly, updating `xunit.runner.visualstudio` to `4.0.0` caused `NU1701` warnings for `net6.0`. And `BenchmarkDotNet` `0.15.8` generated multiple `warning : System.* 9.0.5 doesn't support net6.0 and has not been tested with it.` in `Tedd.SpanUtils.Benchmark.csproj`.

**Strategic Action:** We need to use conditional package references for `net6.0` to retain older, compatible versions, while upgrading the `net10.0` targets to the newest versions.
- For `Microsoft.NET.Test.Sdk` and `xunit.runner.visualstudio` in `Tedd.SpanUtils.Tests`, revert `net6.0` to `17.12.0` and `2.8.2` respectively, while keeping `18.10.1` and `4.0.0` for other frameworks (`net10.0`, `net11.0`).
- For `BenchmarkDotNet` in `Tedd.SpanUtils.Benchmark.csproj`, revert `net6.0` to `0.14.0`.
- The `Tedd.SpanUtils.StandardTests.csproj` only targets `net10.0`, so it can safely use the latest testing dependencies without multi-targeting constraints.
