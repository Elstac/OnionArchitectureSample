using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OnionArchitectureSample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleApiController : ControllerBase
    {
        [HttpGet("getAll")]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "A", "B" };
        }
    }
}
