using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/products")] // URI Versioning
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet, Route("GetV2")]
        public IActionResult Get()
        {
            return Ok(new[] { "Product1 V2", "Product2 V2" });
        }
    }
}
