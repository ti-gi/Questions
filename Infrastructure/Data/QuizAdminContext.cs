using Microsoft.EntityFrameworkCore;
using Questions.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class QuestionsContext: DbContext
    {
        public QuestionsContext(DbContextOptions<QuestionsContext> options)
        : base(options)
            {
            }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Round> Rounds { get; set; }
    }
}
