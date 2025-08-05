using FluentValidation;
using Microsoft.Extensions.Localization;
using LearningCSharp.Domains.LogisticsDomain.Dtos.Resources;

namespace LearningCSharp.Domains.LogisticsDomain.Dtos.Validators;

/// <summary>
/// Validator for CarrierDto
/// </summary>
public class CarrierDtoValidator : AbstractValidator<CarrierDto>
{
    /// <summary>
    /// Initializes a new instance of the CarrierDtoValidator class
    /// </summary>
    /// <param name="localizer">String localizer for SharedStrings</param>
    public CarrierDtoValidator(IStringLocalizer<SharedStrings> localizer)
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(localizer[nameof(SharedStrings.CarrierDto_Id_IsInvalid)]);

        RuleFor(x => x.Name)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage(localizer[nameof(SharedStrings.CarrierDto_Name_IsInvalid)]);

        RuleFor(x => x.TelephoneNumber)
            .NotEmpty()
            .Matches(@"^(\+64|0)([2-9]\d{7,9}|\d{8,9})$")
            .WithMessage(localizer[nameof(SharedStrings.CarrierDto_TelephoneNumber_IsInvalid)]);
    }
}
