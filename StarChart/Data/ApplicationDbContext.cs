using Microsoft.EntityFrameworkCore;

namespace StarChart.Data
{
    using Models;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
