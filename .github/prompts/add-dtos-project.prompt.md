---
mode: agent
tools: ['codebase', 'usages', 'vscodeAPI', 'problems', 'changes', 'testFailure', 'terminalSelection', 'terminalLastCommand', 'openSimpleBrowser', 'fetch', 'findTestFiles', 'searchResults', 'githubRepo', 'extensions', 'runTests', 'editFiles', 'runNotebooks', 'search', 'new', 'runCommands', 'runTasks']
---

# Add `Dtos` Project to C# Solution

Follow these rules when creating a new `Dtos` project.

## Naming and Location Rules

1. Every `Dtos` project must be linked to a **Domain**.
2. If the domain is `Finance`, the project folder is: `{ROOT_FOLDER}\src\Domains\FinanceDomain`
3. Project name format: `{SOLUTION_NAME}.Domains.{DOMAIN_NAME}Domain.Dtos`
4. `Dto` class and file names must **not** end with `Dto`. Use domain-ubiquitous names from the business context.
5. Always use the `dotnet new` command with the `nabs-dto-library` project template to scafold the project.

---

## Step 1: Project Setup

1. Scan the `*.sln` file to see if the project already exisits. If the project already exists, skip to Step 2.
2. If no **DomainName** is provided, prompt the user for one.
3. Use the `nabs-dto-library` project template from `Nabs.Launchpad`:
  - **Parameters**:
    - `DomainName`: provided or prompted.
    - `DtoName`: first DTO name from the user.  
    (If more than one DTO is provided, handle others in Step 2.)
4. Create the project with the naming format above.
5. Add the `.csproj` to the solution.
6. Add the global using for the `SharedStrings` to the `GlobalUsing.cs` file.

---

## Step 2: Create DTOs and Validators

A `Dtos` project must include:
- At least **one DTO class**.
- A **validator class** for each DTO.

**For each DTO:**
1. Prompt for the DTO name (class and file name).
2. Create:
  - **DTO class file**:
    - Partial C# class inheriting from `ObservableObject`.
    - Properties use private backing fields:
      ```csharp
      [ObservableProperty]
      private string _propertyName;
      ```
  - **Validator class file**:
    - Inherits from `AbstractValidator<T>` where `T` is the DTO class.
    - Constructor accepts `IStringLocalizer<SharedStrings>` for localization.
    - Each rule uses:
      ```csharp
      .WithMessage(localizer[nameof(SharedStrings.ResourceName)])
      ```
---

## Step 3: Localization

1. Ensure a `Resources` folder exists in the `Dtos` project.
2. Add `SharedStrings.resx` to `Resources`:
  - Use the IDE template (not manual file creation).
  - `.csproj` must include it with `EmbeddedResource` build action.
3. Resource naming:
  - **DTO class**:
    - Title → `{CLASS_NAME}_Title`
  - **DTO properties**:
    - Name → `{CLASS_NAME}_{PROPERTY_NAME}_Name`
    - Description → `{CLASS_NAME}_{PROPERTY_NAME}_Description`
  - **Validation rules**:
    - Invalid → `{CLASS_NAME}_{PROPERTY_NAME}_IsInvalid`
4. Summary comments in DTO properties become the English resource comments.
5. Other language resource comments contain translations, not the original English text.
6. Validator must use `IStringLocalizer<SharedStrings>` to retrieve strings.

---

## Step 4: Report

Provide a summary report of the state of the new project with the following:
- List all the steps completed.
- List of all the files added.
- Quality gates.

## Additional Checks

- File paths and names follow all naming/location rules.
- `.csproj` references `Nabs.Launchpad.Core.Dtos` NuGet package.
- `SharedStrings.resx` is linked correctly for localization.
- Remove the default `Class1.cs` file.