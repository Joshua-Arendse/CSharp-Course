namespace DictionaryObjects
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary {  get; set; }
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key - Value
            // Declaring and Initializing a Dictionary
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Does", 35, 100000));
            employees.Add(2, new Employee("John Doesnt", 25, 200000));
            employees.Add(3, new Employee("John Wasnt", 45, 80000));
            employees.Add(4, new Employee("John Will", 15, 50000));

            foreach(var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} name: {item.Value.Name} earns {item.Value.Salary} and is {item.Value.Age} years old!");
            }


            // Declaring and Initializing a Dictionary using Var *
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if(codes.TryGetValue("NY",out string state))
            {
                Console.WriteLine(state);
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"The statecode name is {item.Key} and the state name is {item.Value}");
            }


            Console.ReadKey();
        }
    }
}
