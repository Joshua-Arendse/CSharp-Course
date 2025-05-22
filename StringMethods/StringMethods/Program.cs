using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string var;
            Console.WriteLine("Please enter your name and press enter: ");
            var = Console.ReadLine();
            string upper = String.Format("Upper Case : {0}", var.ToUpper());
            Console.WriteLine(upper);
            string lower = String.Format("Lower Case : {0}", var.ToLower());
            Console.WriteLine(lower);
            string trim = String.Format("Trimmed : {0}", var.Trim());
            Console.WriteLine(trim);
            string subString = String.Format("Substring : {0}", var.Substring(0, 5));
            Console.WriteLine(subString);

            Console.ReadKey();
        }
    }
}