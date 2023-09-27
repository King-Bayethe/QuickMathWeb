namespace QuickMathWeb.Models
{
    public class Play
    {
        public int Id { get; set; }
        public string? Operation { get; set; }
        public string? Difficulty { get; set; }
        public int Level { get; set; }
        public int Range1 { get; set; }
        public int Range2 { get; set; }
    }
}
