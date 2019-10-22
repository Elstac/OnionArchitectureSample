using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Domain;
using OnionArchitectureSample.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureSample.Application.Services
{
    class ProductService : IProductService
    {
        private ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }
    }
}
