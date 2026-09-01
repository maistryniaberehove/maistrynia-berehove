using WebShop.API.DTOs.Orders;
using WebShop.API.Models;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class UpdateOrderStatusRequestValidator : AbstractValidator<UpdateOrderStatusRequest>
{
    public UpdateOrderStatusRequestValidator()
    {
        RuleFor(x => x.Status)
            .NotEmpty()
            .Must(status => Enum.TryParse<OrderStatus>(status, true, out _))
            .WithMessage("Вкажіть коректний статус замовлення.");
    }
}
