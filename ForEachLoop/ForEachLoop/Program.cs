using System;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat"];

            Console.WriteLine("Today is " + weekDays[0]);
            Console.WriteLine("Today is " + weekDays[1]);
            Console.WriteLine("Today is " + weekDays[2]);
            Console.WriteLine("Today is " + weekDays[3]);
            Console.WriteLine("Today is " + weekDays[4]);
            Console.WriteLine("Today is " + weekDays[5]);
            Console.WriteLine("Today is " + weekDays[6]);
            
            foreach (string weekDay in weekDays)
            {
                Console.WriteLine("Today is " + weekDay);
            }

            Console.ReadKey();
        }
    }
}
