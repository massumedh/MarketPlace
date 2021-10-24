using MarketPlace.Domain.Entites.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
   public interface ISiteService : IAsyncDisposable
    {
        #region site setting
        Task<SiteSetting> GetDefaultSiteSetting();
        #endregion

        #region slider
        Task<List<Slider>> GetAllActiveSlider();
        #endregion
    }
}
