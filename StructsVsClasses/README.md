# ⚖️ Structs vs Classes in C#

This project demonstrates the **difference between value types (structs)** and **reference types (classes)** in C#.

---

## 📖 Features
- Defines a **struct `Point`** (value type) and a **class `PointClass`** (reference type).
- Shows how **assignment behaves differently**:
  - Struct assignment creates a **copy**.
  - Class assignment creates a **reference** to the same object.
- Demonstrates modifying one variable and observing its effect (or lack thereof) on the other.
- Uses `.Equals()` to check object equality in classes.

---

## 🖥️ Example Code

```csharp
// Struct (Value Type)
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: {X},{Y}");
    }
}

// Class (Reference Type)
public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }

    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: {X},{Y}");
    }
}
```

---

## ▶️ Example Output

```
Point: 10,20
Point: 10,20
After changing p2.X to 25
Point: 10,20
Point: 25,20
NOW COME THE CLASS OBJECTS
Point: 1,2
Point: 1,2
After changing pC2.X to 3
Point: 3,2
Point: 3,2
is it equal?: True
```

---

## 🧠 What You Learn
- **Structs (Value Types):**
  - Stored on the **stack**.
  - Copying creates a **new, independent instance**.
  - Changes in one do not affect the other.
- **Classes (Reference Types):**
  - Stored on the **heap**, with variables holding references.
  - Copying a class variable means **both point to the same object**.
  - Changes in one reflect in the other.

---

## 📊 Visual Explanation

**Struct (Value Type)**
```
p1 ---> [10,20]
p2 ---> [10,20] (independent copy)
```

**Class (Reference Type)**
```
pC1 ---> [1,2]
pC2 ----^ (both reference the same object)
```

---

## ▶️ Run the Program
```bash
cd StructsVsClasses
dotnet run
```
