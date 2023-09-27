using QuickMathWeb.Models.DomainModels;

namespace QuickMathWeb.Helper
{
    public class DataLists
    {
        public static List<Operation> GetAllOperations()
        {
            return new List<Operation>
            {
                new Operation() {Id = 1, Name = "Addition",Symbol = " + " ,ScoreValue = 250}
                , new Operation() {Id = 2,Name = "Subtraction",Symbol = " - " ,ScoreValue = 250}
                , new Operation() {Id = 3,Name = "Multiplication",Symbol = " * " ,ScoreValue = 500}
                , new Operation() {Id = 4,Name = "Division",Symbol = " ÷ " ,ScoreValue = 500}
                , new Operation() {Id = 5,Name = "Squared",Symbol = "² " ,ScoreValue = 750}
                , new Operation() {Id = 6,Name = "Cubed",Symbol = "³ " ,ScoreValue = 750}
                , new Operation() {Id = 7,Name = "Square Root",Symbol = " √" ,ScoreValue = 1000}
                , new Operation() {Id = 8,Name = "Cube Root",Symbol = " ∛" ,ScoreValue = 1000}

            };
        }
        public static List<Difficulty> GetAllDifficulty()
        {
            return new List<Difficulty>
            {
                new Difficulty() {Id = 1, Name = "Very Easy", Multiplier=0.25,Lives = 20, ProblemLimit=20}
                , new Difficulty() {Id = 2, Name = "Easy", Multiplier=0.50,Lives = 15, ProblemLimit=15}
                , new Difficulty() {Id = 3,Name = "Normal", Multiplier=0.75,Lives = 10, ProblemLimit=12}
                , new Difficulty() { Id = 4, Name = "Medium", Multiplier = 0.50, Lives = 7, ProblemLimit = 10 }
                , new Difficulty() { Id = 5, Name = "Hard", Multiplier = 0.50, Lives = 5, ProblemLimit = 5 }
                , new Difficulty () { Id = 6, Name = "Very Hard", Multiplier = 0.50, Lives = 1, ProblemLimit = 3 }

            };
        }


    }
    
}
