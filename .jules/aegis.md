## 2026-06-02 - Tedd.BitUtils Test Coverage Expansion
**Observation:** BitUtils logic pathways, specifically `LzCntSoftwareFallback` and `Log2SoftwareFallback`, lacked coverage (0%). A boundary condition issue existed where evaluating `value >> 32 > 0` directly on the uint64 value provides correct logical branching instead of using the local variable `n` evaluated through `Log2SoftwareFallback`.
**Strategic Action:** Exposed `BitUtils`, generated parameterized verification inputs spanning full `ulong` spectrums (0, small constants, boundaries across 32-bit marks, `ulong.MaxValue`), and corrected the fallback branch resolution.

## 2026-09-08 - Tedd.SpanMoveWrite Test Coverage
**Observation:** Tedd.SpanMoveWrite has 0% method coverage for its extension methods (MoveWriteVInt, TryMoveWriteVInt).
**Strategic Action:** Implement parameterized [Theory]/[InlineData] tests in src/Tedd.SpanUtils.Tests/SpanMoveWriteTests.cs to verify multi-parameter boundary constraints, buffer sizing, and state mutation, driving coverage to 100%.
