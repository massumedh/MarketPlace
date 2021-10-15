using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
  public interface IPasswordHelper
    {
        string EncodePasswordMd5(string pass);
    }
}
