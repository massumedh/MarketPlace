using MarketPlace.Domain.Services.DTOs.Site;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.DTOs.Account
{
     public class ForgotPasswordDTO : CaptchaDTO
    {
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }
    }
    #region enum
    public enum ForgotPasswordResult
    {
        Success,
        NotFound,
        Error
    } 
    #endregion
}
