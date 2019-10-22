using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OnionArchitectureSample.Infrastructure
{
    class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(
                    "Server=.;Database=entityframework;Trusted_Connection=True;MultipleActiveResultSets=true;Database=OnionArchitectureSample"
                    );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
