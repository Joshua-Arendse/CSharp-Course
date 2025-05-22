using System;
using System.Runtime.InteropServices;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define few variables
            int age = 21;
            string name = "Joshua";
            string job = "Developer";

            // 1.  string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

            //2. String Formatting.
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I am a {2}", name, age, job);

            //3. String Interpolation.
            //string Interpolation uses $ at the start which will allow us to write our
            //variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //4.Verbatim Strings.
            //verbatim strings start with @ and tells the compiler to take the string 
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");

            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U \A and \D are not valid escape charcaters
            Console.WriteLine(@"C:\User\Admi\Dog Pictures\Dog1\Super coolDog.png");

            //with verbatim even valid escape charactes won't work
            Console.WriteLine(@"Muahaha \n has no power here!");
        }
    }
}