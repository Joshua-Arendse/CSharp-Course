# 🧬 InheritanceApp – Exploring Inheritance in C#

This beginner console app demonstrates the core concept of **inheritance** in object-oriented programming (OOP) using a hierarchy of animal classes. It shows how methods and properties can be inherited and extended through child classes.

---

## 🎯 Objective

To understand how **base classes** (parent) and **derived classes** (children) work together in C# by:
- Creating an animal hierarchy
- Demonstrating inherited behaviour
- Extending functionality through subclasses

---

## 📌 Features

| Feature                  | Description                                                                 |
|--------------------------|-----------------------------------------------------------------------------|
| Base Class               | `Animal` class with shared behaviour (`eat`)                                |
| Derived Classes          | `Dog`, `Cat`, and `Collie` inherit from `Animal`                            |
| Method Inheritance       | Child classes automatically inherit and use the `eat()` method              |
| Method Extension         | Each subclass adds its own specific behaviour (`Bark()`, `Meow()`, etc.)    |

---

## 🧱 Class Structure

```csharp
class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}

class Dog : Animal
{
    public void Bark() { Console.WriteLine("Barking..."); }
}

class Cat : Animal
{
    public void Meow() { Console.WriteLine("Cat is meowing..."); }
}

class Collie : Dog
{
    public void GoingNuts() { Console.WriteLine("Collie going nuts..."); }
}
```

---

## 💬 Key Concepts

| Concept         | Explanation                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| Inheritance     | Child classes (`Dog`, `Cat`, `Collie`) inherit behaviour from `Animal`      |
| Reusability     | Methods like `eat()` are reused in child classes without rewriting them     |
| Extensibility   | Subclasses can add new features without modifying the base class            |
| Multilevel Inheritance | `Collie` inherits from `Dog`, which inherits from `Animal`            |

---

## 🧪 Example Behaviour

You can create objects like:

```csharp
Dog dog = new Dog();
dog.eat();     // Inherited from Animal
dog.Bark();    // Defined in Dog

Collie collie = new Collie();
collie.eat();        // From Animal
collie.Bark();       // From Dog
collie.GoingNuts();  // Defined in Collie
```

---

## ▶️ Run the App

Ensure you have the .NET SDK installed, then:

```bash
cd InheritanceApp
dotnet run
```