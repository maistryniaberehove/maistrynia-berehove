using WebShop.API.DTOs.Auth;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class RefreshRequestValidator : AbstractValidator<RefreshRequest>
{
    public RefreshRequestValidator()
    {
        RuleFor(x => x.RefreshToken)
            .NotEmpty().WithMessage("Refresh token є обов'язковим.");
    }
}
