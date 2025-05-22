using System;

namespace StringMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            string string1= Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            char subString= Console.ReadLine()[0];
            int subIndex = string1.IndexOf(subString);
            Console.WriteLine("Index of character {0} in string is {1}", subString, subIndex);


            string fname, lname;
            Console.WriteLine("Enter First name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            lname = Console.ReadLine();
            string fullname = string.Concat(fname, " ", lname);
            Console.WriteLine("Your Fullname is {0}", fullname);
            Console.ReadKey();

        }
    }
}