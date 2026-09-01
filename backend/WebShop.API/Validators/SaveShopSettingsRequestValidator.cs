using WebShop.API.DTOs.Settings;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class SaveShopSettingsRequestValidator : AbstractValidator<SaveShopSettingsRequest>
{
    public SaveShopSettingsRequestValidator()
    {
        RuleFor(x => x.UkrposhtaFreeFromAmount)
            .GreaterThan(0)
            .WithMessage("Сума безкоштовної доставки має бути більшою за нуль.")
            .LessThanOrEqualTo(1_000_000)
            .WithMessage("Сума безкоштовної доставки занадто велика.");
    }
}
