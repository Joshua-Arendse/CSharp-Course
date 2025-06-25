namespace StudentGradeTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User input
            Console.WriteLine("How many tests/exams do you want to enter? ");
            int numOfGrades = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            string studName = Console.ReadLine();

            Console.WriteLine("Enter your ID: ");
            string studId = Console.ReadLine();

           

            // Create a new student with space for what is entered from first question
            Student student = new Student(numOfGrades);
            student.Name = studName;
            student.Id = studId;

            // Add grades
            int count = 0;
            while (count < numOfGrades)
            {
                Console.WriteLine("Add your grade(percentage): ");
                int percentage = int.Parse(Console.ReadLine());
                student.AddGrade(percentage);
                count++;
            }


            //// Add some grades
            //student.AddGrade(85);
            //student.AddGrade(90);
            //student.AddGrade(78);

            // Display the student's details
            student.DisplayDetails();

            //// Add more grades and check behavior
            //student.AddGrade(88);
            //student.AddGrade(92);
            //student.AddGrade(100); // This should exceed the limit

            Console.ReadKey();
        }

        public class Student
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int[] Grades { get; set; }
            public int gradeCount = 0; // to track how many grades have been added

            public Student(int maxGrades)
            {
                Grades = new int[maxGrades]; // initialises array with maximum sizes
            }

            public void AddGrade(int grade)
            {
                if (gradeCount < Grades.Length) 
                {
                    Grades[gradeCount] = grade;
                    gradeCount++;
                }
                else
                {
                    Console.WriteLine("No more grades can be added.");
                }
            }

            public double GetAverageGrade()
            {
                if(gradeCount == 0)
                {
                    return 0; //Avoid division by zero
                }

                int sum = 0;
                for (int i = 0; i < gradeCount; i++)
                {
                    sum += Grades[i];
                }
                return (double)sum / gradeCount;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"ID: {Id}");
                Console.Write("Grades: ");
                for (int i = 0; i < gradeCount; i++)
                {
                    Console.Write(Grades[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Average Grade: {GetAverageGrade()}");
            }
        }
    }
}
