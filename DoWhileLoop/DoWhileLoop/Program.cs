using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }while (counter > 5);
            */

            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Enter the name of a friend:");
                string friendName = Console.ReadLine();
                int nameLength = friendName.Length;
                lengthOfText += nameLength;
                wholeText += nameLength;
            }while (lengthOfText < 20);

            Console.Read();
        }
    }
}