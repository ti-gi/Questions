using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Questions.Core;
using Questions.UseCases;
using System.Xml.Linq;

namespace Questions.WebApi.Controllers
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
        private readonly QuestionsContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, QuestionsContext context)
        {
            _logger = logger;
            _context = context;
        }
        //https://localhost:7139/weatherforecast
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //var q = Quiz.Create("quiz1");
            //var competition = _context.Competitions.First(x => x.Id == 1);
            //competition.Quizzes.Add(q);
            //_context.SaveChanges();

            var r = Round.Create("round 1", 1, 1);
            var quizzes = _context.Quizzes.First(x => x.Id == 1);
            quizzes.Rounds.Add(r);
            _context.SaveChanges();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
