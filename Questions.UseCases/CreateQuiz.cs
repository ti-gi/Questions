using Infrastructure.Data;
using Questions.Core;

namespace Questions.UseCases
{
    public class CreateQuiz
    {
        private readonly QuestionsContext _context;
        public CreateQuiz(QuestionsContext context)
        {
            _context = context;
        }

        public void Execute(int competitionId, string name)
        {
            var q = Quiz.Create(name);
            var competition = _context.Competitions.First(x => x.Id == competitionId);
            competition.Quizzes.Add(q);
            _context.SaveChanges();
        }
    }
}
