# 👔 Employee Directory – Dictionary Lookup and LINQ Filtering

This C# console application demonstrates a basic **employee management system** using a `Dictionary<int, Employee>` for efficient data lookup and manipulation. It covers key .NET topics like class objects, dictionary methods, and LINQ-based filtering.

---

## 🎯 Project Objectives

- Create a `Dictionary<int, Employee>` to store employee data.
- Allow the user to:
  - 🔍 Look up employees by their ID
  - ➕ Add a new employee if the ID is not in use
  - 🗂️ Filter and display all employees from a specific department

---

## 🧱 Key Features

| Feature                         | Method Used                        |
|----------------------------------|-------------------------------------|
| Employee lookup by ID            | `TryGetValue()`                     |
| Add employee if ID doesn’t exist | `TryAdd()`                          |
| Filter employees by department   | `LINQ` (`Where()` + `ToList()`)     |
| Display multiple records         | `foreach` / `.ForEach()`            |

---

## 🧑‍💼 Sample Employee Data

```csharp
Dictionary<int, Employee> staff = new Dictionary<int, Employee>
{
    [1] = new Employee { Name = "Jeff", Department = "IT", Salary = 50000 },
    [2] = new Employee { Name = "Bob", Department = "CSD", Salary = 8000 },
    [3] = new Employee { Name = "Sam", Department = "IT", Salary = 12000 },
    [4] = new Employee { Name = "Dave", Department = "CSD", Salary = 10000 },
    [5] = new Employee { Name = "Luke", Department = "Sales", Salary = 25000 }
};
```

---

## 🔍 Sample Functional Flow

1. **Search by ID**
   - Input: `2`
   - Output: `Bob, CSD, R8000`

2. **Add New Employee**
   - ID: `6`
   - Name: `Jane`
   - Department: `HR`
   - Salary: `30000`

3. **List Employees in Department**
   - Input: `IT`
   - Output:
     ```
     Jeff, R50000
     Sam, R12000
     ```

---

## 📦 Concepts Practised

| Concept                | Description                                  |
|------------------------|----------------------------------------------|
| Classes & Properties   | Custom `Employee` class with fields          |
| Dictionaries           | Storing and accessing data via keys          |
| LINQ                   | `.Where()`, `.ToList()`, `.ForEach()`        |
| Input Validation       | `int.TryParse()` for safe user input         |
| Conditional Logic      | `if` / `else` to guide user interaction      |

---

## ▶️ How to Run

Make sure you have the .NET SDK installed.

```bash
cd EmployeeDirectory
dotnet run
```