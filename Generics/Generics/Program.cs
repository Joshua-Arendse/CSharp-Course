namespace Generics
{
    internal class Program
    {
        public static void PrintIntArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintStringtArray(string[] array)
        {
            foreach(string i in array)
            {
                Console.WriteLine(i);
            }
        }

        // Generic
        // It is like a template that allows you to use any data type, so you dont have to use many methods if you dont know what data type to expect
        public static void PrintArray<T>(T[] array)
        {
            foreach (T t in array)
            {
                Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            string[] stringArray = { "One", "Two", "Three", "Four" };

            PrintArray(intArray);
            PrintArray(stringArray);

            Console.ReadKey();
        }
    }
}
