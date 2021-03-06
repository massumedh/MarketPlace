using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Services.DTOs;
using MarketPlace.Domain.Services.DTOs.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
    public interface IUserService : IAsyncDisposable
    {
        Task<RegisterUserResult> RegisterUser(RegisterUserDTO register);
        Task<bool> IsUserExistsByMobile(string mobile);
        Task<LoginUserResult> GetUserForLogin(LoginUserDTO login);
        Task<User> GetUserByMobile(string mobile);
        Task<ForgotPasswordResult> RecoverUserPassword(ForgotPasswordDTO forgot);
        Task<bool> ChangeUserPassword(ChangePasswordDTO changePassword,long currentUserId);
        Task<EditUserProfileDTO> GetProfileForEdit(long userId);
        Task<EditProfileUserResult> EditUserProfile(EditUserProfileDTO profile,long userId,IFormFile avatarImage);
    }
}
