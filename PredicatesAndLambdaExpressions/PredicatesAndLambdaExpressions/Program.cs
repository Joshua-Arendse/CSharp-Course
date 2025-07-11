namespace PredicatesAndLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            //Predicates
            //Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x >= 10; //Assigns a variable with the Lambda Expression

            //Lambda Expressions
            /* It consists of 2 parts
             * 1. Parameters
             * 2. Expression or Statement Block
             * 
             * Parameters are written on the left side of =>
             * (this symbol is read as "goes to" or "becomes").
             * 
             * This reads as:
             * "Take an input x and turn it into x multiplied by x."
             * x => x * x;
             */
            

            //List<int> higherEqualTen = numbers.FindAll(x => x >= 10); //Lambda Expression[=>](means "becomes")
            List<int> higherEqualTen = numbers.FindAll(isGreaterThanTen);
            //This will return a list of numbers that are 10 and higher
            Console.WriteLine("All numbers 10 and above:");
            foreach (int number in higherEqualTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
