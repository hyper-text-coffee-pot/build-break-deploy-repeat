using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CICDTheEasyWay.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
