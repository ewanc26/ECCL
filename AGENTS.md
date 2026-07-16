# AGENTS.md

Guidance for agents working on ECCL, a legacy Visual Basic Windows Forms application.

## Repository shape

- `ECCL.sln` and `ECCL.vbproj` define the build; preserve their Visual Studio compatibility.
- `Form*.vb` contains behavior, while `Form*.Designer.vb` and `.resx` files are designer-managed UI state.
- `My Project/` contains generated application and resource metadata.
- `images/` is part of the runtime UI catalogue; filenames and resource references are coupled to form behavior.

## Development rules

- Prefer editing forms through the Visual Studio designer. If editing designer files manually, keep partial classes, control names, resource keys, and event hookups consistent.
- Do not modernize the framework, rename controls, or re-encode image assets as part of an unrelated fix.
- Separate presentation logic from component-selection/calculation behavior where feasible, but preserve the existing user flow.
- Validate all numeric input and combinations; display actionable errors instead of allowing conversion exceptions.
- Keep Windows path and culture behavior explicit.

## Validation

Build the solution with the Visual Studio/MSBuild version supported by the project. Launch every form, traverse navigation in both directions, test empty/invalid/boundary inputs, verify images render from a clean checkout, and confirm the packaged executable does not depend on local absolute paths. Do not commit `bin/`, `obj/`, `.vs/`, or user-specific project files.
