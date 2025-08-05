using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.FinanceDomain.Dtos.Resources;

namespace LearningCSharp.Domains.FinanceDomain.Dtos.Validators;

/// <summary>
/// Validator for BankAccountDto
/// </summary>
public class BankAccountDtoValidator : AbstractValidator<BankAccountDto>
{
    /// <summary>
    /// Initializes a new instance of the BankAccountDtoValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public BankAccountDtoValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.BankAccountDto_Id_IsInvalid)]);

        RuleFor(x => x.AccountNumber)
            .NotEmpty()
            .Length(8, 20)
            .WithMessage(localizer[nameof(SharedStrings.BankAccountDto_AccountNumber_IsInvalid)]);

        RuleFor(x => x.AccountHolder)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.BankAccountDto_AccountHolder_IsInvalid)]);

        RuleFor(x => x.DateOpened)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Today)
            .WithMessage(localizer[nameof(SharedStrings.BankAccountDto_DateOpened_IsInvalid)]);
    }
}
