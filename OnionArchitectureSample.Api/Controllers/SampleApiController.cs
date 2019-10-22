using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureSample.Domain;
using OnionArchitectureSample.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureSample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleApiController : ControllerBase
    {
        private ApplicationDbContext context;

        public SampleApiController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("getAll")]
        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }
    }
}
