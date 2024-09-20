
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)//connection string
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
