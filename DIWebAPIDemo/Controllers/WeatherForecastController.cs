using Microsoft.AspNetCore.Mvc;
using DIWebAPIDemo.Models;

namespace DIWebAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private ICrypto _Crypto;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICrypto crypto)
        {
            _logger = logger;
            _Crypto = crypto;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _Crypto.Name = "BitCoins";

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Crypto = _Crypto.Name,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}