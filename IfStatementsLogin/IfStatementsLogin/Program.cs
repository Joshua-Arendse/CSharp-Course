namespace IfStatementsLogin
{
    internal class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Enter your Username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed.");
            Console.WriteLine("-------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Enter your Username:");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Enter your Password:");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, Wrong password. Restart program");
                }
            }
            else
            {
                Console.WriteLine("Login Failed, wrong username. Restart program");
            }
        }
    }
}