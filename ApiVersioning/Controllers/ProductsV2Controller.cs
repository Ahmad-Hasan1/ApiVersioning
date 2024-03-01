using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiController]
    [Route("api/products")]
    [ApiVersion("2.0")]
    //[Route("api/v{version:apiVersion}/products")] // URI Versioning
    //[Route("api/v2/products")] // URI Versioning
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult Get()
        {
            return Ok(new[] { "Product1 V2", "Product2 V2" });
        }
    }
}
