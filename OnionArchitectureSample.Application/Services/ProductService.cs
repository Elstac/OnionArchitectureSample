using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Application.Contracts.Dtos;
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

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var productDtosCollection = context
                                        .Products
                                        .Select(p => new ProductDto
                                        {
                                            Name = p.Name,
                                            Price = p.Price
                                        })
                                        .ToList();

            return productDtosCollection;
        }
    }
}
