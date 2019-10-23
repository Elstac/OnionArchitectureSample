using OnionArchitectureSample.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;

namespace OnionArchitectureSample.Application.Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();
        void AddProduct(ProductDto product);
        void UpdateProduct(Guid productId, ProductDto productDto);
        void DeleteProduct(Guid productId);
    }
}
