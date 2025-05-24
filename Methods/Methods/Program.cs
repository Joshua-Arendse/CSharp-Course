using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Mult(15, 31));
            Console.WriteLine(Div(157, 31));
            Console.Read();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Div(double num3, double num4)
        {
            return num3 / num4;
        }
    }
}