using MarketPlace.Domain.Entites.Contacts;
using MarketPlace.Domain.Services.DTOs.Contacts;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
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
