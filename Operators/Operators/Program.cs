using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num2 - num3;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num2 / num3;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num2 * num3;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num2 % num3;//returns the remainder after division
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            //equality operators
            bool isEqual;
            isEqual = num1 == num2;//comparison operator
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            //conditional operators
            bool isLowerAndSunny;
            //condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            //condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}