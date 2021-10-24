using GoogleReCaptcha.V3.Interface;
using MarketPlace.Domain.Entites.Site;
using MarketPlace.Domain.Services.DTOs.Contacts;
using MarketPlace.Domain.Services.PresentationExtensions;
using MarketPlace.Domain.Services.Services.Interfaces;
using MarketPlace.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region constructor
        private readonly IContactService _contactService;
        private readonly ICaptchaValidator _captchaValidator;
        private readonly ISiteService _siteService;

        public HomeController
            (
            IContactService contactService,
            ICaptchaValidator captchaValidator,
            ISiteService siteService
            )
        {
            _contactService = contactService;
            _captchaValidator = captchaValidator;
            _siteService = siteService;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            ViewBag.banners = await _siteService.GetSiteBannerByPlacement(new List<BannerPlacement>
            {
                BannerPlacement.Home_1,
                BannerPlacement.Home_2,
                BannerPlacement.Home_3
            });
            return View();
        }
        #endregion

        #region Contact Us
        [HttpGet("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost("contact-us"),ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUs(CreateContactUsDTO contact)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(contact.Captcha))
            {
                TempData[ErrorMessage] = "کد کپچای شما تایید نشد";
                return View(contact);
            }
            if (ModelState.IsValid)
            {
                await _contactService.CreateContactUs(contact, HttpContext.GetUserIp(), User.GetUserId());
                TempData[SuccessMessage] = "پیام شما با موفقیت ارسال شد";
                return RedirectToAction("ContactUs");
            }
            return View(contact);
        }
        #endregion

        #region about us
        [HttpGet("about-us")]
        public async Task<IActionResult> AboutUs()
        {
            var siteSetting = await _siteService.GetDefaultSiteSetting();
            return View(siteSetting);
        }
        #endregion

    }
}
