using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wearingweb.Models;

namespace Wearingweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       /* private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };*/

        private readonly ILogger<WeatherForecastController> _logger;

      /*  public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
*/
        private readonly Context _context;

        public WeatherForecastController(Context context)
        {
            _context = context;
        }

       /* [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpPost]
        public async Task<ActionResult<AddItem>> PostStudent(AddItem AddItem)
        {
            _context.Items.Add(AddItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = AddItem.ItemID }, AddItem);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddItem>>> GetStudents()
        {
            return await _context.Items.ToListAsync();
        }
    }
}