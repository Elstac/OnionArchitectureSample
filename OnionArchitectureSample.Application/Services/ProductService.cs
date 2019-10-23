using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Application.Contracts.Dtos;
using OnionArchitectureSample.Domain;
using OnionArchitectureSample.Infrastructure;
using System;
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

        public void AddProduct(ProductDto product)
        {
            var newProduct = new Product(product.Name, product.Price);

            context.Products.Add(newProduct);
            context.SaveChanges();
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

        public void DeleteProduct(Guid productId)
        {
            var productToRemove = context.Products.Find(productId);

            context.Products.Remove(productToRemove);

            context.SaveChanges();
        }

        public void UpdateProduct(Guid productId,ProductDto productDto)
        {
            var productToUpdate = context.Products.Find(productId);

            if (!string.IsNullOrEmpty(productDto.Name))
                productToUpdate.Name = productDto.Name;

            if (productDto.Price != 0)
                productToUpdate.Price = productDto.Price;

            context.Products.Update(productToUpdate);

            context.SaveChanges();
        }
    }
}
