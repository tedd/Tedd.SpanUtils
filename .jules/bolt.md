## 2024-05-14 - VInt.GetSize Optimization
**Observation:** `VInt.GetSize(ulong)` uses an O(n) loop involving a bitshift operation to determine the variable-length quantity length. On top of that, an integer overflow on `value + 1` caused bug for `ulong.MaxValue`, and loop condition caused wrapping bitshifts for `octets * 7 >= 64`, leading to infinite loops.
**Strategic Action:** Replace O(n) loop with O(1) calculation using `System.Numerics.BitOperations.LeadingZeroCount`. Ensure to handle the `ulong.MaxValue` overflow edgecase carefully. Preserved previous behavior in `Tedd.SpanUtils.Archive` for A/B testing via `Tedd.SpanUtils.Benchmark`. Evaluated benchmark successfully to reduce latency from 18.32ns to 16.47ns.
## 2026-09-01 - MeasureVLQ Optimization
**Observation:** MeasureVLQ (Int64 and UInt64) uses an O(n) loop involving a bitshift operation to determine the variable-length quantity length.
**Strategic Action:** Replace O(n) loop with O(1) calculation using System.Numerics.BitOperations.LeadingZeroCount for .NET 8.0+. Edge cases such as Int64.MinValue handled correctly. Evaluated successfully.
