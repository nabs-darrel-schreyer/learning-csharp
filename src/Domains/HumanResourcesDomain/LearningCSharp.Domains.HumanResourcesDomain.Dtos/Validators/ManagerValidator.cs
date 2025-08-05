using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.HumanResourcesDomain.Dtos.Resources;

namespace LearningCSharp.Domains.HumanResourcesDomain.Dtos.Validators;

/// <summary>
/// Validator for Manager
/// </summary>
public class ManagerValidator : AbstractValidator<Manager>
{
    /// <summary>
    /// Initializes a new instance of the ManagerValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public ManagerValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.Manager_Id_IsInvalid)]);

        RuleFor(x => x.ManagerNumber)
            .NotEmpty()
            .Length(3, 20)
            .WithMessage(localizer[nameof(SharedStrings.Manager_ManagerNumber_IsInvalid)]);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Manager_FirstName_IsInvalid)]);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Manager_LastName_IsInvalid)]);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage(localizer[nameof(SharedStrings.Manager_Email_IsInvalid)]);

        RuleFor(x => x.ManagementLevel)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Manager_ManagementLevel_IsInvalid)]);

        RuleFor(x => x.Department)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Manager_Department_IsInvalid)]);

        RuleFor(x => x.DirectReportsCount)
            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[nameof(SharedStrings.Manager_DirectReportsCount_IsInvalid)]);

        RuleFor(x => x.ManagementStartDate)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Today)
            .WithMessage(localizer[nameof(SharedStrings.Manager_ManagementStartDate_IsInvalid)]);

        RuleFor(x => x.Salary)
            .GreaterThan(0)
            .WithMessage(localizer[nameof(SharedStrings.Manager_Salary_IsInvalid)]);
    }
}
