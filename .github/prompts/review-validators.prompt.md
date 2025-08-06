---
mode: agent
---
# Review Validators

1. Find all C# classes that inherit from `AbstractValidator<T>`.
2. Find all the C# classes for `T` specified in the generic parameter.
3. Review all the `summary` comments for all the properties and make sure that the rules of the associated validators align.
4. If you find a misalignment between related `Dto` and `Entity`, always use the `Entity` as the rule and align the `Dto` with the `Entity`.
