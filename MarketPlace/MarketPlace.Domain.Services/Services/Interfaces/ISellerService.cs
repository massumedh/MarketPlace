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
        Task<EditRequestSellerDTO> GetRequestSellerForEdit(long Id,long currentUserId);
        Task<EditRequestSellerResult> EditRequestSeller(EditRequestSellerDTO request,long currentUserId);
        #endregion
    }
}
