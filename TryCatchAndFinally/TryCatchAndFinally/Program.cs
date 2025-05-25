using System;

namespace TryCatchAndFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please eneter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32.");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.WriteLine("Please enter a number!");
            string num1 = Console.ReadLine();
            Console.WriteLine("Now enter the number you waant to divide it by:");
            string num2 = Console.ReadLine();
            
            try
            {
                int num1AsInt = int.Parse(num1);
                int num2AsInt = int.Parse(num2);
                int result = (num1AsInt/num2AsInt);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero!");
            }

            Console.ReadKey();
        }
    }
}