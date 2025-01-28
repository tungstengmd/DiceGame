namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int die1 = rand.Next(1,7);
            int die2 = rand.Next(1,7);
            int score = 0;
            if (die1 == die2) {
                if (die1 == 6)
                {
                    score = 0;
                }
                else { 
                    score = die1*2;
                }
            } else
            {
                score = die1+die2;
            }
            Console.WriteLine("Score: " + score);
            int die3 = rand.Next(1, 7);
            int die4 = rand.Next(1, 7);
            int score2 = 0;
            if (die3 == die4)
            {
                if (die1 == 6)
                {
                    score2 = 0;
                }
                else
                {
                    score2 = die3 * 2;
                }
            }
            else
            {
                score2 = die3 + die4;
            }
            Console.WriteLine("Score: " + score2);
            if (score > score2)
            {
                Console.WriteLine("Player 1 wins");
            }
            else if (score == score2)
            {
                Console.WriteLine("Tie");
            }
            else 
            {
                Console.WriteLine("Player 2 wins");
            }
        }
    }
}
