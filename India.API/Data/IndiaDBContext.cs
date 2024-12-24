using India.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace India.API.Data
{
    public class IndiaDBContext : DbContext
    {
        public IndiaDBContext(DbContextOptions<IndiaDBContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship between State and City (not needed for 1:1 but for 1:n, n:1 or m:n )
            modelBuilder.Entity<City>()
                .HasOne(c => c.State) // A City has one State
                .WithMany(s => s.Cities) // A State has many Cities
                .HasForeignKey(c => c.StateId) // Foreign Key in City
                .OnDelete(DeleteBehavior.Restrict); // Configure delete behavior (optional)
        }
    }
}
