using MarketPlace.Domain.Services.DTOs.Seller;
using MarketPlace.Domain.Services.Services.Interfaces;
using MarketPlace.Web.UI.Areas.User.Controllers;
using MarketPlace.Web.UI.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Areas.Admin.Controllers
{
    public class SellerController : AdminBaseController
    {
        #region constructor
        private readonly ISellerService _sellerService;
        public SellerController(ISellerService sellerService )
        {
            _sellerService = sellerService;
        }
        #endregion

        #region seller requests
        public async Task<IActionResult> SellerRequests(FilterSellerDTO filter)
        {
          
            return View(await _sellerService.FilterSellers(filter));
        }
        #endregion

        #region accept seller request
        public async Task<IActionResult> AcceptSellerRequest(long requsetId)
        {
            var result = await _sellerService.AcceptSellerRequest(requsetId);
            if (result)
            {
                return JsonResponseStatus.SendStatus
                    (
                    JsonResponseStatusType.Success,
                    "درخواست مورد نظر با موفقیت تایید شد",
                    null
                    );
            }
            return JsonResponseStatus.SendStatus
                (
                JsonResponseStatusType.Danger,
                "اطلاعاتی با این مشخصات یافت نشد",
                null
                );
        }
        #endregion
    }
}
