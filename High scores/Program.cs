namespace High_scores
{
    internal class Program
    {
        class HighScores
        {
            private List<int> scores;


            public HighScores(List<int> initialScores)
            {
                scores = initialScores;
            }


            public int GetLatestScore()
            {
                return scores.Last();
            }


            public int GetHighestScore()
            {
                return scores.Max();
            }


            public List<int> GetTopThreeScores()
            {
                return scores.OrderByDescending(score => score).Take(3).ToList();
            }
        }

      
            static void Main(string[] args)
            {

                List<int> playerScores = new List<int> { 40, 100, 70, 85, 90 };


                HighScores highScores = new HighScores(playerScores);


                Console.WriteLine("Latest score: " + highScores.GetLatestScore());


                Console.WriteLine("Highest score: " + highScores.GetHighestScore());


                List<int> topThree = highScores.GetTopThreeScores();
                Console.WriteLine("Top 3 scores: " + string.Join(", ", topThree));
            }
        }
    }
