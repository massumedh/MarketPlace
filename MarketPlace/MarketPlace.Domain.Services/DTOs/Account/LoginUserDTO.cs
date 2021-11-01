using MarketPlace.Domain.Services.DTOs.Site;
using System.ComponentModel.DataAnnotations;
namespace MarketPlace.Domain.Services.DTOs.Account
{
    public class LoginUserDTO : CaptchaDTO
    {
        #region properties
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }

        [Display(Name = "کلمه ی عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        public bool RememberMe { get; set; } 
        #endregion
    }

    #region enum
    public enum LoginUserResult
    {
        Success,
        NotFound,
        NotActivated
    } 
    #endregion
}

