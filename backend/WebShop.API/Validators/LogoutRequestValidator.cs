using WebShop.API.DTOs.Auth;
using FluentValidation;

namespace WebShop.API.Validators;

public sealed class LogoutRequestValidator : AbstractValidator<LogoutRequest>
{
    public LogoutRequestValidator()
    {
        RuleFor(x => x.RefreshToken)
            .NotEmpty().WithMessage("Refresh token є обов'язковим.");
    }
}
