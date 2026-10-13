## 2026-06-02 - Tedd.BitUtils Test Coverage Expansion
**Observation:** BitUtils logic pathways, specifically `LzCntSoftwareFallback` and `Log2SoftwareFallback`, lacked coverage (0%). A boundary condition issue existed where evaluating `value >> 32 > 0` directly on the uint64 value provides correct logical branching instead of using the local variable `n` evaluated through `Log2SoftwareFallback`.
**Strategic Action:** Exposed `BitUtils`, generated parameterized verification inputs spanning full `ulong` spectrums (0, small constants, boundaries across 32-bit marks, `ulong.MaxValue`), and corrected the fallback branch resolution.
## 2026-10-13 - SpanMoveWrite Coverage Expansion
**Observation:** The `Tedd.SpanMoveWrite` component was identified as having 0% coverage. It exposes extension methods that delegate to `SpanUtils`.
**Strategic Action:** Added parameterized tests for `MoveWriteVInt` and `TryMoveWriteVInt` leveraging `[Theory]` and `[InlineData]` targeting different VInt lengths and boundary conditions, raising coverage for this class to 100%.
