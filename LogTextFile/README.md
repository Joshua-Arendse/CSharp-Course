# 🏗️ ConstructorInheritance2 – Multi-Level Constructor Inheritance in C#

This console application demonstrates **multi-level constructor inheritance** in C#, where a derived class inherits from another derived class, forming a chain of constructors.

---

## 🎯 Objective

To understand how constructor chaining works **across multiple levels of inheritance** (`Person → Employee → Manager`) and how to initialise and display data for each class.

---

## 📌 Features

- **Base Class (`Person`)** – Holds common properties (`Name`, `Age`).
- **Derived Class (`Employee`)** – Extends `Person` with job-related details.
- **Further Derived Class (`Manager`)** – Extends `Employee` with leadership-specific details.
- **Constructor Chaining** – Uses `: base(...)` to ensure proper initialisation.
- **Method Reuse** – Higher-level methods call base class methods to avoid repetition.

---

## 🧱 Class Structure

```csharp
public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person constructor called");
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Person
{
    public string JobTitle { get; private set; }
    public int EmployeeID { get; private set; }

    public Employee(string name, int age, string jobTitle, int employeeID)
        : base(name, age)
    {
        JobTitle = jobTitle;
        EmployeeID = employeeID;
        Console.WriteLine("Employee (derived class) constructor called");
    }

    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();
        Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
    }
}

public class Manager : Employee
{
    public int TeamSize { get; private set; }

    public Manager(string name, int age, string jobTitle, int employeeID, int teamSize)
        : base(name, age, jobTitle, employeeID)
    {
        TeamSize = teamSize;
    }

    public void DisplayManagerInfo()
    {
        DisplayEmployeeInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}
```

---

## 💡 Key Concepts

| Concept                   | Applied In Code                                          |
|----------------------------|----------------------------------------------------------|
| Inheritance                | `Employee` inherits `Person`, `Manager` inherits `Employee` |
| Multi-level Constructor    | `Manager → Employee → Person`                           |
| Constructor Chaining       | `: base(...)` used in both `Employee` and `Manager`     |
| Method Reuse               | `DisplayManagerInfo()` calls `DisplayEmployeeInfo()`    |

---

## 💬 Example Output

```txt
Person constructor called
Employee (derived class) constructor called
Name: Joe, Age: 36
Job Title: Sales Rep, Employee ID: 12345

Person constructor called
Employee (derived class) constructor called
Name: Carl, Age: 45
Job Title: Manager, Employee ID: 1234565
Team Size: 7
```

---

## ▶️ How to Run

Make sure you have .NET installed, then run:

```bash
cd ConstructorInheritance2
dotnet run
```