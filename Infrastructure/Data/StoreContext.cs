using API.Entities;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products {set;get;}
    }
}