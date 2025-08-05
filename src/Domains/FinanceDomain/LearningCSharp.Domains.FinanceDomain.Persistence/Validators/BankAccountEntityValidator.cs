using FluentValidation;
using LearningCSharp.Domains.FinanceDomain.Persistence.Entities;

namespace LearningCSharp.Domains.FinanceDomain.Persistence.Validators;

/// <summary>
/// Validator for BankAccountEntity
/// </summary>
public class BankAccountEntityValidator : AbstractValidator<BankAccountEntity>
{
    public BankAccountEntityValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Account ID is required and cannot be empty");

        RuleFor(x => x.AccountNumber)
            .NotEmpty()
            .Length(8, 20)
            .WithMessage("Account Number is required and must be between 8 and 20 characters");

        RuleFor(x => x.AccountHolder)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("Account Holder name is required and must be between 2 and 100 characters");

        RuleFor(x => x.DateOpened)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Now)
            .WithMessage("Date Opened is required and cannot be in the future");

        RuleFor(x => x.CreatedOn)
            .NotEmpty()
            .WithMessage("CreatedOn is required");
    }
}
