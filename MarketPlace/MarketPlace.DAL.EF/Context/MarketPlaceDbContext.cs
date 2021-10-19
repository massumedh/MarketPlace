using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Site;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MarketPlace.DAL.EF.Context
{
    public class MarketPlaceDbContext : DbContext
    {
        public MarketPlaceDbContext(DbContextOptions<MarketPlaceDbContext> options) : base(options)
        {
        }
        #region dbset
        public DbSet<User> Users { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relation in modelBuilder.Model.GetEntityTypes().SelectMany(a=>a.GetForeignKeys()))
            {
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
