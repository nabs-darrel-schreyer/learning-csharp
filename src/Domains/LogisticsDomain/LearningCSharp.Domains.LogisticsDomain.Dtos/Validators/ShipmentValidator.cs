using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.LogisticsDomain.Dtos.Resources;

namespace LearningCSharp.Domains.LogisticsDomain.Dtos.Validators;

/// <summary>
/// Validator for Shipment
/// </summary>
public class ShipmentValidator : AbstractValidator<Shipment>
{
    /// <summary>
    /// Initializes a new instance of the ShipmentValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public ShipmentValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.Shipment_Id_IsInvalid)]);

        RuleFor(x => x.StreetAddress)
            .NotEmpty()
            .Length(5, 200)
            .WithMessage(localizer[nameof(SharedStrings.Shipment_StreetAddress_IsInvalid)]);

        RuleFor(x => x.Suburb)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Shipment_Suburb_IsInvalid)]);

        RuleFor(x => x.City)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Shipment_City_IsInvalid)]);

        RuleFor(x => x.Region)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.Shipment_Region_IsInvalid)]);

        RuleFor(x => x.PostalCode)
            .NotEmpty()
            .Matches(@"^\d{4,10}$")
            .WithMessage(localizer[nameof(SharedStrings.Shipment_PostalCode_IsInvalid)]);

        RuleFor(x => x.Country)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.Shipment_Country_IsInvalid)]);
    }
}
