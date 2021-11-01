using System;
namespace MarketPlace.Domain.Services.DTOs.Paging
{
    public class Pager
    {
        public static BasePaging Build(int currentPage, int totalItems, int itemPerPage, int howManyShowPageAfterAndBefore)
        {
            var totalPages = Convert.ToInt32(Math.Ceiling(totalItems / (double)itemPerPage));
            return new BasePaging
            {
                CurrentPage = currentPage,
                TotalItems = totalItems,
                ItemPerPage = itemPerPage,
                SkipEntity = (currentPage - 1) * itemPerPage,
                StartPage = currentPage - howManyShowPageAfterAndBefore <= 0 ? 1 : currentPage - howManyShowPageAfterAndBefore,
                EndPage = currentPage + howManyShowPageAfterAndBefore > totalPages ? totalPages : currentPage + howManyShowPageAfterAndBefore,
                HowManyShowPageAfterAndBefore = howManyShowPageAfterAndBefore,
                TotalPages = totalPages

            };
        }
    }
}
