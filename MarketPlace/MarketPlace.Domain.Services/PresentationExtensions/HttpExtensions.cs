using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.PresentationExtensions
{
    public static class HttpExtensions
    {
       public static string GetUserIp(this HttpContext httpContext)
        {
            return httpContext.Connection.RemoteIpAddress.ToString();
        }   
    }
}
