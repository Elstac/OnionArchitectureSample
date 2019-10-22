using Microsoft.EntityFrameworkCore;
using OnionArchitectureSample.Domain;

namespace OnionArchitectureSample.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var productBuilder = modelBuilder.Entity<Product>();
            productBuilder.HasKey(p => p.Id);
        }
    }
}
