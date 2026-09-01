using WebShop.API.DTOs;
using WebShop.API.DTOs.Settings;
using WebShop.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.API.Controllers;

[ApiController]
[Route("api/settings")]
[Produces("application/json")]
public sealed class SettingsController : ControllerBase
{
    private readonly IShopSettingsService _settings;

    public SettingsController(IShopSettingsService settings)
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
}
