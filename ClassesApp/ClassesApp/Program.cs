namespace ClassesApp
{
    // Access modifier Internal
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the class Car
            // Creating an instance of the class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            Console.WriteLine("Please enter the Brand Name");
            // Setting Brand
            audi.Brand = Console.ReadLine();

            // Getting Brand
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            // New Class

            Customer earl = new Customer("Earl");
            Customer FrankTheTank = new Customer("FrankTheTank", "mainstreet 1", "0734490247");

            Console.WriteLine("The customers name is " + earl.Name);
            Console.WriteLine("");

            // Default Customer with no Arguements given
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter customers name");
            myCustomer.Name = Console.ReadLine();

            myCustomer.SetDetails("Bob", "Mainstreet 2", "0312887344");

            Console.WriteLine("Details about my new customer: " + myCustomer.Name);

            // Methods in Classes
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();
            Car myBMW = new Car("i7", "BMW", true);
            myBMW.Drive();

            // Named Parameters
            Console.WriteLine(Addnum(15, 25));
            Console.WriteLine(Addnum(firstNum: 15, secondNum: 25));
            Console.WriteLine(Addnum(firstNum: 15, 25));
            Console.WriteLine(Addnum(15, secondNum: 25));
            // Used when there are a lot of parameters, so that it's easier for readability and access

            // Computed Properties
            Rectangle r1 = new Rectangle("Yellow");
            r1.Width = 5;
            r1.Height = 5;
            Console.WriteLine("Area of r1 is"+r1.Area);

            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            customer3.Password = "bhdfy23283@*6$";

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();

            Console.ReadKey();
        }
        // Named Parameters
        static int Addnum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
