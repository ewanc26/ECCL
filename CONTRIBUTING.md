# Contributing to ECCL

ECCL ("Eye Crash Computers Ltd.") is a Visual Basic WinForms component-selection and ordering prototype on .NET 8, built as OCR Cambridge Technicals coursework and published here as-is for anyone curious who wants to build on it. Thank you for wanting to help!

## Getting started

```powershell
dotnet build ECCL.sln --configuration Release
dotnet run --project ECCL.vbproj --configuration Release
```

Windows 11 + Visual Studio 2022 with the .NET desktop development workload and the .NET 8 SDK. `net8.0-windows` means this will not build or run on macOS or Linux — WinForms is Windows-only.

## Notes for this project

- **This is a demonstration project, not a working shop**, and the README is explicit about what it is not: no payments, no persistence, hard-coded demo accounts, fictional data. PRs are welcome to build on it, but PRs that quietly turn demo scaffolding into something that looks production-safe without saying so will not be merged.
- The coursework context matters: destructive refactors that erase the "as-is coursework" character (hard-coded `Const` prices in `Form2.vb`, the plain-text `Dictionary` lookup in `Form1.vb`) should come with a clear statement of intent in the issue and PR.
- The known form-lifetime limitation (`Form3` shown modally while `Form2` is hidden rather than closed) is documented; a proper fix means restructuring form ownership, so it is a design discussion, not a one-liner.
- Embed assets in resources (as the product photos are), not loose files on disk.

## Before opening a PR

- It builds and runs on Windows, and the full sign-in → selection → invoice flow works.
- Conventional commits; one focused PR per change.
- AI-assisted PRs are welcome; stand behind every line.

## Licence

AGPL-3.0 (see [LICENSE](LICENSE)). Contributions are accepted under the same terms.