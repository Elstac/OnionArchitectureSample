using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Application.Contracts.Dtos;
using OnionArchitectureSample.Domain;
using OnionArchitectureSample.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureSample.Application.Services
{
    class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void AddProduct(ProductDto product)
        {
            var newProduct = new Product(product.Name, product.Price);

            productRepository.AddProduct(newProduct);
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var productDtosCollection = productRepository.GetAllProducts()
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
            productRepository.DeleteProduct(productId);
        }

        public void UpdateProduct(Guid productId,ProductDto productDto)
        {
            var productToUpdate = productRepository.Find(productId);

            if (!string.IsNullOrEmpty(productDto.Name))
                productToUpdate.Name = productDto.Name;

            if (productDto.Price != 0)
                productToUpdate.Price = productDto.Price;

        }
    }
}
