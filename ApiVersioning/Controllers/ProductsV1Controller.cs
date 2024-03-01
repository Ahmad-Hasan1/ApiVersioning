using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiController]
    [Route("api/products")]
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/products")] // URI Versioning
    //[Route("api/v2/products")] // URI Versioning
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "Product1 V1", "Product2 V1" });
        }
    }
}
