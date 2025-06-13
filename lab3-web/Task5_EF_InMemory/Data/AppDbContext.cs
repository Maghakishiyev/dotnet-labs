using Microsoft.EntityFrameworkCore;
using Task5_EF_InMemory.Models;

namespace Task5_EF_InMemory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}