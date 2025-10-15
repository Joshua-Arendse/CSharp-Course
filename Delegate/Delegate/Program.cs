namespace Delegate
{
    internal class Program
    {
        // 1. Decleration:
        public delegate void Notify(string message);

        static void Main(string[] args)
        {
            // Delegates define a method signature and any method assigned to a delegate must match this signature.

            // 2. Instantiation:
            Notify notifyDelegate = Showmessage;
            // Notify notifyDelegate = new Notify(notifyDelegate);

            // 3. Invocation: (calling)
            notifyDelegate("Hello, Delegates!");

        }
        static void Showmessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
