using MarketPlace.Domain.Services.DTOs.Contacts;
using MarketPlace.Domain.Services.PresentationExtensions;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Web.UI.Areas.User.Controllers
{
    public class TicketController : UserBaseController
    {
        #region constructor
        private readonly IContactService _contactService;
        public TicketController(IContactService contactService)
        {
            _contactService = contactService;
        }
        #endregion

        #region list
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region add ticket
        [HttpGet("add-ticket")]
        public async Task<IActionResult> AddTicket()
        {
            return View();
        }

        [HttpPost("add-ticket"),ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTicket(AddTicketDTO ticket)
        {
            if (ModelState.IsValid)
            {
                var result = await _contactService.AddUserTicket(ticket, User.GetUserId());
                switch (result)
                {
                    case AddTicketResult.Error:
                        TempData[ErrorMessage] = "عملیات با شکست مواجه شد";
                        break;
                    case AddTicketResult.Success:
                        TempData[SuccessMessage] = "تیکت شما با موفقیت ثبت شد";
                        TempData[InfoMessage] = "پاسخ شما به زودی ارسال خواهد شد";
                        return RedirectToAction("Index");                   
                }
            }
            return View(ticket);
        }
        #endregion
    }
}
