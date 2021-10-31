using MarketPlace.Domain.Entites.Account;
using MarketPlace.Domain.Entites.Contacts;
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
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Slider> Sliders{ get; set; }
        public DbSet<SiteBanner> SiteBanners  { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketMessage> TicketMessages { get; set; }
        #endregion
        #region on model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relation in modelBuilder.Model.GetEntityTypes().SelectMany(a => a.GetForeignKeys()))
            {
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        } 
        #endregion
    }
}
