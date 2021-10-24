using MarketPlace.Domain.Services.DTOs.Contacts;
using System;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
    public interface IContactService : IAsyncDisposable
    {
        Task CreateContactUs(CreateContactUsDTO contact,string userIp,long? userId);
    }
}
