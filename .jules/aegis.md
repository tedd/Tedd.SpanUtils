## 2026-06-02 - Tedd.BitUtils Test Coverage Expansion
**Observation:** BitUtils logic pathways, specifically `LzCntSoftwareFallback` and `Log2SoftwareFallback`, lacked coverage (0%). A boundary condition issue existed where evaluating `value >> 32 > 0` directly on the uint64 value provides correct logical branching instead of using the local variable `n` evaluated through `Log2SoftwareFallback`.
**Strategic Action:** Exposed `BitUtils`, generated parameterized verification inputs spanning full `ulong` spectrums (0, small constants, boundaries across 32-bit marks, `ulong.MaxValue`), and corrected the fallback branch resolution.


## 2026-08-18 - Tedd.SpanUtils VInt Parsing Coverage Expansion
**Observation:** VInt parsing and serialization pathways lacked comprehensive bounds checking and full branch coverage (0% for ToString, ~75% for ReadVInt exception branches). An empty byte array provided to ReadVInt correctly throws InvalidDataException on length zero, while malformed inputs (incomplete encodings shorter than expected) were uncaught, resulting in unexpected index exceptions or silent corruption.
**Strategic Action:** Added parameterized verification arrays targeting edge cases (empty strings, all-zero fields, shortened max length parameters). Adjusted ReadVInt to defensively verify span.Length < i prior to slice access, resolving indexing exceptions and guaranteeing InvalidDataException throws strictly on invalid length.
