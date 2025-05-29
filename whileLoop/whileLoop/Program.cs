using System;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;

            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            */

            string Text = "";
            int counter = 0;
            while (Text.Equals(""))
            {
                Console.WriteLine("Press enter to Count and anything else to Stop Counting.");
                Text = Console.ReadLine();
                
                counter++;
                Console.WriteLine("Current people count is {0}.", counter);
            }
            Console.WriteLine("There are {0} people. Press enter to close the program.", counter);
            Console.Read();
        }
    }
}