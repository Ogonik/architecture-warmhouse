using Microsoft.AspNetCore.Mvc;

namespace temperature_api.Controllers
{
    [ApiController]
    public class TemperatureController : ControllerBase
    {
       private readonly ILogger<TemperatureController> _logger;

        public TemperatureController(ILogger<TemperatureController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/temperature/{sensorId}")]
        public TemparatureResponseDTO GetTemperatureByID(string sensorId)
        {
            _logger.LogInformation($"Returning sensor '{sensorId}' temperature");

            return new TemparatureResponseDTO()
            {
                Description = "Some random Description",
                Location = "Some random location",
                SensorId = sensorId,
                SensorType = "temperature",
                Status = "active",
                Timestamp = DateTime.Now,
                Unit = "°C",
                Value = Math.Round(new Random().NextDouble() * 20, 2)

            };
        }

        [HttpGet("/temperature")]
        public TemparatureResponseDTO GetTemperatureByLocation([FromQuery] string location)
        {
            _logger.LogInformation($"Returning location '{location}' temperature");

            return new TemparatureResponseDTO()
            {
                Description = "Some random Description",
                Location = location,
                SensorId = Guid.NewGuid().ToString(),
                SensorType = "temperature",
                Status = "active",
                Timestamp = DateTime.Now,
                Unit = "°C",
                Value = Math.Round(new Random().NextDouble() * 30, 2)
            };
        }
    }
}
