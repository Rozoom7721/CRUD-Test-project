using Microsoft.EntityFrameworkCore;
using StoreProject.Models;

namespace StoreProject.Services
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options)
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
