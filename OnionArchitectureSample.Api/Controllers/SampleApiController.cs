using Microsoft.AspNetCore.Mvc;
using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;

namespace OnionArchitectureSample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleApiController : ControllerBase
    {
        private IProductService productService;

        public SampleApiController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("getAll")]
        public IEnumerable<ProductDto> GetAll()
        {
            return productService.GetAllProducts();
        }

        [HttpPost("addProduct")]
        public void AddProduct([FromBody] ProductDto productDto)
        {
            productService.AddProduct(productDto);
        }

        [HttpDelete("removeProduct/{productId}")]
        public void UpdateProduct(Guid productId)
        {
            productService.DeleteProduct(productId);
        }

        [HttpPut("updateProduct/{productId}")]
        public void UpdateProduct(Guid productId,[FromBody] ProductDto productDto)
        {
            productService.UpdateProduct(productId, productDto);
        }
    }
}
