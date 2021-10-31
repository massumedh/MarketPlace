using MarketPlace.Domain.Services.DTOs.Contacts;
using System;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
    public interface IContactService : IAsyncDisposable
    {
        #region contact us
        Task CreateContactUs(CreateContactUsDTO contact, string userIp, long? userId);
        #endregion

        #region ticket
        Task<AddTicketResult> AddUserTicket(AddTicketDTO ticket,long userId);
        #endregion
    }
}
