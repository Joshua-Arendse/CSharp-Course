# ✅ ToDoList – Console-Based Task Manager in C#

**ToDoList** is a simple C# console application for managing a list of tasks. Users can add tasks, view them, mark them as completed, and optionally assign due dates. It demonstrates class usage, nullable types, and interactive menus.

---

## 📚 Concepts Practised

- ✅ Custom classes (`Task`)
- ✅ Lists (`List<T>`)
- ✅ Nullable types (`DateTime?`)
- ✅ Console menu navigation
- ✅ Input validation
- ✅ Method encapsulation

---

## 🧾 Features

- 📌 Add a task with optional due date
- 🗂 View all tasks
- ✔️ Mark tasks as completed
- 🛑 Exit program gracefully
- 🧠 Uses a `while(true)` loop and `switch` statement for a menu-driven experience

---

## 🧩 Class: `Task`

```csharp
public class Task
{
    public string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? DueDate { get; set; }

    public void MarkAsCompleted();
    public void DisplayTask();
}
```

- Uses a nullable `DateTime?` to allow tasks without a due date
- Has a clear separation between data and behaviour (methods for display and state update)

---

## 💻 Sample Output

```
To-Do List Menu:
1. Add Task
2. View All Tasks
3. Mark Task as Completed
4. Exit
Choose an option: 1
Enter task description: Submit assignment
Enter due date (optional, format YYYY-MM-DD or press Enter): 2025-07-15
Task added!

To-Do List Menu:
1. Add Task
2. View All Tasks
3. Mark Task as Completed
4. Exit
Choose an option: 2

All Tasks:
Task: Submit assignment
Completed: False
Due Date: 2025/07/15
```

---

## ▶️ How to Run

```bash
dotnet run
```

Ensure both files are in the same project under the `ToDoList` namespace:
- `Program.cs`
- `Task.cs`

---

## 🔧 Possible Enhancements

- Add task priority or category
- Allow task deletion or editing
- Save/load tasks from a file
- Colour-code completed vs pending tasks
- Sort tasks by due date or completion status

---

This project offers a hands-on approach to applying OOP, working with collections, and building interactive console applications. A great beginner portfolio project! 🗃️
