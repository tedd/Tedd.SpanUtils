## 2026-11-01 - Test Dependencies Compatibility

**Observation:** Microsoft.NET.Test.Sdk 18.11.0 and xunit.runner.visualstudio 4.0.1 drop support for net6.0. xunit.runner.visualstudio issues NU1701 warning for net6.0.

**Strategic Action:** Use MSBuild conditional package references to keep net6.0 on older, compatible versions (17.12.0 and 2.8.2 respectively) while upgrading newer framework targets to the latest versions.
