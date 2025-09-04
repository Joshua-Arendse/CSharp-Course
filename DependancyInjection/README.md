# 🏗️ Dependency Injection – Builder Example

This project demonstrates the concept of **Dependency Injection (DI)** in C#.  
Instead of a class creating its own dependencies, they are provided (or *injected*) from the outside.  
This makes the code **more flexible, testable, and maintainable**.

---

## 📖 Concepts Covered
- **Without Dependency Injection**
  - `Builder` directly creates its own `Hammer` and `Saw`.
  - This tightly couples the `Builder` class to specific implementations.
- **With Constructor Dependency Injection**
  - Dependencies (`Hammer`, `Saw`) are passed into the `Builder` via its constructor.
  - This decouples the `Builder` from the specific tools, allowing reuse and easier testing.

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
    private Hammer _hammer;
    private Saw _saw;

    // Constructor Dependency Injection
    public Builder(Hammer hammer, Saw saw)
    {
        _hammer = hammer;
        _saw = saw;
    }

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House Built");
    }
}
```

---

## ▶️ Usage Example

```csharp
Hammer hammer = new Hammer();
Saw saw = new Saw();
Builder builder = new Builder(hammer, saw);

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
- What **Dependency Injection (DI)** is and why it’s useful.
- The difference between **tight coupling** and **loose coupling**.
- How DI makes code easier to **test** (you could swap `Hammer` for a `MockHammer` in unit tests).
- How to apply **Constructor Injection** as a simple DI technique.

---

## ▶️ Run the Program
```bash
cd DependencyInjection
dotnet run
```