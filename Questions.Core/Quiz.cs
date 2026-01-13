namespace Questions.Core
{
    public class Quiz
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Round> Rounds { get; } = [];

        public static Quiz Create(string name)
        {
            return new Quiz { Name = name };
        }

        public void CreateRound(string name, int roundNumber, int order)
        {
            var q = Round.Create(name, roundNumber, order);
            Rounds.Add(q);
        }
    }
}
