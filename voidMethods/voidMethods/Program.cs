namespace voidMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an arguement and I am called from a method");
            Console.Read();
        }
        //access modifier (static) return type method name (parameter1, paramter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I was called from a Method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}