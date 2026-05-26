## 2025-01-20 - Update Documentation Code Examples
**Observation:** Discovered errors in `README.md` code examples where `ReadInt32(i)` was passing an incorrect argument `i` which fails compilation. Further found errors with methods `SizedWrite` and `SizedRead*` not existing. The actual implementations in codebase are `WriteSized` and `ReadSized*`.
**Strategic Action:** Rectified code examples by removing extraneous arguments in `ReadInt32()` and substituting `SizedWrite`/`SizedRead*` with `WriteSized`/`ReadSized*`.
