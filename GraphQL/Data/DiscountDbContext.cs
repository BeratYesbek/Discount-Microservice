using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class DiscountDbContext : DbContext
    {
        public DiscountDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Coupon>? Coupons { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(p => p.Coupons)
                .WithOne(p => p.Category)
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<Coupon>()
                .HasOne(t => t.Category)
                .WithMany(p => p.Coupons)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}
