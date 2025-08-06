---
mode: agent
---
# Add Dtos Project

Apply the following rules for creating a `Dtos` project in a C# solution.

* If the domain is called `Finance`, place the project in `[root]\src\Domains\FinanceDomain`.
* `Dtos` projects must be associated with a `Domain`.
* Name `Dtos` projects as `[SolutionName].Domains.[DomainName]Domain.Dtos`.
* `Dto` class and file names must **never** end with `Dto`. The names should always follow the names that are ubuiquitous to the business domain.

## Step 1: Check Project Setup

1. If no `Domain` name is provided, prompt the user for one.
2. Create a C# Class Library project using the naming convention `[SolutionName].Domains.[DomainName]Domain.Dtos`.
3. Add the `.csproj` file to the solution.

## Step 2: Create Dtos and Validators

A `Dtos` project must include:
* At least one data transfer object (DTO) class.
* A validator class for each DTO.

1. Prompt the user for the DTO name, which will be used for the class and file name.
2. Create the following files in the project:
   - **Dto Class File**: A C# partial class inheriting from `ObservableObject`.
     - Properties must use private member variables with the `[ObservableProperty]` attribute, named as `_[propertyName]`.
   - **Validator Class File**: A C# class inheriting from `AbstractValidator<T>`, where `T` is the DTO class.
     - The constructor must take an `IStringLocalizer<SharedStrings>` parameter for localization.
     - Each validation rule must use `.WithMessage(localizer[nameof(SharedStrings.[ResourceName])])`.

## Step 3: Localization

The `Dtos` project must support localization with:
* A resource file (`*.resx`) for localized strings.
* Each DTO class must have a localized `Title`.
* Each DTO property must have a localized `Label` and `Description`.
* Each validation rule must have a localized `Message`.
* Use the `summary` comment for each dto property as the value for the resource files `comment`.
* The other language resource comments should be the translations of the English DTO property summary comments, not the English text itself.

1. Create a `Resources` sub-folder in the `Dtos` project if it does not exist.
2. Add a `SharedStrings.resx` file to the `Resources` sub-folder using the IDE's resource file template to ensure proper formatting and automatic generation of the `SharedStrings.Designer.cs` file.
   - Do **not** manually create `SharedStrings.cs` or `SharedStrings.Designer.cs`.
   - Ensure the `.csproj` file includes the `SharedStrings.resx` with the `EmbeddedResource` build action.
3. Add the following resources to `SharedStrings.resx`:
   - DTO Class:
     - Title: `[ClassName]_Title`
   - DTO Class Properties:
     - Name: `[ClassName]_[PropertyName]_Name`
     - Description: `[ClassName]_[PropertyName]_Description`
   - Validation Rules:
     - Invalid Message: `[ClassName]_[PropertyName]_IsInvalid`
4. Ensure the validator class uses `IStringLocalizer<SharedStrings>` to access localized strings.

## Additional Guidelines

* Validate that all file paths and names adhere to the specified conventions.
* Ensure the `.csproj` file includes necessary NuGet packages (`Nabs.Launchpad.Core.Dtos`).
* Confirm that the `SharedStrings.resx` file is correctly linked in the validator class for localization.
* Ensure that the Class1.cs file is removed.