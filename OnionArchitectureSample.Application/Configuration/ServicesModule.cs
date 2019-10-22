using Autofac;
using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Application.Services;

namespace OnionArchitectureSample.Application.Configuration
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ProductService>().As<IProductService>();
        }
    }
}
