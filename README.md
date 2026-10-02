# ECCL

**Eye Crash Computers Ltd.** — a component selection and ordering prototype, written in
Visual Basic using Windows Forms on .NET 8.

A customer signs in, picks one option in each of six PC component categories, sees a live
subtotal, and continues to an invoice screen that adds VAT and a deposit.

> **This is a demonstration project, not a working shop.** Nothing is charged, nothing is
> stored, and the sign-in is a hard-coded lookup table. See [What this is not](#what-this-is-not).

## Background

This was built as coursework for the **OCR Cambridge Technicals in Information Technology**
qualification — <https://www.ocr.org.uk/qualifications/cambridge-technicals/information-technology/>

It was developed on Windows 11 using Visual Studio 2022, and the code is published here as-is
for anyone curious about how it works or wants to build on it.

---

## Screens

| Form | Role |
| --- | --- |
| `Form1` — *Log In* | Validates the username/password against three hard-coded demo accounts, then opens the dashboard modally. |
| `Form2` — *Component Selection* | Six groups of radio buttons (motherboard, PSU, storage, case, RAM), each with a price, plus a live subtotal. |
| `Form3` — *Invoice* | Line items, customer details, 20% VAT, 10% deposit, and a simulated payment confirmation. |

## Requirements

- Windows 11
- Visual Studio 2022 (17.x) with the **.NET desktop development** workload
- .NET 8 SDK

`net8.0-windows` means this will not build or run on macOS or Linux — WinForms is
Windows-only.

## Building and running

```powershell
git clone https://github.com/ewanc26/ECCL.git
cd ECCL
dotnet build ECCL.sln --configuration Release
dotnet run --project ECCL.vbproj --configuration Release
```

Or open `ECCL.sln` in Visual Studio 2022 and press <kbd>F5</kbd>.

## Demo accounts

| Username | Password |
| --- | --- |
| `user1` | `pass1` |
| `user2` | `pass2` |
| `user3` | `pass3` |

Each account maps to a different fictional customer record, so the invoice header changes
depending on who signs in.

## How pricing works

Every component is a fixed list price held as a `Const` in `Form2.vb`; there is no database
or pricing service.

| Category | Options (£) |
| --- | --- |
| Motherboard | AMD 150 · Intel 90 |
| Power supply | 400 W 25 · 600 W 30 · 800 W 45 |
| Hard disk drive | 1 TB 55 · 2 TB 100 · 4 TB 170 |
| Solid state drive | 256 GB 55 · 512 GB 90 |
| Case | Desktop 80 · Tower 150 · Gaming 200 |
| Memory | 4 GB 30 · 8 GB 60 · 16 GB 100 |

Subtotal is the sum of the six selections. `Form3` then adds **20% VAT**, and quotes a
**10% deposit** of the VAT-inclusive total. The product photo for each category swaps to
match the selected radio button, loading from embedded resources rather than from disk.

## What this is not

Worth being explicit about, because the UI is styled to look like a real storefront:

- **No payments.** The *Pay* button shows a message box and closes the window. It does not
  contact a payment provider, take a card, or move money.
- **No persistence.** Orders are never written anywhere. There is no database, and nothing
  survives closing the app.
- **Not real authentication.** Credentials are a `Dictionary(Of String, String)` in
  `Form1.vb`, compared in plain text. This is demo scaffolding and would be unsafe for
  anything real.
- **All data is fictional.** The company, the customers, and every address are invented. The
  `QR` postcode area does not exist in the UK postcode system, so no record can be traced to
  a real person or place.
- **Not a component shop.** The prices and stock are invented for demonstration.

## Known limitation

Form lifetime handling is rough. Continuing to the invoice calls `Show()` on `Form3` and then
`Hide()`s the dashboard rather than closing it, so closing the invoice window can leave a
hidden modal form — and therefore the process — alive in the background. If the app appears
to hang after you close the invoice, that is this. Fixing it properly means restructuring
form ownership; see `AGENTS.md`.

## Project layout

```
ECCL.sln                 Solution
ECCL.vbproj              net8.0-windows WinForms project
Form1.vb                 Log-in logic (demo credentials)
Form2.vb                 Component selection, fixed prices, subtotal
Form3.vb                 Invoice, VAT/deposit calculation
Form*.Designer.vb        Designer-generated layout — edit via the VS designer
Form*.resx               Designer-generated form resources
My Project/              My namespace settings and embedded resources
images/                  Component photos, embedded as My.Resources
```

`AGENTS.md` documents the rules for editing this codebase, including which files are
designer-generated and should not be hand-edited.

## License

[GNU Affero General Public License v3.0](LICENSE) © Ewan Croft

You are free to use, copy, modify, and redistribute this. The AGPL differs from the GPL in one
respect worth knowing about: if you run a **modified** version of this program as a network
service, you must offer your modified source to the people who use it. For a desktop app
distributed as an executable, the usual GPL obligations apply instead — keep the license and
pass on the source.

OCR and the Cambridge Technicals are trademarks of their respective owners. This repository is
an unofficial student project and is not affiliated with or endorsed by OCR.

