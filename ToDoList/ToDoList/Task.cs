using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Task
    {
        public string Description {  get; set; }
        public bool IsComplete {  get; set; }
        public DateTime? DueDate { get; set; } // ? makes the datetime nullable meaning it doesnt have to have a value

        public Task(string description, DateTime? dueDate = null)
        {
            Description = description;
            DueDate = dueDate;
            IsComplete = false;
        }

        public void MarkAsCompleted()
        {
            IsComplete = true;
        }

        public void DisplayTask()
        {
            Console.WriteLine($"Task: {Description}");
            Console.WriteLine($"Completed: {IsComplete}");
            if (DueDate.HasValue)
            {
                Console.WriteLine($"Due Date: {DueDate.Value.ToShortDateString()}");
            }
            Console.WriteLine();
        }
    }
}
