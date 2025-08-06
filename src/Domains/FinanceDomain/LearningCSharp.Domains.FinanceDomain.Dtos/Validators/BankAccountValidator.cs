using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.FinanceDomain.Dtos.Resources;

namespace LearningCSharp.Domains.FinanceDomain.Dtos.Validators;

/// <summary>
/// Validator for BankAccount
/// </summary>
public class BankAccountValidator : AbstractValidator<BankAccount>
{
    /// <summary>
    /// Initializes a new instance of the BankAccountValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public BankAccountValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.BankAccount_Id_IsInvalid)]);

        RuleFor(x => x.AccountNumber)
            .NotEmpty()
            .Length(8, 20)
            .WithMessage(localizer[nameof(SharedStrings.BankAccount_AccountNumber_IsInvalid)]);

        RuleFor(x => x.AccountHolder)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.BankAccount_AccountHolder_IsInvalid)]);

        RuleFor(x => x.DateOpened)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Now)
            .WithMessage(localizer[nameof(SharedStrings.BankAccount_DateOpened_IsInvalid)]);
    }
}
