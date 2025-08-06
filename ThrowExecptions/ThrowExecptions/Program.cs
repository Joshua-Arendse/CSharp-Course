namespace ThrowExecptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            GetUserAge(Console.ReadLine());

            Console.ReadKey();
        }

        /* What does Throw do?
         * The throw keyword in C# is used to indicate that a problem has occured in your program.
         * When you us throw, you're essentially saying,
         * "Hey, something went wrong her, adn I can't handle it by myself."
         * You're creating an error on purpose, which is called an exception.
         * 
         * Why use throw?
         * 
         * 1. To stop bad things from happening:
         * If something in your program isn't right, like if a necessary file is missing or a number that should never be zero is zero, using throw stops the program before any more damage can happen.
         * 
         * 2. To tell other parts of your program about the problem:
         * Sometimes, one part of the program might not know how to fix the problem, but another part does. By using throw, the first part can let the second part handle the issue.
         */


        static int GetUserAge(String input)
        {
            int age;
            if(!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if(age < 0|| age > 120)
            {
                throw new Exception("Your age must be between 0 and 120");
            }
            return age;
        }
    }
}
