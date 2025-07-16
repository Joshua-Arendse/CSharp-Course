namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            //  Declaring and Initializing a Dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding Items to the Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");


            // Access Items in the Dictionary
            string name = employees[101];
            //Console.WriteLine(name);

            // Update data in a Dictionary
            employees[102] = "Jane Smith";

            // Remove an item from a Dictionary
            employees.Remove(101);

            // Checks specific key before adding
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            bool added = employees.TryAdd(102, "Michael Brims");//TryAdd
            if (!added)
            {
                Console.WriteLine("Employee with id 102 already exist");
            }

            /*
            int counter = 101;
            // Checks if ID is there then adds when the loop stops because the ID doesn't exist
            while(employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Jman Boi");
            */

            // Iterating over a Dictionary
            foreach(KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            Console.ReadKey();
        }
    }
}