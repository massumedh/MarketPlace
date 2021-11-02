﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace MarketPlace.Web.UI.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        protected string SuccessMessage = "SuccessMessage";
        protected string WarningMessage = "WarningMessage";
        protected string InfoMessage = "InfoMessage";
        protected string ErrorMessage = "ErrorMessage";
    }
}
