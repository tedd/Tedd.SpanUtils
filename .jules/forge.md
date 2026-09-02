## 2025-02-18 - Tedd.SpanUtils Dependency and Framework Drift

**Observation:** `System.Runtime.CompilerServices.Unsafe` (5.0.0) is marked as deprecated for legacy frameworks. `System.Memory` is outdated (4.5.4 vs 4.6.0). Internal projects (`Benchmark`, `SourceGenerator`) use `net5.0` which is unsupported (NETSDK1138). Test projects contain a deprecated reference to `Microsoft.NETCore.App` (2.2.8) alongside outdated xUnit frameworks that block modernization. Build fails due to a `System.Memory` package downgrade in `Tedd.SpanUtils.DotNet4Tests`.

**Strategic Action:** Update `System.Memory` to `4.6.0` and `System.Runtime.CompilerServices.Unsafe` to `6.1.0` with proper conditional item groups. Remove deprecated `Microsoft.NETCore.App`. Update test dependencies to latest stable versions. Migrate internal tooling projects from `net5.0` to `net8.0`. Ensure local builds and packaging succeed without compatibility downgrade errors.
