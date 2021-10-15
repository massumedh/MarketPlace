using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Services.DTOs;
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
        public async ValueTask DisposeAsync()
        {
            await _userRepository.DisposeAsync();
        }

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
                return RegisterUserResult.Success;
            }
            return RegisterUserResult.MobileExists;
        }
    }
}
