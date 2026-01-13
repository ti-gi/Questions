namespace Questions.Core
{
    public class Round
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int RoundNumber { get; set; }
        public int Order { get; set; }

        public static Round Create(string name, int roundNumber, int order)
        {
            return new Round { Name = name, RoundNumber = roundNumber, Order = order };
        }
    }
}
