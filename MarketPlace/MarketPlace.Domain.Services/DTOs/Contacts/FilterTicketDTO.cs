using MarketPlace.Domain.Entites.Contacts;
using MarketPlace.Domain.Services.DTOs.Paging;
using System.Collections.Generic;
namespace MarketPlace.Domain.Services.DTOs.Contacts
{
    public class FilterTicketDTO : BasePaging
    {
        #region properties
        public string Title { get; set; }
        public long? UserId { get; set; }
        public FilterTicketState FilterTicketState { get; set; }
        public TicketSection? TicketSection { get; set; }
        public TicketPriority? TicketPriority { get; set; }
        public FilterTicketOrder OrderBy { get; set; }
        public List<Ticket> Tickets { get; set; }
        #endregion

        #region method
        public FilterTicketDTO SetTickets(List<Ticket> tickets)
        {
            this.Tickets = tickets;
            return this;
        }

        public FilterTicketDTO SetPaging(BasePaging paging)
        {
            this.CurrentPage = paging.CurrentPage;
            this.TotalItems = paging.TotalItems;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.ItemPerPage = paging.ItemPerPage;
            this.SkipEntity = paging.SkipEntity;
            this.TotalPages = paging.TotalPages;
            return this;
        }
        #endregion
    }

    #region enum
    public enum FilterTicketState
    {
        All,
        NotDeleted,
        Deleted
    }

    public enum FilterTicketOrder
    {
        CreateDate_DES,
        CreateDate_ASC,
    }
    #endregion
}
