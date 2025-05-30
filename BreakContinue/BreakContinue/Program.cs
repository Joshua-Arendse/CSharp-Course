using System;

namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }

            //Continue
            for (int i = 0; i < 10; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine("Odd Number!");
                    continue;
                }
                Console.WriteLine(i);
            }


            Console.Read();
        }
    }
}