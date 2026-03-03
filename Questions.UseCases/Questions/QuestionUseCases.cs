using Infrastructure.Data;

namespace Questions.UseCases.Questions
{
    public class QuestionUseCases : IQuestionUseCases
    {
        private readonly QuestionsContext _context;
        public QuestionUseCases(QuestionsContext context) {
            _context = context;
        }
        public void DeleteQuestion(int id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}
