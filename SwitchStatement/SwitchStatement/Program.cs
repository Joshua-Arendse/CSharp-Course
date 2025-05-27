using System;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if(age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Joshua";

            switch (username)
            {
                case "Joshua":
                    Console.WriteLine("Username is Joshua");
                    break;
                case "bob":
                    Console.WriteLine("Username is bob");
                    break;
                default:
                    Console.WriteLine("Username is Unknown");
                    break;

            }

            Console.Read();
        }
    }
}