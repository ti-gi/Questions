using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Data
{
    public class QuestionsContextFactory : IDesignTimeDbContextFactory<QuestionsContext>
    {
        public QuestionsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QuestionsContext>();

            // Replace with your actual connection string
            optionsBuilder.UseMySql(
                     "server=win19.mojsite.com,3306;database=pqsightcom_quiz_admin_dev;uid=pqsightcom_abs;pwd=rjadkwnclihfuspyozqg",
                    ServerVersion.AutoDetect("server=win19.mojsite.com,3306;database=pqsightcom_quiz_admin_dev;uid=pqsightcom_abs;pwd=rjadkwnclihfuspyozqg"),
                                            options => options.EnableRetryOnFailure(
                                                    maxRetryCount: 5,
                                                    maxRetryDelay: System.TimeSpan.FromSeconds(10),
                                                    errorNumbersToAdd: null
                                            )
                );

            return new QuestionsContext(optionsBuilder.Options);
        }
    }
}
