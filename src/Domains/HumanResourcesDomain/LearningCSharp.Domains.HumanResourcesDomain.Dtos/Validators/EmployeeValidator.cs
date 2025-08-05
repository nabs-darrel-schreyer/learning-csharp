using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.HumanResourcesDomain.Dtos.Resources;

namespace LearningCSharp.Domains.HumanResourcesDomain.Dtos.Validators;

/// <summary>
/// Validator for Employee
/// </summary>
public class EmployeeValidator : AbstractValidator<Employee>
{
    /// <summary>
    /// Initializes a new instance of the EmployeeValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public EmployeeValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.Employee_Id_IsInvalid)]);

        RuleFor(x => x.EmployeeNumber)
            .NotEmpty()
            .Length(3, 20)
            .WithMessage(localizer[nameof(SharedStrings.Employee_EmployeeNumber_IsInvalid)]);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Employee_FirstName_IsInvalid)]);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Employee_LastName_IsInvalid)]);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage(localizer[nameof(SharedStrings.Employee_Email_IsInvalid)]);

        RuleFor(x => x.JobTitle)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Employee_JobTitle_IsInvalid)]);

        RuleFor(x => x.Department)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Employee_Department_IsInvalid)]);

        RuleFor(x => x.HireDate)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Today)
            .WithMessage(localizer[nameof(SharedStrings.Employee_HireDate_IsInvalid)]);

        RuleFor(x => x.Salary)
            .GreaterThan(0)
            .WithMessage(localizer[nameof(SharedStrings.Employee_Salary_IsInvalid)]);
    }
}
