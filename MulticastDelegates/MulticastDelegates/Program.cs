namespace MulticastDelegates
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
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
            // Creating a mutlicast delagate
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;// This adds the method

            // invoking the multicast delagate
            logHandler("Log this info!");

            foreach(LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }catch(Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }



            // Removing a method from the multicast delegate

            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else
            {
                Console.WriteLine("LogToFile Method not found!");
            }

            InvokeSafely(logHandler, "After removing the LofToFile");

            //logHandler("After removing the LofToFile");

            Console.ReadKey();
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
