namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "i8", 2025, 2);
            car1.DisplayInfo();

            Console.ReadKey();
        }
    }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This Vehicle is a {Make}:{Model} made in {Year}.");
        }
    }

    public class Car : Vehicle
    {
        public int NumDoors {  get; set; }

        public Car(string make, string model, int year, int numDoors) : base(make, model, year)
        {
            NumDoors = numDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"This Car is a {Make}:{Model} made in {Year} with {NumDoors} doors.");
        }
    }
}
