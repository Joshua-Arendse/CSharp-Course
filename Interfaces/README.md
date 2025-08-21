# 🐾 Interfaces in C#

This project demonstrates the use of **interfaces** in C#. An `IAnimal` interface is defined with two methods (`MakeSound` and `Eat`), which are then implemented by two classes: `Dog` and `Cat`.

---

## 📖 Concepts Covered
- **Interfaces**
  - Declared using the `interface` keyword.
  - Contains only method signatures (no implementation).
  - Naming convention: usually starts with `I` (e.g., `IAnimal`).

- **Implementing Interfaces**
  - Classes (`Dog`, `Cat`) implement `IAnimal`.
  - Must provide concrete implementations for all methods defined in the interface.

- **Polymorphism**
  - Different classes can implement the same interface in unique ways.
  - Allows for flexible and reusable code.

---

## 🖥️ Example Code

```csharp
public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
}

public class Dog : IAnimal
{
    public void MakeSound() => Console.WriteLine("Bark");
    public void Eat(string food) => Console.WriteLine("Dog ate " + food);
}

public class Cat : IAnimal
{
    public void MakeSound() => Console.WriteLine("Meow");
    public void Eat(string food) => Console.WriteLine("Cat ate " + food);
}
```

**Usage:**
```csharp
Dog dog = new Dog();
dog.MakeSound();
dog.Eat("Treat");

Cat cat = new Cat();
cat.MakeSound();
cat.Eat("Fish");
```

**Output:**
```
Bark
Dog ate Treat
Meow
Cat ate Fish
```

---

## 🧠 What You Learn
- How to declare and use an **interface** in C#.
- How classes can **implement** an interface with their own behaviour.
- Why interfaces are useful for achieving **polymorphism** and **loose coupling**.

---

## ▶️ Run the Program
```bash
cd Interfaces
dotnet run
```
