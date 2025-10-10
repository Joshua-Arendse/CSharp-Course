namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gets next whole number
            Console.WriteLine("Ceiling: "+Math.Ceiling(15.3));
            Console.WriteLine("Floor: "+Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1,num2)}");
            Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1,num2)}");

            Console.WriteLine("3 to the power of 5 is "+ Math.Pow(3,5));
            Console.WriteLine("PI is: "+ Math.PI);

            Console.WriteLine("The square root of 25 is "+ Math.Sqrt(25));
            Console.WriteLine("Always postive is "+ Math.Abs(-25));
            Console.WriteLine("cos of 1 is: "+ Math.Cos(1));

            Console.ReadKey();
        }
    }
}
