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
        public ContactService(IGenericRepository<ContactUs> contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
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
