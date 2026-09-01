using WebShop.API.DTOs.Settings;

namespace WebShop.API.Services;

public interface IShopSettingsService
{
    Task<ShopSettingsDto> GetAsync(CancellationToken cancellationToken);
    Task<ShopSettingsDto> UpdateAsync(SaveShopSettingsRequest request, CancellationToken cancellationToken);
}
