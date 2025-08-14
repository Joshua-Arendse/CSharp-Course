# 🏗️ ConstructorInheritance – Demonstrating Constructor Chaining in C#

This console application demonstrates **constructor inheritance** in C#, showing how a derived class can call and extend the constructor of a base class.

---

## 🎯 Objective

To understand how **constructor chaining** works between a base (`Person`) and a derived (`Employee`) class, and how to initialise shared and unique properties effectively.

---

## 📌 Features

- **Base Class Constructor** – Initialises common properties (`Name`, `Age`).
- **Derived Class Constructor** – Calls the base constructor with `: base(...)` and sets additional properties.
- **Method Reuse** – The derived class calls methods from the base class.

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
```

---

## 💡 Key Concepts

| Concept               | Applied In Code                                           |
|-----------------------|------------------------------------------------------------|
| Inheritance           | `Employee` inherits from `Person`                         |
| Constructor Chaining  | `: base(name, age)` in `Employee` constructor              |
| Property Initialisation| Shared props in base, unique props in derived class       |
| Method Reuse          | `DisplayPersonInfo()` called inside `DisplayEmployeeInfo()`|

---

## 💬 Example Output

```txt
Person constructor called
Employee (derived class) constructor called
Name: Joe, Age: 36
Job Title: Sales Rep, Employee ID: 12345
```

---

## ▶️ How to Run

Make sure you have .NET installed, then run:

```bash
cd ConstructorInheritance
dotnet run
```