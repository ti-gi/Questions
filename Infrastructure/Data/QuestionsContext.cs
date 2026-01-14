using Microsoft.EntityFrameworkCore;
using Questions.Core;

namespace Infrastructure.Data
{
    public class QuestionsContext: DbContext
    {
        public QuestionsContext(DbContextOptions<QuestionsContext> options)
        : base(options)
            {
            }
        public DbSet<Question> Questions { get; set; }
    }
}
