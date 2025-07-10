namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colours = new List<string>();

            // Adding items to the list
            colours.Add("red");
            colours.Add("green");
            colours.Add("blue");
            colours.Add("red");

            Console.WriteLine("Current colours in the list:");
            foreach (var colour in colours)
            {
                Console.WriteLine(colour);
            }

            //colours.Remove("red"); // Removes first instance of "red"
            bool isDeletingSuccessful = colours.Remove("red");
            while (isDeletingSuccessful)// Loop to remove all "red"
            {
                isDeletingSuccessful = colours.Remove("red");
            }


            Console.WriteLine("Current colours in the list:");
            foreach (var colour in colours)
            {
                Console.WriteLine(colour);
            }

            //Declaring and Initializing a List
            List<string> colours2 = [
                "red",
                "blue",
                "green",
                "red"
                ];
            Console.WriteLine("Current colours in the list:");
            foreach (var colour in colours2)
            {
                Console.WriteLine(colour);
            }

            //Sort()

            List<int> numbers = new List<int> { 10, 5, 15, 3, 9 };

            Console.WriteLine("Unsorted List:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted List:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //FindAll()

            //This will return a list of numbers that are 10 and higher
            List<int> higherEqualTen = numbers.FindAll(x => x >= 10); //Lambda Expression[=>]

            Console.WriteLine("All numbers 10 and above:");
            foreach (int number in higherEqualTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
