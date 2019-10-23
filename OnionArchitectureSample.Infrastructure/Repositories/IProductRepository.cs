using OnionArchitectureSample.Domain;
using System;
using System.Collections.Generic;

namespace OnionArchitectureSample.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(Guid productId);
        ICollection<Product> GetAllProducts();
        Product Find(Guid productId);
    }
}
