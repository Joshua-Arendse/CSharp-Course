namespace Delegates2
{
    public delegate void LogHandler(String message);

    public class Logger
    {
        public void LogToConsole(string  message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File Log: " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to Console");

            logHandler = logger.LogToFile;
            logHandler("Log some stuff");

            Console.ReadKey();
        }
    }
}
