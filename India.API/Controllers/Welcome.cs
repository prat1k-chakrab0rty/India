using Microsoft.AspNetCore.Mvc;

namespace India.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Welcome : ControllerBase
    {

        private readonly ILogger<Welcome> _logger;

        public Welcome(ILogger<Welcome> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Pratik")]
        public IActionResult Get()
        {
            return Ok("Hello Pratik!");
        }
    }
}