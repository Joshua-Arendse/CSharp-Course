using System;

namespace LoopsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string score = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(score != "-1")
            {
                Console.WriteLine("Last number was  {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 to calculate the average when you are done.");

                score = Console.ReadLine();
                if (score.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------");
                    //calculate the average and let the teacher know
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                
                if(int.TryParse(score, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if(!(score.Equals("-1")))
                    {
                        Console.WriteLine("Enter a value between 1 and 20!");
                    }
                    continue;
                }

                count++;
            }
            Console.Read();
        }
    }
}