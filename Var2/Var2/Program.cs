using System;

namespace Var2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Joshua";

            string message = "My name is " + name;

            string capsMessage = message.ToUpper();

            Console.WriteLine(capsMessage);
            Console.Read();
        }
    }
}