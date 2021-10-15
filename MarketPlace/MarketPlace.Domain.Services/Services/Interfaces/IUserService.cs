using MarketPlace.Domain.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
   public interface IUserService : IAsyncDisposable
    {
        Task<RegisterUserResult> RegisterUser(RegisterUserDTO register);
        Task<bool> IsUserExistsByMobile(string mobile);
    }
}
