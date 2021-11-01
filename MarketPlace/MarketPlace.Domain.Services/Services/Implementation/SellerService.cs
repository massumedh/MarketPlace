using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Store;
using MarketPlace.Domain.Services.DTOs.Paging;
using MarketPlace.Domain.Services.DTOs.Seller;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace MarketPlace.Domain.Services.Services.Implementation
{
    public class SellerService : ISellerService
    {
        #region constructor
        private readonly IGenericRepository<Seller> _sellerRepository;
        private readonly IGenericRepository<User> _userRepository;

        public SellerService(IGenericRepository<Seller> sellerRepository,IGenericRepository<User> userRepository)
        {
            _sellerRepository = sellerRepository;
            _userRepository = userRepository;
        }
        #endregion

        #region dispose
        public async ValueTask DisposeAsync()
        {
            await _sellerRepository.DisposeAsync();
        }
        #endregion

        #region seller
        public async Task<RequestSellerResult> AddNewSellerRequset(RequestSellerDTO seller, long userId)
        {
            var user = await _userRepository.GetEntityById(userId);
            if (user.IsBlocked) return RequestSellerResult.HasNotPermission;

            var hasUnderProgressRequset = await _sellerRepository.GetQuery().AsQueryable().
                AnyAsync(a => a.UserId == userId && a.StoreAcceptanceState == StoreAcceptanceState.UnderProgress);
            if (hasUnderProgressRequset) return RequestSellerResult.HasUnderProgressRequest;

            var newSeller = new Seller
            {
                UserId = userId,
                StoreName = seller.StoreName,
                Phone = seller.Phone,
                Address = seller.Address,
                StoreAcceptanceState = StoreAcceptanceState.UnderProgress,
            };
            await _sellerRepository.AddEntity(newSeller);
            await _sellerRepository.SaveChanges();
            return RequestSellerResult.Success;
        }

        public async Task<FilterSellerDTO> FilterSellers(FilterSellerDTO filter)
        {
            var query = _sellerRepository.GetQuery().Include(a => a.User).AsQueryable();
            #region state
            switch (filter.State)
            {
                case FilterSellerState.All:
                    query = query.Where(a => !a.IsDelete);
                    break;
                case FilterSellerState.UnderProgress:
                    query = query.Where(a => a.StoreAcceptanceState == StoreAcceptanceState.UnderProgress && !a.IsDelete);
                    break;
                case FilterSellerState.Accepted:
                    query = query.Where(a => a.StoreAcceptanceState == StoreAcceptanceState.Accepted && !a.IsDelete);
                    break;
                case FilterSellerState.Rejected:
                    query = query.Where(a => a.StoreAcceptanceState == StoreAcceptanceState.Rejected && !a.IsDelete);
                    break;              
            }
            #endregion

            #region filter
            if (filter.userId != null && filter.userId != 0)
                query = query.Where(a => a.ID == filter.userId);

            if (!string.IsNullOrEmpty(filter.StoreName))
                query = query.Where(a => EF.Functions.Like(a.StoreName, $"%{filter.StoreName}%"));

            if (!string.IsNullOrEmpty(filter.Phone))
                query = query.Where(a => EF.Functions.Like(a.Phone, $"%{filter.Phone}%"));

            if (!string.IsNullOrEmpty(filter.Mobile))
                query = query.Where(a => EF.Functions.Like(a.Mobile,$"%{filter.Mobile}%"));

            if (!string.IsNullOrEmpty(filter.Address))
                query = query.Where(a => EF.Functions.Like(a.Address, $"%{filter.Address}%"));
            #endregion

            #region paging
            var ticketCount = await query.CountAsync();
            var pager = Pager.Build(filter.CurrentPage, ticketCount, filter.ItemPerPage, filter.HowManyShowPageAfterAndBefore);
            var allEntites = await query.Paging(pager).ToListAsync();
            #endregion

            return filter.SetPaging(pager).SetSellers(allEntites);
        }
        #endregion

    }
}
