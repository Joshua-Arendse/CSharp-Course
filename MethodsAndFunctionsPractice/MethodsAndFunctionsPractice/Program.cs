using System.Threading.Channels;

namespace MethodsAndFunctionsPractice
{
    internal class Program
        /*
        1. Degree converter
        2. Simple Calculator
        3. String Reversal
        4. Factorial Calculator
        5. Palindrome Checker         
         */
    {
        static void Main(string[] args)
        {
            //Degree Converter
            
            static double ToFahrenheit(double degree)
            {
                double fahrenheit = ((9.0 / 5.0) * degree) + 32;
                return fahrenheit;
            }

            static double ToCelsius(double degree)
            {
                double Celcius = ((5.0 / 9.0) * (degree - 32));
                return Celcius;
            }

            Console.WriteLine("Enter the temperature:");
            double degree = double.Parse(Console.ReadLine());
            Console.WriteLine("Do you want it converted into Degrees Celsius or Degrees Fahrenheit?");
            Console.WriteLine("Type C or F");
            char choice = char.Parse(Console.ReadLine().ToUpper());

            if (choice == 'C')
            {
                Console.WriteLine($"Your temperature is {ToCelsius(degree)} Degrees Celsuis");
            }else if (choice == 'F')
            {
                Console.WriteLine($"Your temperature is {ToFahrenheit(degree)} Degrees Fahrentheit");
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please type C or F.");
            }

            Console.ReadKey();

            //Simple Calculator

            static double Add(double x, double y)
            {
                double result = x + y;
                return result;
            }
            static double Subtract(double x, double y)
            {
                double result = x - y;
                return result;
            }
            static double Multiply(double x, double y)
            {
                double result = x * y;
                return result;
            }
            static double Divide(double x, double y)
            {
                double result = x / y;
                return result;
            }

            Console.WriteLine("Enter your First number here: ");
            double num1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Second number here: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose between the following operations:");
            Console.WriteLine("Addition: +,   Subraction: -,   Multiplication: *,   Division: /.");
            choice = char.Parse(Console.ReadLine());

            if (choice == '+')
            {
                Console.WriteLine($"Your Result is: {Add(num1, num2)}");
            }else if (choice == '-')
            {
                Console.WriteLine($"Your Result is: {Subtract(num1, num2)}");
            }else if (choice == '*')
            {
                Console.WriteLine($"Your Result is: {Multiply(num1, num2)}");
            }else if (choice == '/')
            {
                if (num2 != 0)  // To avoid division by zero
                {
                    Console.WriteLine($"Your Result is: {Divide(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

            Console.ReadKey();

            //String Reversal

            Console.WriteLine("Type a word or sentence and I will reverse it:");
            string words = Console.ReadLine();

            static string ReverseString(string words)
            {
                string reversed = "";
                for (int i = words.Length - 1; i >= 0; i--)//Starts from the last letter in the string
                {
                    reversed += words[i];
                }
                return reversed;
            }

            Console.WriteLine($"{ReverseString(words)}");

            Console.ReadKey();

            //Factorial Calculator

            Console.WriteLine("Enter a number and I will return the factorial for that number: ");
            int fact = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Factorial for {fact}! = {Factorial(fact)}");

            static int Factorial(int fact)
            {
                if (fact == 0 || fact == 1)  // Base case
                {
                    return 1;
                }
                else  // Recursive case
                {
                    int result = fact * Factorial(fact - 1);// Formula: n!= n x (n-1)!

                    return result;
                }
            }
            Console.ReadKey();

            //Palindrome Checker

            Console.WriteLine("Enter a word or sentence to check if it is Palindrome:");
            string pali = Console.ReadLine().Trim().ToLower().Replace(" ", "");

            if (PalindromeChecker(pali))
            {
                Console.WriteLine("Yes, this is a palindrome!");
            }
            else
            {
                Console.WriteLine("No, this is not a palindrome.");
            }

            static bool PalindromeChecker(string pali)
            {
                return pali == ReverseString(pali);
            }

            Console.ReadKey();
        }
    }
}
