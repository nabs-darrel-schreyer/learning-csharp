---
mode: agent
---
# Add Persistence Project

Apply the following rules for creating a `Persistence` project in a C# solution.

* If the domain is called `Finance`, place the project in `[root]\src\Domains\FinanceDomain`.
* `Persistence` projects must be associated with a `Domain`.
* Name `Persistence` projects as `[SolutionName].Domains.[DomainName]Domain.Persistence`.
* `Persistence` class entities and file names must **always** end with `Entity`.

## Step 1: Check Project Setup

1. If no `Domain` name is provided, prompt the user for one.
2. Create a C# Class Library project using the naming convention `[SolutionName].Domains.[DomainName]Domain.Persistence`.
3. Add the `.csproj` file to the solution.

## Step 2: Create Persistence Entities and Validators

A `Persistence` project must include:
* At least one entity class.
* A validator class for each entity.

1. Prompt the user for the entity name, which will be used for the class and file name.
2. Create the following files in the project:
   - **Entity Class File**: A C# class with the following naming convention: `[EntityName]Entity`.
     - Properties must be public.
     - All entity files must be placed in the `Entities` sub-folder of the project.
   - **Validator Class File**: A C# class inheriting from `FluentValidation.ValidatorBase<T>`, where `T` is the entity class.
   - Entities are not localizable.

## Additional Guidelines

* Validate that all file paths and names adhere to the specified conventions.
* Ensure the `.csproj` file includes necessary NuGet packages (`FluentValidation`).
* Ensure that the Class1.cs file is removed.