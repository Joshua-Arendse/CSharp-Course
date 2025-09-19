# 🖨️ Multiple Inheritance in C#

This project demonstrates how **C# supports multiple inheritance** through **interfaces**, since a class in C# cannot directly inherit from more than one base class.

---

## 📖 Concepts Covered
- **Interfaces** allow a class to inherit behaviour contracts from multiple sources.
- A class can implement **multiple interfaces** but can only inherit from **one base class**.
- This enables **flexibility** without the complications of multiple class inheritance.

---

## 🖥️ Example Code

```csharp
public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public class MultiFunctionPrinter : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document");
    }
}
```

---

## ▶️ Usage Example

```csharp
MultiFunctionPrinter printer = new MultiFunctionPrinter();
printer.Print();
printer.Scan();
```

---

## ✅ Output

```
Printing document
Scanning document
```

---

## 🧠 What You Learn
- A class can implement **multiple interfaces** in C#.
- Interfaces define **contracts** (methods without implementation) that a class must fulfil.
- This approach is often used to:
  - Combine behaviours (e.g., printing + scanning).
  - Promote **decoupling** and **code reusability**.
  - Avoid the "diamond problem" of multiple class inheritance.

---

## ▶️ Run the Program
```bash
cd MultipleInheritance
dotnet run
```