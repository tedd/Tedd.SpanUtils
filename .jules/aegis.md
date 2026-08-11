## 2026-06-02 - Tedd.BitUtils Test Coverage Expansion
**Observation:** BitUtils logic pathways, specifically `LzCntSoftwareFallback` and `Log2SoftwareFallback`, lacked coverage (0%). A boundary condition issue existed where evaluating `value >> 32 > 0` directly on the uint64 value provides correct logical branching instead of using the local variable `n` evaluated through `Log2SoftwareFallback`.
**Strategic Action:** Exposed `BitUtils`, generated parameterized verification inputs spanning full `ulong` spectrums (0, small constants, boundaries across 32-bit marks, `ulong.MaxValue`), and corrected the fallback branch resolution.

## 2026-08-11 - Tedd.VInt Test Coverage Expansion
**Observation:** VInt `GetSize` calculation logic utilized an unbounded loop with `(value + 1) >> octets * 7 != 0`. When evaluated with large inputs like `ulong.MaxValue`, `value + 1` overflows to `0` causing an infinite loop or incorrectly small calculated sizes depending on the compiler context.
**Strategic Action:** Replaced the continuous loop with exact hardcoded limit checks using bit shifts (`(1UL << 7) - 1`) up to 10 bytes and introduced parameterized bound checking spanning `[Theory]` constructs to ensure 100% deterministic coverage for all boundary values across lengths.
