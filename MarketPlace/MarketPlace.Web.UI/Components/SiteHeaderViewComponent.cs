using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Components
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        #region constructor
        private readonly ISiteService _siteService;

        public SiteHeaderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        } 
        #endregion
        public async Task<IViewComponentResult> InvokeAsync()
        {
           ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();
            return View("SiteHeader");
        }
    }
}
