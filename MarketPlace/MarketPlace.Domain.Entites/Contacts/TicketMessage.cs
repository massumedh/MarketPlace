using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Common;
using System.ComponentModel.DataAnnotations;
namespace MarketPlace.Domain.Entites.Contacts
{
    public class TicketMessage : BaseEntity
    {
        #region properties

        public long TicketId { get; set; }
        public long SenderId { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }
        #endregion

        #region relation
        public Ticket Ticket { get; set; }
        public User Sender { get; set; }
        #endregion
    }
}
