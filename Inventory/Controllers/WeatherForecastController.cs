using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;

        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult <WeatherForecast> Get()
        {
            return Ok(_configuration.GetSection("ConnectionStrings:path").Value);
        }
    }
}