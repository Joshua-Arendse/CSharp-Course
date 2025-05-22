namespace ParsingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "17";
            string mySecondstring = "38";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondstring);
            int resultInt = num1 + num2;
            string result = myString + mySecondstring;

            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.Read();

            string stringForFloat = "0,85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            
            int num4 = int.Parse(stringForInt);
            float num3 = float.Parse(stringForFloat);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.Read();

        }
    }
}