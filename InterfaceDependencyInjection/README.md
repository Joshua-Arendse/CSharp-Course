# 🔧 Interface Dependency Injection

This project demonstrates **Interface-based Dependency Injection (DI)**.  
Instead of using constructors or setters, the class depends on an **interface** that defines methods for injecting dependencies.

---

## 📖 Concepts Covered
- **Without DI**
  - The `Builder` class creates its own tools (`Hammer`, `Saw`), making it tightly coupled.
- **With Interface Dependency Injection**
  - The `Builder` class implements an `IToolUser` interface.
  - Dependencies (`Hammer`, `Saw`) are injected via the **methods defined in the interface** (`SetHammer()`, `SetSaw()`).
  - This keeps the `Builder` flexible and decoupled from specific implementations.

---

## 🖥️ Example Code

```csharp
public interface IToolUser
{
    void SetHammer(Hammer hammer);
    void SetSaw(Saw saw);
}

public class Hammer
{
    public void Use() => Console.WriteLine("Hammering Nails!");
}

public class Saw
{
    public void Use() => Console.WriteLine("Sawing Wood");
}

public class Builder : IToolUser
{
    private Hammer _hammer;
    private Saw _saw;

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House Built");
    }

    public void SetHammer(Hammer hammer) => _hammer = hammer;
    public void SetSaw(Saw saw) => _saw = saw;
}
```

---

## ▶️ Usage Example

```csharp
Hammer hammer = new Hammer(); // Create dependencies externally
Saw saw = new Saw();

Builder builder = new Builder();
builder.SetHammer(hammer); // Inject via interface method
builder.SetSaw(saw);

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
- How to use **interfaces to define dependency injection contracts**.
- The difference between:
  - **Constructor Injection** → Dependencies injected at object creation.
  - **Setter Injection** → Dependencies injected via properties.
  - **Interface Injection** → Dependencies injected via methods from an interface.
- Interface Injection is **less common** but useful when:
  - You want strict enforcement that dependencies *must* be provided through specific methods.
  - You want **loose coupling** while supporting multiple dependency types dynamically.

---

## ▶️ Run the Program
```bash
cd InterfaceDependencyInjection
dotnet run
```