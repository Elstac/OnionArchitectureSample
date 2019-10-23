using Microsoft.EntityFrameworkCore;
using OnionArchitectureSample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureSample.Infrastructure.Repositories
{
    class ProductRepository : IProductRepository
    {
        public DbSet<Product> productSet;

        public ProductRepository(ApplicationDbContext context)
        {
            productSet = context.Set<Product>();
        }

        public void AddProduct(Product product)
        {
            productSet.Add(product);
        }

        public void DeleteProduct(Guid productId)
        {
            var productToRemove = productSet.Find(productId);

            productSet.Remove(productToRemove);
        }

        public Product Find(Guid productId)
        {
            return productSet.Find(productId);
        }

        public ICollection<Product> GetAllProducts()
        {
            return productSet.ToList();
        }
    }
}
