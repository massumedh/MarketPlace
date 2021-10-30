using MarketPlace.Domain.Services.DTOs.Account;
using MarketPlace.Domain.Services.PresentationExtensions;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Areas.User.Controllers
{
    public class AccountController : UserBaseController
    {
        #region constructor
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion
        #region change password

        [HttpGet("change-password")]
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost("change-password"),ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO passwordDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ChangeUserPassword(passwordDTO, User.GetUserId());
                if (result)
                {
                    TempData[SuccessMessage] = "کلمه عبور شما تغییر یافت";
                    TempData[InfoMessage] = "لطفا جهت تکمیل فرایند تغییر کلمه عبور،مجددا وارد سایت شوید";
                    await HttpContext.SignOutAsync();
                    return RedirectToAction("Login", "Account", new { area = "" });
                }
                else
                {
                    TempData[ErrorMessage] = "لطفا از کلمه عبور جدید استفاده کنید";
                }
            }
            return View(passwordDTO);
        }
        #endregion
    }
}
