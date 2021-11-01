using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketPlace.Domain.Services.DTOs.Paging;
namespace MarketPlace.Domain.Services.DTOs.Seller
{
    public class FilterSellerDTO : BasePaging
    {
        #region properties
        public long? userId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public FilterSellerState State { get; set; }
        public List<MarketPlace.Domain.Entites.Store.Seller> Sellers { get; set; }
        #endregion


        #region methods
        public FilterSellerDTO SetSellers(List<MarketPlace.Domain.Entites.Store.Seller> sellers)
        {
            this.Sellers = sellers;
            return this;
        }

        public FilterSellerDTO SetPaging(BasePaging paging)
        {
            this.CurrentPage = paging.CurrentPage;
            this.TotalItems = paging.TotalItems;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyShowPageAfterAndBefore = paging.HowManyShowPageAfterAndBefore;
            this.ItemPerPage = paging.ItemPerPage;
            this.SkipEntity = paging.SkipEntity;
            this.TotalPages = paging.TotalPages;
            return this;
        }
        #endregion
    }
    #region enum
    public enum FilterSellerState
    {
        [Display(Name ="همه")]
        All,
        [Display(Name ="در حال بررسی")]
        UnderProgress,
        [Display(Name ="تایید شده")]
        Accepted,
        [Display(Name ="رد شده")]
        Rejected
    }
    #endregion
}
   
