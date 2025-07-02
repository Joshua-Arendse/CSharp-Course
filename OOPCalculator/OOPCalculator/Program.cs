namespace OOPCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true) // Infinite loop for continuous calculations
            {
                Console.WriteLine("\nSimple Calculator");
                Console.Write("Enter first number: ");
                calculator.inputA = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                calculator.inputB = int.Parse(Console.ReadLine());

                Console.Write("Choose operation (+, -, *, /) or type 'exit' to quit: ");
                string operation = Console.ReadLine();

                if (operation.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break; // Exit the loop
                }

                double result = 0; // Store the result of the calculation

                switch (operation)
                {
                    case "+":
                        result = calculator.Add();
                        break;
                    case "-":
                        result = calculator.Subtract();
                        break;
                    case "*":
                        result = calculator.Multiply();
                        break;
                    case "/":
                        result = calculator.Divide();
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        continue; // Restart the loop
                }

                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
