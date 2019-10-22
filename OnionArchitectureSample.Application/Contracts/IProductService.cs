using OnionArchitectureSample.Application.Contracts.Dtos;
using OnionArchitectureSample.Domain;
using System.Collections.Generic;

namespace OnionArchitectureSample.Application.Contracts
{
    public interface IProductService
    {
        public IEnumerable<ProductDto> GetAllProducts();
    }
}
