using Microsoft.AspNetCore.Mvc;

namespace AzureKeyVaultConfig.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var value = _configuration["Name"];

            return Content(value);
        }
    }
}