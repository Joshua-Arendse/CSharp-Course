using System;

namespace methodChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "John";
            string friend2 = "Frank";
            string friend3 = "Steve";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }
}