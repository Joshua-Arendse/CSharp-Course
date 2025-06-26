namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();

            while (true)
            {
                Console.WriteLine("\nTo-Do List Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add a new task
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter due date (optional, format YYYY-MM-DD or press Enter): ");
                        string dueDateInput = Console.ReadLine();
                        DateTime? dueDate = null;
                        if (!string.IsNullOrWhiteSpace(dueDateInput))
                        {
                            dueDate = DateTime.Parse(dueDateInput);
                        }

                        taskList.Add(new Task(description, dueDate));
                        Console.WriteLine("Task added!");
                        break;

                    case "2":
                        // View all tasks
                        Console.WriteLine("\nAll Tasks:");
                        foreach (var task in taskList)
                        {
                            task.DisplayTask();
                        }
                        break;

                    case "3":
                        // Mark a task as completed
                        Console.WriteLine("\nTasks to Mark as Completed:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {taskList[i].Description}");
                        }

                        Console.Write("Enter the task number to mark as completed: ");
                        int taskNumber = int.Parse(Console.ReadLine());
                        if (taskNumber > 0 && taskNumber <= taskList.Count)
                        {
                            taskList[taskNumber - 1].MarkAsCompleted();
                            Console.WriteLine("Task marked as completed!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;

                    case "4":
                        // Exit the program
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
