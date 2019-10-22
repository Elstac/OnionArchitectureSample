using Microsoft.AspNetCore.Mvc;
using OnionArchitectureSample.Application.Contracts;
using OnionArchitectureSample.Domain;
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
        public IEnumerable<Product> GetAll()
        {
            return productService.GetAllProducts();
        }
    }
}
