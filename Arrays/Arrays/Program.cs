using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            Console.ReadKey();

            Console.WriteLine("Input a number here:");
            string input = Console.ReadLine();
            // Assign value to an array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            Console.ReadKey();

            // Another way of initializing an Array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 9, 8 };

            // Third way of initializing an Array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();

        }
    }
}
