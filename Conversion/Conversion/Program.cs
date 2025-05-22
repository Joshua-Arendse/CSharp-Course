using System;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 1287482;
            long bigNum = num;

            float myFloat = 16.35f;
            double myNewDouble = myFloat;

            Console.WriteLine(myNewDouble);
            Console.Read();
            
            //explicit converion
            //cast double to int
            double myDouble = 13.56;
            int myInt;

            myInt = (int)myDouble;

            Console.WriteLine(myInt);
            Console.Read();

            //type conversion
            string myString = myDouble.ToString();//"13.56"
            string myFloatString = myFloat.ToString();

            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);
            Console.Read();


        }
    }
}