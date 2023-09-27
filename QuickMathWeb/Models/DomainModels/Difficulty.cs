namespace QuickMathWeb.Models.DomainModels
{
    public class Difficulty
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Lives { get; set; }
        public int ProblemLimit { get; set; }
        public double Multiplier { get; set; }
        

    }
}
