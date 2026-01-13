namespace Questions.Core
{
    public class Competition
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Quiz> Quizzes { get; } = [];

        public static Competition Create(string name)
        {
            return new Competition { Name = name };
        }

        public void CreateQuiz(string name)
        {
            if(Quizzes.Any(x => x.Name == name))
            {
                return;
            }
            var q = Quiz.Create(name);
            Quizzes.Add(q);
        }
    }
}
