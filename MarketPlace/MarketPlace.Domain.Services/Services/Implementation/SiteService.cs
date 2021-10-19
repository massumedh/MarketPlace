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
        public SiteService(IGenericRepository<SiteSetting> siteSettingRepository )
        {
            _siteSettingRepository = siteSettingRepository;
        }
        #endregion
        #region dispose
        public async ValueTask DisposeAsync()
        {
            await _siteSettingRepository.DisposeAsync();
        }

        public async Task<SiteSetting> GetDefaultSiteSetting()
        {
            return await _siteSettingRepository.GetQuery().AsQueryable().
                SingleOrDefaultAsync(a => a.IsDefault && !a.IsDelete);
        }
        #endregion
    }
}
