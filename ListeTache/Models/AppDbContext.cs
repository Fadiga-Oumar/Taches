using Microsoft.EntityFrameworkCore;

namespace ListeTache.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tache> Taches { get; set; }
    }

}
