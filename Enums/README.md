# 🧩 Enums in C#

This project demonstrates how to use **Enums** in C#, which are **named constants** representing a set of fixed values. Enums improve code readability and make programs less error-prone compared to using plain integers or strings.

---

## 📘 Key Concepts

- **Enums are immutable** (their values cannot change once defined).
- **Enums must be declared at the namespace level** (outside any class).
- Each enum member has an underlying **integer value**, starting at `0` by default — unless explicitly set.
- You can **cast enum values to integers** and vice versa.

---

## 🧠 Example Code

```csharp
// Enums represent a set of named constants
enum Day { Mo, Tu, We, Th, Fr, Sa, Su };

// You can assign specific values
enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec }

internal class Program
{
    static void Main(string[] args)
    {
        Day fr = Day.Fr;
        Day a = Day.Fr;

        Console.WriteLine(fr == a); // true
        Console.WriteLine(Day.Mo);  // Mo
        Console.WriteLine((int)Day.Mo); // 0

        Console.WriteLine((int)Month.Feb); // 2
        Console.WriteLine((int)Month.Aug); // 13 (after Jul was set to 12)
    }
}
```

---

## 🧾 Output Example

```
True
Mo
0
2
13
```

---

## 💡 What You Learn

| Concept | Description |
|----------|--------------|
| **Enum Declaration** | Enums are defined with the `enum` keyword. |
| **Default Values** | Start from 0 and increase by 1 automatically. |
| **Custom Values** | You can set your own values (e.g. `Jan = 1`). |
| **Casting** | `(int)Month.Aug` converts an enum to its integer value. |
| **Comparison** | Enums can be compared directly (`fr == a`). |

---

## 🧱 Best Practices

- Use **PascalCase** for enum names and members (`Day`, `Month`, `Mo`, `Tu`).
- Keep enum definitions **outside the class** but within the **namespace**.
- Prefer enums over raw integers for representing fixed categories (e.g. days, months, states).

---

## ▶️ Run the Program

```bash
cd Enums
dotnet run
```

---

## 🧩 Use Cases

- Days of the week
- Order or payment status
- Game states
- Error codes
- Months or categories

---

Enums are an elegant way to **add meaning and structure** to numeric values — improving both **readability** and **maintainability** of your C# programs.
