using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Components
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        #region constructor
        private readonly ISiteService _siteService;
        private readonly IUserService _userService;

        public SiteHeaderViewComponent(ISiteService siteService,IUserService userService)
        {
            _siteService = siteService;
            _userService = userService;
        } 
        #endregion
        public async Task<IViewComponentResult> InvokeAsync()
        {
           ViewBag.siteSetting = await _siteService.GetDefaultSiteSetting();
            ViewBag.user = null;
            if(User.Identity.IsAuthenticated)
            {
             ViewBag.user = await _userService.GetUserByMobile(User.Identity.Name); 
            }
            return View("SiteHeader");
        }
    }
}
