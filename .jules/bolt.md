
## 2024-07-07 - MeasureVLQ Loops O(N) to O(1) Bitwise Evaluation
**Observation:** `MeasureVLQ` and `MeasureWriteSize` logic relied on serial O(N) checking and O(log N) scaling via byte masking. Using intrinsic instruction scaling to `Lzcnt.IsSupported` enables zero allocation calculation of VLQ width limits.
**Strategic Action:** Transition sequential layout and shifting of bits into leading zero count bitwise mapping equations. Created dedicated benchmark implementations tracking memory diagnostication over boundary conditions.
