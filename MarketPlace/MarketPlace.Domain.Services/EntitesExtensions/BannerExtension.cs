using MarketPlace.Domain.Entites.Site;
using MarketPlace.Domain.Services.Utils;

namespace MarketPlace.Domain.Services.EntitesExtensions
{
    public static class BannerExtension
    {
        public static string GetBannerMainImageAddress(this SiteBanner banner)
        {
            return PathExtension.BannerOrigin + banner.ImageName;
        }
    }
}
