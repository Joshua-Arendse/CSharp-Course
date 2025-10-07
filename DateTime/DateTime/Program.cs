using System.Xml;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2002, 01, 07);

            Console.WriteLine($"My birthday is {dateTime}");

            //Write today on screen
            Console.WriteLine(DateTime.Today);
            //Write current time on screen
            Console.WriteLine(DateTime.Now);
            //Write tomorrow
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the "+ tomorrow);
            //day pf the week
            Console.WriteLine("Today is "+DateTime.Today.DayOfWeek);
            //first day of the year
            Console.WriteLine(GetFirstDayOfYear(2002));

            int days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine("Days in Feb 2002: "+days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: "+days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: "+now.Minute);

            Console.WriteLine($"The time is {DateTime.Now.Hour} o'clock and {DateTime.Now.Minute} minutes and {DateTime.Now.Second} seconds");

            Console.WriteLine("Write your birthday in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime) )
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed= now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old.",daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }


            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
