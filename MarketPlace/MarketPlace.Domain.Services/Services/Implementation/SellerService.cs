using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Store;
using MarketPlace.Domain.Services.DTOs.Paging;
using MarketPlace.Domain.Services.DTOs.Seller;
using MarketPlace.Domain.Services.Repository.Interfaces;
using MarketPlace.Domain.Services.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
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

            var hasUnderProgressRequest = await _sellerRepository.GetQuery().AsQueryable().AnyAsync(s =>
                s.UserId == userId && s.StoreAcceptanceState == StoreAcceptanceState.UnderProgress);

            if (hasUnderProgressRequest) return RequestSellerResult.HasUnderProgressRequest;

            var newSeller = new Seller
            {
                UserId = userId,
                StoreName = seller.StoreName,
                Address = seller.Address,
                Phone = seller.Phone,
                StoreAcceptanceState = StoreAcceptanceState.UnderProgress
            };

            await _sellerRepository.AddEntity(newSeller);
            await _sellerRepository.SaveChanges();

            return RequestSellerResult.Success;
        }
        public async Task<FilterSellerDTO> FilterSellers(FilterSellerDTO filter)
        {
            var query = _sellerRepository.GetQuery()
                .Include(s => s.User)
                .AsQueryable();

            #region state

            switch (filter.State)
            {
                case FilterSellerState.All:
                    query = query.Where(s => !s.IsDelete);
                    break;
                case FilterSellerState.Accepted:
                    query = query.Where(s => s.StoreAcceptanceState == StoreAcceptanceState.Accepted && !s.IsDelete);
                    break;

                case FilterSellerState.UnderProgress:
                    query = query.Where(s => s.StoreAcceptanceState == StoreAcceptanceState.UnderProgress && !s.IsDelete);
                    break;
                case FilterSellerState.Rejected:
                    query = query.Where(s => s.StoreAcceptanceState == StoreAcceptanceState.Rejected && !s.IsDelete);
                    break;
            }

            #endregion

            #region filter

            if (filter.userId != null && filter.userId != 0)
                query = query.Where(s => s.UserId == filter.userId);

            if (!string.IsNullOrEmpty(filter.StoreName))
                query = query.Where(s => EF.Functions.Like(s.StoreName, $"%{filter.StoreName}%"));

            if (!string.IsNullOrEmpty(filter.Phone))
                query = query.Where(s => EF.Functions.Like(s.Phone, $"%{filter.Phone}%"));   

            if (!string.IsNullOrEmpty(filter.Address))
                query = query.Where(s => EF.Functions.Like(s.Address, $"%{filter.Address}%"));

            #endregion

            #region paging

            var pager = Pager.Build(filter.CurrentPage, await query.CountAsync(), filter.ItemPerPage, filter.HowManyShowPageAfterAndBefore);
            var allEntities = await query.Paging(pager).ToListAsync();

            #endregion

            return filter.SetPaging(pager).SetSellers(allEntities);
        }

        public async Task<EditRequestSellerDTO> GetRequestSellerForEdit(long id, long currentUserId)
        {
            var seller = await _sellerRepository.GetEntityById(id);
            if (seller == null || seller.UserId != currentUserId) return null;

            return new EditRequestSellerDTO
            {
                Id = seller.ID,
                Phone = seller.Phone,
                Address = seller.Address,
                StoreName = seller.StoreName
            };
        }

        public async Task<EditRequestSellerResult> EditRequestSeller(EditRequestSellerDTO request, long currentUserId)
        {
            var seller = await _sellerRepository.GetEntityById(request.Id);
            if (seller == null || seller.UserId != currentUserId) return EditRequestSellerResult.NotFound;

            seller.Phone = request.Phone;
            seller.Address = request.Address;
            seller.StoreName = request.StoreName;
            seller.StoreAcceptanceState = StoreAcceptanceState.UnderProgress;
            _sellerRepository.EditEntity(seller);
            await _sellerRepository.SaveChanges();

            return EditRequestSellerResult.Success;
        }

        public async Task<bool> AcceptSellerRequest(long requestId)
        {
            var sellerRequest = await _sellerRepository.GetEntityById(requestId);
            if (sellerRequest != null)
            {
                sellerRequest.StoreAcceptanceState = StoreAcceptanceState.Accepted;
                _sellerRepository.EditEntity(sellerRequest);
                await _sellerRepository.SaveChanges();
                return true;
            }
            return false;
        }


        #endregion


    }
}
