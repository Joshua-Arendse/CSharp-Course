namespace LogTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // he @ sign in C# s used to denote a verbatim string literal
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.text");
            string message = "This is a log entry";

            // This creates the file if there isnt one
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, message + "\n");

            //File.AppendAllText("log.text", "Hello World" + "\n");

            Console.ReadKey();
        }
    }
}
