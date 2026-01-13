using Infrastructure.Data;
using Questions.Core;

namespace Questions.UseCases
{
    public class CreateCompetition
    {
        private readonly QuestionsContext _context;
        public CreateCompetition(QuestionsContext context)
        {
            _context = context;
        }

        public void Execute(string name)
        {
            var c = Competition.Create(name);
            var added = _context.Competitions.Add(new Competition { Name = name });
            _context.SaveChanges();
        }
    }
}
