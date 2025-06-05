namespace SmallCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first whole number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second whole number: ");
            string input2 = Console.ReadLine();
            
            //conversion from string to integer
            int output1 = Convert.ToInt32(input1);
            int output2 = Convert.ToInt32(input2);
            //addition of integers into a variable
            int output = output1 + output2;
            //results
            Console.WriteLine("The Sum of {0} and {1} is equal to {2}", input1, input2, output);


            //Different method
            //Parse
            
            Console.WriteLine("Enter the first whole number: ");
            int input3 = int.Parse(Console.ReadLine()); //conversion using parse skips the need to create more variables
            Console.WriteLine("Enter the second whole number: ");
            int input4 = int.Parse(Console.ReadLine()); //instead of using\creating a string variable we use readline direcly as it reads the response as a string
            // an error will occur if you enter characters instead of numbers

            //addition
            int output3 = input3 + input4;
            //Results
            Console.WriteLine("The Sum of {0} and {1} is equal to {2}", input3, input4, output3);

            Console.ReadKey();
        }
    }
}
