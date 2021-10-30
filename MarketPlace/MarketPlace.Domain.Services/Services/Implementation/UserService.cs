using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Services.DTOs;
using MarketPlace.Domain.Services.DTOs.Account;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Implementation
{
    public class UserService : IUserService
    {

        #region constructor
        private readonly IGenericRepository<User> _userRepository;
        private readonly IPasswordHelper _passwordHelper;

        public UserService(IGenericRepository<User> userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }
        #endregion
        #region dispose
        public async ValueTask DisposeAsync()
        {
            await _userRepository.DisposeAsync();
        } 
        #endregion

        public async Task<bool> IsUserExistsByMobile(string mobile)
        {
            return await _userRepository.GetQuery().AsQueryable().AnyAsync(a => a.Mobile == mobile);
        }

        public async Task<RegisterUserResult> RegisterUser(RegisterUserDTO register)
        {
            if (!await IsUserExistsByMobile(register.Mobile))
            {
                var user = new User
                {
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    Mobile = register.Mobile,
                    Password=_passwordHelper.EncodePasswordMd5(register.Password),
                    MobileActiveCode=new Random().Next(10000,999999).ToString(),
                    EmailActiveCode=Guid.NewGuid().ToString("N")
                };
                await _userRepository.AddEntity(user);
                await _userRepository.SaveChanges();
                //todo : send activation mobile code to user
                return RegisterUserResult.Success;
            }
            return RegisterUserResult.MobileExists;
        }
        public async Task<LoginUserResult> GetUserForLogin(LoginUserDTO login)
        {
            var user = await _userRepository.GetQuery().AsQueryable().SingleOrDefaultAsync(a => a.Mobile == login.Mobile);
            if (user == null) return LoginUserResult.NotFound;
            if (!user.IsMobileActive) return LoginUserResult.NotActivated;
            if (user.Password != _passwordHelper.EncodePasswordMd5(login.Password)) return LoginUserResult.NotFound;
            return LoginUserResult.Success;
        }

        public async Task<User> GetUserByMobile(string mobile)
        {
            return await _userRepository.GetQuery().AsQueryable().SingleOrDefaultAsync(a => a.Mobile == mobile);
        }

        public async Task<ForgotPasswordResult> RecoverUserPassword(ForgotPasswordDTO forgot)
        {
            var user = await _userRepository.GetQuery().AsQueryable().SingleOrDefaultAsync(a => a.Mobile == forgot.Mobile);
            if (user == null) return ForgotPasswordResult.NotFound;
            var newPassword = new Random().Next(1000000, 999999999).ToString();
            user.Password = _passwordHelper.EncodePasswordMd5(newPassword);
            _userRepository.EditEntity(user);
            //todo : send new password to user with sms
            await _userRepository.SaveChanges();
            return ForgotPasswordResult.Success;
        }

        public async Task<bool> ChangeUserPassword(ChangePasswordDTO changePassword,long currentUserId)
        {
            var user = await _userRepository.GetEntityById(currentUserId);
            if (user != null)
            {
                var newpassword = _passwordHelper.EncodePasswordMd5(changePassword.NewPassword);
                if (newpassword != user.Password)
                {
                    user.Password = newpassword;
                    _userRepository.EditEntity(user);
                    await _userRepository.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public async Task<EditUserProfileDTO> GetProfileForEdit(long userId)
        {
            var user = await _userRepository.GetEntityById(userId);
            if (user == null) return null;
            return new EditUserProfileDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Avatar=user.Avatar
            };
        }

        public async Task<EditProfileUserResult> EditUserProfile(EditUserProfileDTO profile,long userId)
        {
            var user = await _userRepository.GetEntityById(userId);
            if (user == null) return EditProfileUserResult.NotFound;
            if (user.IsBlocked) return EditProfileUserResult.IsBlocked;
            if (!user.IsMobileActive) return EditProfileUserResult.IsNotActive;
            user.FirstName = profile.FirstName;
            user.LastName = profile.LastName;
            _userRepository.EditEntity(user);
            await _userRepository.SaveChanges();
            return EditProfileUserResult.Success;

        }
    }
}
