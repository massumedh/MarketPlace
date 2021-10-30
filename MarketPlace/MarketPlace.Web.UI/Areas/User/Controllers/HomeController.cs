using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        #region user dashboard

        [HttpGet("")]
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }
        #endregion
    }
}
