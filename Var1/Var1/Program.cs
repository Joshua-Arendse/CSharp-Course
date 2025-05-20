using System;

namespace Var1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable
            int num1;
            //asssigning a value to a variable
            num1 = 27;

            //declaring and initializing in one go
            int num2 = 7;
            int sum= num1 + num2;

            //using concatenation
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);
            Console.Read();

            //declaring multiple variables at once
            int num3, num4, num5;

            //doubles and floats
            double d1 = 3.1415;
            double d2 = 7.2;
            double sum2 = d1 / d2;
            Console.WriteLine("d1/d2 is " + sum2);

            float f1 = 3.1415f;
            float f2 = 7.2f;
            float sum3 = f1 / f2;
            Console.WriteLine("f1/f2 is " + sum3);
        }
    }
}