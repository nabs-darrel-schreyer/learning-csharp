using FluentValidation;
using LearningCSharp.Domains.LogisticsDomain.Persistence.Entities;

namespace LearningCSharp.Domains.LogisticsDomain.Persistence.Validators;

/// <summary>
/// Validator for CarrierEntity
/// </summary>
public class CarrierEntityValidator : AbstractValidator<CarrierEntity>
{
    public CarrierEntityValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Carrier ID is required and cannot be empty");

        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("Carrier name is required and must be between 2 and 100 characters");

        RuleFor(x => x.TelephoneNumber)
            .NotEmpty()
            .Matches(@"^[\+]?[0-9\s\-\(\)]{7,20}$")
            .WithMessage("Telephone number is required and must be in valid format");
    }
}
