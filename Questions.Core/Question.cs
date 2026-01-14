namespace Questions.Core
{
    public class Question
    {
        public int Id { get; set; }
        public required string Question1 { get; set; }
        public required string Answer{ get; set; }

        public static Question Create(string question, string answer)
        {
            return new Question { Question1 = question, Answer = answer };
        }
    }
}
