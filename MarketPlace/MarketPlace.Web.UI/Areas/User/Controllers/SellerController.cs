using MarketPlace.Domain.Entites.Store;
using MarketPlace.Domain.Services.DTOs.Seller;
using MarketPlace.Domain.Services.PresentationExtensions;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Areas.User.Controllers
{
    public class SellerController : UserBaseController
    {
        #region constructor
        private readonly ISellerService _sellerService;
        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }
        #endregion

        #region request seller
        [HttpGet("requset-seller-panel")]
        public IActionResult RequsetSellerPanel()
        {
            return View();
        }
        [HttpPost("requset-seller-panel"),ValidateAntiForgeryToken]
        public async Task<IActionResult> RequsetSellerPanel(RequestSellerDTO seller)
        {
            if (ModelState.IsValid)
            {
                var result = await _sellerService.AddNewSellerRequset(seller, User.GetUserId());
                switch (result)
                {
                    case RequestSellerResult.HasNotPermission:
                        TempData[ErrorMessage] = "شما دسترسی لازم جهت انجام فرایند مورد نظر را ندارید";
                        break;
                    case RequestSellerResult.HasUnderProgressRequest:
                        TempData[WarningMessage] = "درخواست های قبلی شما در حال پیگیری می باشند";
                        TempData[InfoMessage] = "در حال حاضر نمی توانید درخواست جدیدی ثبت کنید";
                        break;
                    case RequestSellerResult.Success:
                        TempData[SuccessMessage] = "درخواست شما با موفقیت ثبت شد";
                        TempData[InfoMessage] = "فرایند اطلاعات شما در حال پیگیری است";
                        return RedirectToAction("SellerRequests");
                
                }
            }
            
            return View(seller);
        }

        #endregion

        #region seller requests
        [HttpGet("seller-requests")]
        public async Task<IActionResult> SellerRequests(FilterSellerDTO filter)
        {
            filter.ItemPerPage = 5;
            filter.userId = User.GetUserId();
            filter.State = FilterSellerState.All;
            return View(await _sellerService.FilterSellers(filter));
        }
        #endregion
    }
}
