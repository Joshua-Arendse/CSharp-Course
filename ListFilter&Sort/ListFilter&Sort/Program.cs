using System.Security.Cryptography.X509Certificates;

namespace ListFilter_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge:
             * Create a program that takes a list of integers, removes all numbers less than 50, and then sorts the remaining numbers in descending order.

               Challenge twist:
               Only use lambda expressions—no manual loops!
            */

            List<int> numbers = new List<int> { 12, 324, 2543, 123, 12, 6757, 978, 12, 67, 98, 64, 57, 24, 14, 18, 723, 73, 18, 38, 49, 47 };

            numbers.RemoveAll(x => x < 50);
            numbers.Sort();
            numbers.Reverse();

            numbers.ForEach(x => Console.WriteLine(x));

        }
    }
}
