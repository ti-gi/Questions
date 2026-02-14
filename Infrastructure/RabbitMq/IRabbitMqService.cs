namespace Questions.Infrastructure.RabbitMq
{
    public interface IRabbitMqService
    {
        public Task<bool> DeleteQuestion(int id);
    }
}
