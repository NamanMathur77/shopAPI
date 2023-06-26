using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShopServer.Models.Domain;

namespace ShopServer.Data
{
    public class ShopDbContext:DbContext
    {
        public ShopDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
