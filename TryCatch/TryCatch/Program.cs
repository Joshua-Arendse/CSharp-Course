using System.Diagnostics;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                Console.WriteLine("Please enter a number: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;
            }catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());     //Long explanation for the error
                Console.WriteLine("Error: " + ex.Message);  //Short explanation for the error
                //This line is only executed during "Debugging"
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                // Code to cleanup or finalize
                // ideal for cleaning up resources, like closing file streams or database connections.

                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
            Console.ReadLine(); 
        }
    }
}
