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
      
        public IActionResult Index()
        {
            return View();
        }

    }
}
