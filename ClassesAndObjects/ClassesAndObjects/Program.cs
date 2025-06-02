using System;

namespace ClassesAndObjects
{
    //A Class in C# (and most other object-oriented programming languages)
    //is a blueprint for creating objects.
    //It defines a set of properties (data attributes)
    //and methods (functions) that an object of that class will have.
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4", 250, "blue");
            audi.Drive();
            audi.Details();
            Car bmw = new Car("BMW M5", 350);
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car.");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinitely");
            }
        }
    }
}