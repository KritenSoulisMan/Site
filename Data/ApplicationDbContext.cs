using System.Data.Entity;

namespace Type_D.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Настройка схемы базы данных
            base.OnModelCreating(modelBuilder);

            // Примеры настройки моделей
            modelBuilder.Entity<Service>().ToTable("Services");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
            modelBuilder.Entity<UserProfile>().ToTable("UserProfiles");
        }
    }
}
