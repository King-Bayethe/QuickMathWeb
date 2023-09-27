namespace QuickMathWeb.Models.GameModels
{
    public class InfiniteMode
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Map { get; set; }
        public string Difficulty { get; set; }
        public double ScoreMultiplier { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }
        public int Lives { get; set; }
        public int Problems { get; set; }
        public string TotalTime { get; set; }
        public int Streak { get; set; }
    }
}
