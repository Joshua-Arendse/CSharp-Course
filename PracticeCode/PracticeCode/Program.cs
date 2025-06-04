namespace PracticeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reference Type
            string myName = "Joshua";

            //Defining or setting up a variable
            string petsName;

            //initialize variable
            petsName = "Daisy";
            Console.WriteLine($"My pet is {petsName}");
            
            //Assign a new value
            petsName = "Barky";
            Console.WriteLine($"My pet is {petsName}");

            string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat"];

            Console.WriteLine("Today is " + weekDays[3]);
            
            Console.ReadKey();
        }
    }
}
