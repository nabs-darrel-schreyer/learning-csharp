using FluentValidation;
using LearningCSharp.Domains.LogisticsDomain.Persistence.Entities;

namespace LearningCSharp.Domains.LogisticsDomain.Persistence.Validators;

/// <summary>
/// Validator for ShipmentEntity
/// </summary>
public class ShipmentEntityValidator : AbstractValidator<ShipmentEntity>
{
    public ShipmentEntityValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Shipment ID is required and cannot be empty");

        RuleFor(x => x.StreetAddress)
            .NotEmpty()
            .Length(5, 200)
            .WithMessage("Street address is required and must be between 5 and 200 characters");

        RuleFor(x => x.Suburb)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("Suburb is required and must be between 2 and 100 characters");

        RuleFor(x => x.City)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("City is required and must be between 2 and 100 characters");

        RuleFor(x => x.Region)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage("Region is required and must be between 2 and 50 characters");

        RuleFor(x => x.PostalCode)
            .NotEmpty()
            .Matches(@"^\d{4,10}$")
            .WithMessage("Postal code is required and must be between 4 and 10 digits");

        RuleFor(x => x.Country)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("Country is required and must be between 2 and 100 characters");
    }
}
