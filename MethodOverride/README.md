# 🐾 MethodOverride – Demonstrating Polymorphism in C#

This console application demonstrates **polymorphism** in C#, focusing on the use of the `virtual` and `override` keywords to change the behaviour of inherited methods.

---

## 🎯 Objective

To practise **method overriding** in object-oriented programming by creating a base `Animal` class and specialised derived classes (`Dog` and `Cat`) that modify the base method behaviour.

---

## 📌 Features

- **Virtual Methods** – Declared in the base class, can be overridden by derived classes.
- **Override Methods** – Implemented in subclasses to provide specific behaviour.
- **Base Method Access** – `base.MethodName()` allows calling the original base class method inside the overridden version.

---

## 🧱 Class Structure

```csharp
class Animal
{
    public void eat()
    {
        Console.WriteLine("Eating...");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes generic sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound(); // Calls base class method
        Console.WriteLine("Barking...");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat is meowing...");
    }
}

class Collie : Dog
{
    public void GoingNuts()
    {
        Console.WriteLine("Collie going nuts...");
    }
}
```

---

## 💡 Key Concepts

| Concept              | Applied In Code                                          |
|----------------------|-----------------------------------------------------------|
| Virtual Methods      | `Animal.MakeSound()` declared with `virtual` keyword     |
| Method Overriding    | `Dog` and `Cat` override `MakeSound()`                   |
| Base Method Call     | `Dog.MakeSound()` calls `base.MakeSound()`               |
| Inheritance          | Multiple levels (`Animal` → `Dog` → `Collie`)            |

---

## 💬 Example Output

```txt
Animal makes generic sound.
Barking...
Cat is meowing...
```

---

## ▶️ How to Run

Make sure you have .NET installed, then run:

```bash
cd MethodOverride
dotnet run
```