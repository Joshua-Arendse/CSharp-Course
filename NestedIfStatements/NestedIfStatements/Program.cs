using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username:");
            userName = Console.ReadLine();
            /*
            if(isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            */
            if (isRegistered&& userName!="" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin");
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
                
            Console.ReadLine();
        }
    }
}