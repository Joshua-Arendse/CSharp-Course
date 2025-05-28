using System;
using System.ComponentModel.DataAnnotations;

namespace TernaryOperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature: ");
            String input = Console.ReadLine();
            int temp;
            bool validInteger = int.TryParse(input, out temp);

            if(validInteger)
            {
                string temp1 = temp <= 15 ? "it is too cold here" : temp <= 28 ? "it is ok" : "it is hot here";
                Console.WriteLine(temp1);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature.");
            }
            Console.ReadKey();
        }
    }
}