using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Components
{
    public class HomeSliderViewComponent : ViewComponent
    {
        private readonly ISiteService _siteService;

        public HomeSliderViewComponent(ISiteService siteService)
        {
            _siteService = siteService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _siteService.GetAllActiveSlider();
            return View("HomeSlider",sliders);
        }
    }
}
