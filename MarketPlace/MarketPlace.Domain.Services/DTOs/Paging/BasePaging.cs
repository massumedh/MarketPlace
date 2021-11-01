namespace MarketPlace.Domain.Services.DTOs.Paging
{
    public class BasePaging
    {
        #region constructor
        public BasePaging()
        {
            CurrentPage = 1;
            ItemPerPage = 10;
            HowManyShowPageAfterAndBefore = 3;
        }
        #endregion

        #region properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int ItemPerPage { get; set; }
        public int SkipEntity { get; set; }
        public int HowManyShowPageAfterAndBefore { get; set; } 
        #endregion
    }
}
