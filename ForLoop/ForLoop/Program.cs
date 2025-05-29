using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }
            
            
            for (int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }
            Console.WriteLine("For loop is done.");

            for(int num = 1; num < 20; num += 2)
            {
                Console.WriteLine(num);
            }

            Console.Read();
        }
    }
}