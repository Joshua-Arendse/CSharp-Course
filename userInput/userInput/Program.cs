using System;

namespace userInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add());
            Console.Read();
        }

        public static int add()
        {
            Console.WriteLine("Enter first Number: ");
            string numb1 = Console.ReadLine();
            Console.WriteLine("Enter second Number: ");
            string numb2 = Console.ReadLine();

            int num1 = Convert.ToInt16(numb1);
            int num2 = int.Parse(numb2);

            int result = num1 + num2;

            return result;
        }
    }
}