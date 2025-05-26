using System;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Temperature today?");
            string temperature = Console.ReadLine();
            int temp = int.Parse(temperature);
            /*
            if (temp < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if (temp == 10)
            {
                Console.WriteLine("It's 10 degrees Celcius");
            }
            
            if (temp > 10)
            {
                Console.WriteLine("Cozy and warm!");
            }
            */
            //else if
            if (temp < 10)
            {
                Console.WriteLine("Take the coat");
            }else if (temp == 10)
            {
                Console.WriteLine("It's 10 degrees Celcius");
            }else if (temp > 30)
            {
                Console.WriteLine("Cozy and warm!");
            }else
            {
                Console.WriteLine("It is what it is.");
            }

            Console.Read();
        }
    }
}