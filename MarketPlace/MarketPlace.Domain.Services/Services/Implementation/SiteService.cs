using MarketPlace.Domain.Entites.Site;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Implementation
{
    public class SiteService : ISiteService
    {
        #region constructor
        private readonly IGenericRepository<SiteSetting> _siteSettingRepository;
        private readonly IGenericRepository<Slider> _sliderRepository;
        private readonly IGenericRepository<SiteBanner> _bannerRepository;

        public SiteService
            (
            IGenericRepository<SiteSetting> siteSettingRepository,
            IGenericRepository<Slider> sliderRepository,
            IGenericRepository<SiteBanner> bannerRepository
            )
        {
            _siteSettingRepository = siteSettingRepository;
            _sliderRepository = sliderRepository;
            _bannerRepository = bannerRepository;
        }
        #endregion
        #region dispose
        public async ValueTask DisposeAsync()
        {
            if (_siteSettingRepository != null) await _siteSettingRepository.DisposeAsync();
            if (_sliderRepository != null) await _sliderRepository.DisposeAsync();
            if (_bannerRepository != null) await _bannerRepository.DisposeAsync();
        }

        #endregion
        #region sitesetting
        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteSettingRepository.GetQuery().AsQueryable().
                SingleOrDefaultAsync(a => a.IsDefault && !a.IsDelete);
        }
        #endregion
        #region slider
        public async Task<List<Slider>> GetAllActiveSlider()
        {
            return await _sliderRepository.GetQuery().AsQueryable().
                Where(a => a.IsActive && !a.IsDelete).ToListAsync();
        }
        #endregion

        #region site banner
        public async Task<List<SiteBanner>> GetSiteBannerByPlacement(List<BannerPlacement> placements)
        {
            return await _bannerRepository.GetQuery().AsQueryable().
                Where(a=>placements.Contains(a.BannerPlacement)).ToListAsync();
        }
        #endregion

    }
}
