using Microsoft.EntityFrameworkCore;

namespace SyncfusionBlazorApp1.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
