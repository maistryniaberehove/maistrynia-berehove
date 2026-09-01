using WebShop.API.Constants;
using WebShop.API.DTOs.Cart;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class UpdateCartItemRequestValidator : AbstractValidator<UpdateCartItemRequest>
{
    public UpdateCartItemRequestValidator()
    {
        RuleFor(x => x.Quantity)
            .InclusiveBetween(1, CartLimits.MaxLineQuantity)
            .WithMessage($"Кількість має бути від 1 до {CartLimits.MaxLineQuantity}.");
    }
}
