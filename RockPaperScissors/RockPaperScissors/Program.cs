namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            bool PlayAgain = true;
            string player = "";
            string computer = "";

            while (PlayAgain)
            {
                while(player != "ROCK" && player != "SCISSORS" && player != "PAPER")
                {
                    Console.WriteLine("Choose between Rock, Paper or Scissors: ");
                    player = Console.ReadLine()?.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "SCISSORS";
                        break;
                    case 3:
                        computer = "PAPER";
                        break;
                }
                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                if (player == computer)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((player == "ROCK" && computer == "SCISSORS") ||
                (player == "PAPER" && computer == "ROCK") ||
                (player == "SCISSORS" && computer == "PAPER"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }


                Console.Write("Do you want to play again? (Y/N): ");
                string answer = Console.ReadLine()?.ToUpper();
                if (answer != "Y")
                {
                    PlayAgain = false;
                }
                Console.WriteLine();
            }


            Console.WriteLine("Thanks for playing!");
        }
    }
}
