using meal_sharing_entityframework;
using Microsoft.EntityFrameworkCore;


namespace meal_sharing_entityframework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            
            public DbSet<Meal> Meals { get; set; }
            public DbSet<Reservation> Reservations { get; set; }
            public DbSet<Review> Reviews { get; set; }
        
    }
}

