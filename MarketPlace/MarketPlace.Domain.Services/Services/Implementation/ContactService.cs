using MarketPlace.Domain.Entites.Contacts;
using MarketPlace.Domain.Services.DTOs.Contacts;
using MarketPlace.Domain.Services.DTOs.Paging;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Implementation
{
    public class ContactService : IContactService
    {
        #region constructor
        private readonly IGenericRepository<ContactUs> _contactUsRepository;
        private readonly IGenericRepository<Ticket> _ticketRepository;
        private readonly IGenericRepository<TicketMessage> _ticketMessageRepository;

        public ContactService
            (
            IGenericRepository<ContactUs> contactUsRepository,
            IGenericRepository<Ticket> ticketRepository,
            IGenericRepository<TicketMessage> ticketMessageRepository

            )
        {
            _contactUsRepository = contactUsRepository;
            _ticketRepository = ticketRepository;
            _ticketMessageRepository = ticketMessageRepository;
        }

        #endregion

        #region ticket
        public async Task<AddTicketResult> AddUserTicket(AddTicketDTO ticket,long userId)
        {
            if (string.IsNullOrEmpty(ticket.Text)) return AddTicketResult.Error;
            //add ticket
            var newTicket = new Ticket
            {
                OwnerId = userId,
                IsReadByOwner = true,
                TicketPriority = ticket.TicketPriority,
                Title = ticket.Title,
                TicketSection = ticket.TicketSection,
                TicketState = TicketState.UnderProgress,
            };
            await _ticketRepository.AddEntity(newTicket);
            await _ticketRepository.SaveChanges();
            //add ticketMessage
            var newMessage = new TicketMessage
            {
                TicketId=newTicket.ID,
                Text=ticket.Text,
                SenderId=userId,
            };
            await _ticketMessageRepository.AddEntity(newMessage);
            await _ticketMessageRepository.SaveChanges();
            return AddTicketResult.Success;
        }


        public async Task<FilterTicketDTO> FilterTickets(FilterTicketDTO filter)
        {
            var query = _ticketRepository.GetQuery().AsQueryable();
            #region state
            switch (filter.FilterTicketState)
            {
                case FilterTicketState.All:
                    break;
                case FilterTicketState.NotDeleted:
                    query = query.Where(a => !a.IsDelete);
                    break;
                case FilterTicketState.Deleted:
                    query = query.Where(a => a.IsDelete);
                    break;
            }
            switch (filter.OrderBy)
            {
                case FilterTicketOrder.CreateDate_DES:
                    query = query.OrderByDescending(a => a.CreateDate);
                    break;
                case FilterTicketOrder.CreateDate_ASC:
                    query = query.OrderBy(a => a.CreateDate);
                    break;          
            }
            #endregion

            #region filter
            if (filter.TicketPriority != null)
                query = query.Where(a => a.TicketPriority == filter.TicketPriority.Value);

            if (filter.TicketSection != null)
                query = query.Where(a => a.TicketSection == filter.TicketSection.Value);

            if (filter.UserId != null && filter.UserId != 0)
                query = query.Where(a => a.OwnerId == filter.UserId.Value);

            if (!string.IsNullOrEmpty(filter.Title))
                query = query.Where(a => EF.Functions.Like(a.Title, $"%{filter.Title}%"));
            #endregion

            #region paging
            var ticketCount = await query.CountAsync();
            var pager = Pager.Build(filter.CurrentPage, ticketCount, filter.ItemPerPage, filter.HowManyShowPageAfterAndBefore);
            var allEntites = await query.Paging(pager).ToListAsync();
            #endregion
            return filter.SetPaging(pager).SetTickets(allEntites);
            
        }
        public async Task<TicketDetailDTO> GetTicketForShow(long ticketId, long userId)
        {
            var ticket = await _ticketRepository.GetQuery().AsQueryable().
                 Include(a => a.Owner).SingleOrDefaultAsync(a => a.ID == userId);
            if (ticket == null || ticket.OwnerId != userId) return null;
            return new TicketDetailDTO
            {
                Ticket = ticket,
                TicketMessages = await _ticketMessageRepository.GetQuery().AsQueryable().
                OrderByDescending(a=>a.CreateDate).
                Where(a => a.TicketId == ticketId && !a.IsDelete).ToListAsync()

            };
        }
        #endregion

        #region contact us
        public async Task CreateContactUs(CreateContactUsDTO contact, string userIp, long? userId)
        {
            var newContact = new ContactUs
            {
                UserId = userId != null && userId.Value != 0 ? userId.Value : (long?) null,
                UserIp = userIp,
                Subject = contact.Subject,
                Email = contact.Email,
                Text = contact.Text,
                FullName = contact.FullName,
            };
            await _contactUsRepository.AddEntity(newContact);
            await _contactUsRepository.SaveChanges();
        }
        #endregion

        #region dispose
        public async ValueTask DisposeAsync()
        {
            await _contactUsRepository.DisposeAsync();
        }

      
        #endregion

    }
}
