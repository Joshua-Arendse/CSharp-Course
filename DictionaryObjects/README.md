# 🧾 Dictionary with Custom Objects in C# – Employee and State Lookup

This C# console application demonstrates how to use **Dictionaries** with both primitive and custom class values. The main use cases covered include mapping:

- Employee IDs to `Employee` objects (with name, age, and salary)
- State codes to full state names using string pairs

---

## 🚀 Features

- `Dictionary<int, Employee>` to store employee information by ID
- Custom `Employee` class with properties: `Name`, `Age`, and `Salary`
- Iteration through a dictionary of objects with formatted output
- `Dictionary<string, string>` example for state code lookups
- Safe retrieval using `.TryGetValue()` for non-crashing lookups

---

## 👨‍💼 Employee Class

```csharp
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}
```

---

## 📌 Sample Output

```
ID: 1 name: John Does earns 100000 and is 35 years old!
ID: 2 name: John Doesnt earns 200000 and is 25 years old!
ID: 3 name: John Wasnt earns 80000 and is 45 years old!
ID: 4 name: John Will earns 50000 and is 15 years old!
New York
The statecode name is NY and the state name is New York
The statecode name is CA and the state name is California
The statecode name is TX and the state name is Texas
```

---

## 🧠 Concepts Covered

| Concept                | Demonstrated |
|------------------------|--------------|
| Dictionary with Objects| ✅            |
| Custom Classes         | ✅            |
| `TryGetValue()` usage  | ✅            |
| Iterating with `foreach`| ✅          |
| Dictionary Initialisation| ✅         |

---

## ▶️ How to Run

Make sure you have the .NET SDK installed. Then run:

```bash
dotnet run
```