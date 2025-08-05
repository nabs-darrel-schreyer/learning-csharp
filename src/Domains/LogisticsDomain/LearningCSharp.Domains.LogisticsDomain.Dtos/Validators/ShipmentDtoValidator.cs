using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.LogisticsDomain.Dtos.Resources;

namespace LearningCSharp.Domains.LogisticsDomain.Dtos.Validators;

/// <summary>
/// Validator for ShipmentDto
/// </summary>
public class ShipmentDtoValidator : AbstractValidator<ShipmentDto>
{
    /// <summary>
    /// Initializes a new instance of the ShipmentDtoValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public ShipmentDtoValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_Id_IsInvalid)]);

        RuleFor(x => x.StreetAddress)
            .NotEmpty()
            .Length(5, 100)
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_StreetAddress_IsInvalid)]);

        RuleFor(x => x.Suburb)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_Suburb_IsInvalid)]);

        RuleFor(x => x.City)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_City_IsInvalid)]);

        RuleFor(x => x.Region)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_Region_IsInvalid)]);

        RuleFor(x => x.PostalCode)
            .NotEmpty()
            .Matches(@"^\d{4}$")
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_PostalCode_IsInvalid)]);

        RuleFor(x => x.Country)
            .NotEmpty()
            .Length(2, 50)
            .WithMessage(localizer[nameof(SharedStrings.ShipmentDto_Country_IsInvalid)]);
    }
}
