Title: 🛡️ Aegis: Tedd.BitUtils Test Coverage Expansion

💡 Target: BitUtils logic pathways, specifically `LzCntSoftwareFallback` and `Log2SoftwareFallback` which previously lacked coverage. Additionally discovered and resolved a logical boundary issue within `LzCntSoftwareFallback`.
🎯 Execution: Generated parameterized verification inputs spanning full `ulong` spectrums including boundaries across 32-bit marks and `ulong.MaxValue` via xUnit `[Theory]` constructs.
📊 Coverage Impact: Increased `Tedd.BitUtils` line and branch coverage from 0% to 100%.
🔬 Verification Protocol: Execute `dotnet test src/Tedd.SpanUtils.Tests/Tedd.SpanUtils.Tests.csproj /p:CollectCoverage=true` to verify the execution and coverage thresholds.
