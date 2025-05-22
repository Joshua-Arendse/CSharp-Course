using System;

namespace DatatypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 21;
            Console.WriteLine(myByte);
            sbyte mySbyte = 89;
            Console.WriteLine(mySbyte);
            int myint = 3000;
            Console.WriteLine(myint);
            short myShort = 30000;
            Console.WriteLine(myShort);
            long myLong = 8789775446;
            Console.WriteLine(myLong);
            float myFloat = 9.6898f;
            Console.WriteLine(myFloat);
            double myDouble = 0.56755;
            Console.WriteLine(myDouble);
            char myChar = 'J';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myString = "456";
            Console.WriteLine(myString);
            string myText = "I control Text";
            Console.WriteLine(myText);

            int numText = int.Parse(myString);
            Console.WriteLine(numText);
            Console.ReadKey();

        }
    }
}