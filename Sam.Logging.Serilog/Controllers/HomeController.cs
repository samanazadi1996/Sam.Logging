using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Sam.Logging.Serilog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public OkResult Get()
        {
            _logger.LogError("test");

            return Ok();
        }
    }
}
