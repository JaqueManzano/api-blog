using Blogv2.Attribute;
using Microsoft.AspNetCore.Mvc;

namespace Blogv2.Controllers
{
    [ApiController]
    [Route("v1/ping")]
    public class PingController : ControllerBase
    {
        //Health Check Endpoint usado pra checar se a Api está funcionando
        [HttpGet("/consultar")]
        //[ApiKey]
        public IActionResult Get([FromServices] IConfiguration configuration)
        {
            var env = configuration.GetValue<string>("Env");
            return Ok(new { Environment = env });
        }
    }
}
