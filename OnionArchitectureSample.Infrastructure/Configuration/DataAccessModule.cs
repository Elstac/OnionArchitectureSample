using Autofac;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureSample.Infrastructure.Repositories;

namespace OnionArchitectureSample.Infrastructure.Configuration
{
    public class DataAccessModule : Module
    {
        private string connectionString;

        public DataAccessModule(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.Register<ApplicationDbContext>(context =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                return new ApplicationDbContext(optionsBuilder.Options);
            });
        }
    }
}
