using MarketPlace.Domain.Entites.Account;
namespace MarketPlace.Domain.Services.EntitesExtensions
{
    public static class UserExtension
    {
        public static string GetUserShowName(this User user)
        {
            if (!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName))
            {
                return $"{user.FirstName} {user.LastName}";
            }
            return user.Mobile;
        }
    }
}
