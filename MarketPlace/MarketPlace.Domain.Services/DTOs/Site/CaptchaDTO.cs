using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Domain.Services.DTOs.Site
{
    public class CaptchaDTO
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Captcha { get; set; }
    }
}
