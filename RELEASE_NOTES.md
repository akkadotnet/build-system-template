#### 1.1.0 October 27th 2026 ####

* Upgraded the template to .NET 10: `NetLibVersion`, `NetTestVersion`, and `NetStandardLibVersion` now all target `net10.0`
* Renamed `NetCoreTestVersion` to `NetTestVersion` for Akka.NET parity
* Sample project now references `$(NetLibVersion)` instead of hardcoding a target framework
* Added `Akka.Console.Tests` so `$(NetTestVersion)` has a real consumer and the template ships a working test project
* Bumped SDK pin to 10.0.403, Akka.Hosting to 1.5.73, Microsoft.Extensions.Hosting to 10.0.14, Microsoft.SourceLink.GitHub to 10.0.403
* Bumped docfx to 2.81.0 and corrected stale tool versions in the README

#### 1.0.0 April 10th 2025 ####

Example release notes