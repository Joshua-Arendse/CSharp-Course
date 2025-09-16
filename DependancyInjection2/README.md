# 🏗️ Dependency Injection 2 – Setter Injection

This project builds on the Dependency Injection (DI) concept by showing how to use **Setter Injection**.  
Instead of injecting dependencies via the constructor, they are provided using **public properties (setters)**.

---

## 📖 Concepts Covered
- **Without DI**
  - The `Builder` would create its own tools (`Hammer`, `Saw`), tightly coupling the code.
- **With Setter Dependency Injection**
  - Dependencies are passed into the `Builder` class using **properties** (`Hammer`, `Saw`).
  - This makes it easy to swap or replace dependencies *after* object creation.

---

## 🖥️ Example Code

```csharp
public class Hammer
{
    public void Use()
    {
        Console.WriteLine("Hammering Nails!");
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing Wood");
    }
}

public class Builder
{
    public Hammer Hammer { get; set; }
    public Saw Saw { get; set; }

    // Setter Dependency Injection
    public void BuildHouse()
    {
        Hammer.Use();
        Saw.Use();
        Console.WriteLine("House Built");
    }
}
```

---

## ▶️ Usage Example

```csharp
Hammer hammer = new Hammer();
Saw saw = new Saw();

Builder builder = new Builder();
builder.Hammer = hammer; // Inject dependencies via setters
builder.Saw = saw;

builder.BuildHouse();
```

---

## ✅ Output

```
Hammering Nails!
Sawing Wood
House Built
```

---

## 🧠 What You Learn
- The difference between **Constructor Injection** and **Setter Injection**.
- Setter Injection allows:
  - More **flexibility** (dependencies can be changed after object creation).
  - But comes with a trade-off: the object can exist in an **incomplete state** if the dependencies are not set before use.
- Why DI makes your code **loosely coupled** and more maintainable.

---

## ▶️ Run the Program
```bash
cd DependencyInjection2
dotnet run
```