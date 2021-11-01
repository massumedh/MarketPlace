using MarketPlace.Domain.Services.DTOs.Seller;
using System;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Services.Interfaces
{
    public interface ISellerService : IAsyncDisposable
    {
        #region Seller
        Task<RequestSellerResult> AddNewSellerRequset(RequestSellerDTO seller, long userId);
        Task<FilterSellerDTO> FilterSellers(FilterSellerDTO filter);
        #endregion
    }
}
