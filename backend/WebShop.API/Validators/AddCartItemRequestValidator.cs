using WebShop.API.Constants;
using WebShop.API.DTOs.Cart;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class AddCartItemRequestValidator : AbstractValidator<AddCartItemRequest>
{
    public AddCartItemRequestValidator()
    {
        RuleFor(x => x.VariantId)
            .GreaterThan(0)
            .WithMessage("Ідентифікатор фасування є обов'язковим.");

        RuleFor(x => x.Quantity)
            .Must(q => q is null or (>= 1 and <= CartLimits.MaxLineQuantity))
            .WithMessage($"Кількість має бути від 1 до {CartLimits.MaxLineQuantity}.");
    }
}
