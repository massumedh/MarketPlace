using MarketPlace.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services.Repository.Interfaces
{
   public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetQuery();
        Task AddEntity(TEntity entity);
        Task<TEntity> GetEntityById(long entityId);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntity(long entityId);
        void DeletePermanent(TEntity entity);
        Task DeletePermanent(long entityId);
        Task SaveChanges();


    }
}
