using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);      //calling a private method through a public method
            Console.ReadKey();
        }



    }
}