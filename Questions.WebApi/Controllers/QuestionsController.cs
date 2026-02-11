using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Questions.Core;
using Questions.UseCases;
using Questions.UseCases.Questions;
using Questions.WebApi;
using System.Xml.Linq;

namespace QuizAdmin.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<QuestionsController> _logger;
        private readonly QuestionsContext _context;
        private readonly IQuestionUseCases _questionUseCases;

        public QuestionsController(ILogger<QuestionsController> logger, QuestionsContext context, IQuestionUseCases questionUseCases)
        {
            _logger = logger;
            _context = context;
            _questionUseCases = questionUseCases;
        }
        //https://localhost:7140/questions
        [HttpGet(Name = "DeleteQuestion")]
        public IEnumerable<WeatherForecast> Get()
        {
            //var q = Quiz.Create("quiz1");
            //var competition = _context.Competitions.First(x => x.Id == 1);
            //competition.Quizzes.Add(q);
            //_context.SaveChanges();

            _questionUseCases.DeleteQuestion(1);
            

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
