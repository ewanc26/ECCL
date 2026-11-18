# AGENTS.md

Guidance for AI coding agents working in **ECCL**.

## Repository and user flow

- `ECCL.vbproj` targets `net8.0-windows` as a `WinExe`; `My Project/Application.myapp` selects `Form1` as the startup form.
- `Form1.vb` validates against three hard-coded username/password pairs and opens `Form2` modally after hiding the login form. This is demonstration data, not authentication suitable for production. `Form1.Designer.vb` also carries a `lblDemoNote` label that advertises the demo status and lists the demo credentials; keep it in sync with the credentials above.
- `Form2.vb` owns fixed component prices, radio-button selection, embedded product images, subtotal calculation, and construction of the component tuple list passed to `Form3`.
- `Form3.vb` maps those same prototype users to hard-coded customer details, calculates 20% VAT and a 10% deposit, and displays a confirmation dialog. “Pay” performs no transaction or persistence, and its message box is worded as an explicit no-payment-taken notice. All customer and company addresses are invented and use the non-existent `QR` postcode area; do not replace them with real ones.
- `Form*.Designer.vb`, form `.resx` files, and `My Project/Resources.*` are designer/generated state. The product images in `images/` are linked through resource names such as `PSU850`, even where the visible choice is labelled 800 W.

## Current behaviour and editing rules

- Keep prices, visible option labels, selected defaults, tuple values, images, invoice rows, and VAT/deposit calculations aligned. The six default selections are AMD, 600 W, 2 TB HDD, 512 GB SSD, Tower, and 8 GB RAM.
- Every price helper falls back to its final option when no radio button is checked; designer group defaults currently prevent that in normal use. Validate explicit selection if controls become dynamic.
- `UpdateAllPrices` also calls `UpdateImages`; the form load separately calls both, so avoid adding
 expensive or stateful work there.
- Navigation has a lifetime flaw: Continue calls `invoice.Show()`, hides `Form2`, and never closes it; closing the invoice can leave the hidden modal dashboard and hidden main form keeping the process alive. Preserve awareness of this when changing form ownership or shutdown behaviour.
- Prefer the Visual Studio designer for layout. When editing generated files manually, keep partial classes, `Friend WithEvents` names, resource keys, `Handles` hookups, and `.resx` references synchronized.
- Do not treat embedded credentials/customer records as real data, add real personal information, or claim that the payment dialog processes money.
- `README.md` is the public-facing description of the project and `LICENSE` covers reuse. Keep the requirements, demo accounts, and pricing table in `README.md` aligned with the constants in `Form2.vb` and the credentials in `Form1.vb`.

## Validation

On Windows with the .NET 8 SDK, run `dotnet build ECCL.sln --configuration Release`. There is no automated test project. Launch from a clean checkout and exercise invalid login, each of the three demo users, all component choices, default and boundary totals, resource rendering, invoice customer mapping, payment confirmation, invoice close, and full application exit. Do not commit `bin/`, `obj/`, `.vs/`, or user-specific project files.

<!-- allowed-agents -->
## Allowed agents

Only **Claude** (Anthropic) and **Mistral** (Mistral AI) may be used as coding agents in this repository. This rule supersedes any earlier agent-attribution guidance in this file.

- Agent-assisted commits must credit only one of those agents:
  - `Co-Authored-By: Claude <noreply@anthropic.com>`
  - `Co-Authored-By: Mistral Vibe <vibe@mistral.ai>`
- Allowed agent footers are `🤖 Generated with [Claude Code](https://claude.com/claude-code)` and `🤖 Generated with [Mistral Vibe](https://mistral.ai)`.
- Do not add `Co-Authored-By:` trailers, `Generated with` footers, author names, or committer identities for any other agent or AI tool.
- Do not credit another agent in commit metadata.

## Allowed agents

Only **Claude** (Anthropic) and **Mistral** (Mistral AI) may be used as coding agents in this repository. This rule supersedes any earlier agent-attribution guidance in this file.

- Agent-assisted commits must credit only one of those agents:
  - `Co-Authored-By: Claude <noreply@anthropic.com>`
  - `Co-Authored-By: Mistral Vibe <vibe@mistral.ai>`
- Allowed agent footers are `🤖 Generated with [Claude Code](https://claude.com/claude-code)` and `🤖 Generated with [Mistral Vibe](https://mistral.ai)`.
- Do not add `Co-Authored-By:` trailers, `Generated with` footers, author names, or 
committer identities for any other agent or AI tool.
- Do not credit another agent in commit metadata.
