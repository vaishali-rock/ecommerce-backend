using ECommerce.Models;
using ECommerce.Persistence.DBModels;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence.DBService
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        public DbSet<DBUserProfile> UserProfile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBUserProfile>().ToTable("UserProfile");
        }
    }
}
