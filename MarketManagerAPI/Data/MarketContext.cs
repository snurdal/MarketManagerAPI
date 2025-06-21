using Microsoft.EntityFrameworkCore;
using MarketManagerAPI.Models;

namespace MarketManagerAPI.Data
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
    }

}