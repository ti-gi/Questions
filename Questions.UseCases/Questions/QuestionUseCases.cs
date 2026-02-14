using Infrastructure.Data;
using Questions.Infrastructure.RabbitMq;

namespace Questions.UseCases.Questions
{
    public class QuestionUseCases : IQuestionUseCases
    {
        private readonly QuestionsContext _context;
        private readonly IRabbitMqService _rabbitMqService;
        public QuestionUseCases(QuestionsContext context, IRabbitMqService rabbitMqService) {
            _context = context;
            _rabbitMqService = rabbitMqService;
        }
        public async void DeleteQuestion(int id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == 4654);
            await _rabbitMqService.DeleteQuestion(456);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}
