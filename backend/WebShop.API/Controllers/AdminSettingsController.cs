using WebShop.API.DTOs;
using WebShop.API.DTOs.Settings;
using WebShop.API.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.API.Controllers;

[ApiController]
[Route("api/admin/settings")]
[Authorize(Roles = "Admin")]
[Produces("application/json")]
public sealed class AdminSettingsController : ControllerBase
{
    private readonly IShopSettingsService _settings;

    public AdminSettingsController(IShopSettingsService settings)
    {
        _settings = settings;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ApiResponse<ShopSettingsDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<ApiResponse<ShopSettingsDto>>> Get(CancellationToken cancellationToken)
    {
        var data = await _settings.GetAsync(cancellationToken);
        return Ok(ApiResponse<ShopSettingsDto>.Ok(data));
    }

    [HttpPut]
    [ProducesResponseType(typeof(ApiResponse<ShopSettingsDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse<object>), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ApiResponse<ShopSettingsDto>>> Update(
        [FromBody] SaveShopSettingsRequest request,
        [FromServices] IValidator<SaveShopSettingsRequest> validator,
        CancellationToken cancellationToken)
    {
        await validator.ValidateAndThrowAsync(request, cancellationToken);
        var data = await _settings.UpdateAsync(request, cancellationToken);
        return Ok(ApiResponse<ShopSettingsDto>.Ok(data));
    }
}
