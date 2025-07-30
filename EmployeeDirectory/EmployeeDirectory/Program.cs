namespace EmployeeDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Goal:                 
            Build a Dictionary<int, Employee> where each employee has Name, Department, and Salary.
            Let the user:

            Look up an employee by ID

            Add a new employee (if ID doesn’t exist)

            List all employees in a certain department

            🧠 Topics:

            Dictionary<int, T>

            TryAdd, TryGetValue

            Iterating dictionaries
            */

            Dictionary<int, Employee> staff = new Dictionary<int, Employee>
            {
                [1] = new Employee { Name = "Jeff", Department = "IT", Salary = 50000 },
                [2] = new Employee { Name = "Bob", Department = "CSD", Salary = 8000 },
                [3] = new Employee { Name = "Sam", Department = "IT", Salary = 12000 },
                [4] = new Employee { Name = "Dave", Department = "CSD", Salary = 10000 },
                [5] = new Employee { Name = "Luke", Department = "Sales", Salary = 25000 }
            };

            Console.WriteLine("Search for an employee using their ID number:");
            int IdNumb = int.Parse(Console.ReadLine());

            if (staff.TryGetValue(IdNumb, out Employee emp))
            {
                Console.WriteLine($"{emp.Name}, {emp.Department}, R{emp.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

            Console.WriteLine("If you would like to add an Employee type in the ID you want to add it to, if not then type 'N'.");
            string addChoice = Console.ReadLine();

            if (addChoice.ToUpper() == "N")
            {
                Console.WriteLine("No Employee added.");
            }
            else if (int.TryParse(addChoice, out int newId))
            {
                if (!staff.ContainsKey(newId))
                {
                    Console.WriteLine("Enter employee name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter department:");
                    string dept = Console.ReadLine();

                    Console.WriteLine("Enter salary:");
                    int salary = int.Parse(Console.ReadLine());

                    bool added = staff.TryAdd(newId, new Employee
                    {
                        Name = name,
                        Department = dept,
                        Salary = salary
                    });

                    if (added)
                    {
                        Console.WriteLine("Employee added successfully!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


                Console.WriteLine("Enter a department to search:");
                string depChoice = Console.ReadLine();

                var dep = staff.Values.Where(x => x.Department == depChoice).ToList();
                
                if (dep.Count > 0)
                {
                    dep.ForEach(emp =>
                        Console.WriteLine($"{emp.Name}, R{emp.Salary}"));
                }
                else
                {
                    Console.WriteLine("No employees found in that department.");
                }

                Console.ReadKey();
            }
        }
        class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }
    }
}
