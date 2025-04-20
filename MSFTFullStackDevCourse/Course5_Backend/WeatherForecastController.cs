using Microsoft.AspNetCore.Mvc;

namespace Course5_Backend
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }

        [HttpPost]
        public IActionResult Post([FromBody] WeatherForecast forecast)
        {
            // Add data to storage (e.g., database)
            return Ok(forecast);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WeatherForecast forecast)
        {
            // Simulate updating data (no database)
            // In a real scenario, you'd update your data store.

            // Example: Using an in-memory dictionary (replace with your actual data storage)
            // Replace "forecasts" with your actual data.
            Dictionary<int, WeatherForecast> forecasts = new Dictionary<int, WeatherForecast>()
            {
                { 1, new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 20, Summary = "Cool" } },
                { 2, new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = 25, Summary = "Warm" } },
                { 3, new WeatherForecast { Date = DateTime.Now.AddDays(3), TemperatureC = 30, Summary = "Hot" } }
            };

            if (!forecasts.ContainsKey(id))
            {
                return NotFound(); // Return 404 if the item isn't found
            }

            forecasts[id].Date = forecast.Date;
            forecasts[id].TemperatureC = forecast.TemperatureC;
            forecasts[id].Summary = forecast.Summary;

            return NoContent(); // Return 204 No Content for successful update
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Delete the data for the given ID
            // Example: Find and delete an item with a matching ID
            return NoContent();
        }
    }
}
