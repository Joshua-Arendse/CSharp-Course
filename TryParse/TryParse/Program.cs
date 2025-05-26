using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature?");
            string temperature = Console.ReadLine();
            int temp;
            int number;

            if(int.TryParse(temperature, out number))
            {
                temp = number;
            }
            else
            {
                temp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }


            if (temp < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 10)
            {
                Console.WriteLine("It's 10 degrees Celcius");
            }
            else if (temp > 30)
            {
                Console.WriteLine("Cozy and warm!");
            }
            else
            {
                Console.WriteLine("It is what it is.");
            }
        }
    }
}