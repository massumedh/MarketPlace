using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MarketPlace.Domain.Entites.Contacts
{
    public class Ticket : BaseEntity
    {
        #region properties
        public long OwnerId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "بخش مورد نظر")]
        public TicketSection  TicketSection{ get; set; }

        [Display(Name = "اولویت")]
        public TicketPriority TicketPriority { get; set; }

        [Display(Name = "وضعیت تیکت")]
        public TicketState TicketState { get; set; }

        public bool IsReadByOwner { get; set; }

        public bool IsReadByAdmin { get; set; }
        #endregion

        #region relation
        public User Owner { get; set; }
        public ICollection<TicketMessage> TicketMessages { get; set; }

        #endregion

    }
    #region enum
    public enum TicketSection
    {
        [Display(Name = "پشتیبانی")]
        support,
        [Display(Name = "فنی")]
        Technical,
        [Display(Name = "آموزشی")]
        Academic
    }

    public enum TicketPriority
    {
        [Display(Name = "کم")]
        Low,
        [Display(Name = "متوسط")]
        Medium,
        [Display(Name = "زیاد")]
        High
    }

    public enum TicketState
    {
        [Display(Name = "در حال بررسی")]
        UnderProgress,
        [Display(Name = "پاسخ داده شده")]
        Answered,
        [Display(Name = "بسته شده")]
        Closed
    }
    #endregion

}
