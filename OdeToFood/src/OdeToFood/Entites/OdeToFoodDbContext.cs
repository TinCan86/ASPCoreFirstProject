using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Entites
{
    public class OdeToFoodDbContext : DbContext
    {

        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
