using legos_api.Legos.Model1;
using Microsoft.EntityFrameworkCore;

namespace legos_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Lego> Legos { get; set; }
    }
}
