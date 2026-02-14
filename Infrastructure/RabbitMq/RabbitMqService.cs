using RabbitMQ.Client;

namespace Questions.Infrastructure.RabbitMq
{
    public class RabbitMqService : IRabbitMqService
    {
        public required IConnection connection;

        private async Task<IConnection> GetConnection()
        {
            if(connection == null)
            {
                var factory = new ConnectionFactory { HostName = "localhost" };
                connection = await factory.CreateConnectionAsync();
            }

            if(connection != null)
            {
                return connection;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public async Task<bool> DeleteQuestion(int id)
        {
            var connection = await GetConnection();
            return true;
        }

    }
}
