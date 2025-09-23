# 🟦 Structs in C#

This project demonstrates how to use **structs** in C#, showing immutability, copying behaviour, and methods within a struct.

---

## 📖 Features
- Defines a **`Point` struct** with:
  - **Immutable properties** (`X` and `Y`).
  - A **constructor** to initialise values.
  - A **method** to calculate the distance between two points.
  - A **Display()** method to print point coordinates.
- Demonstrates **value-type behaviour**:
  - Assigning one struct to another **copies values** rather than referencing the same object.
- Uses **formatted output** to display distances with two decimal places.

---

## 🖥️ Example Code

```csharp
public struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point other)
    {
        double dx = other.X - X;
        double dy = other.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X},{Y})");
    }
}
```

---

## ▶️ Example Output

```
Point: (10,20)
Point: (20,30)
Point: (10,20)
Point: (10,20)
Distance between points: 14.14
```

---

## 🧠 What You Learn
- **Struct basics** in C#:
  - Structs are **value types**, not reference types.
  - Assigning one struct to another creates a **copy**, not a reference.
- **Immutability** in structs:
  - Using **readonly properties** to prevent modification after creation.
- Using **methods inside structs** (e.g., distance calculation).

---

## ▶️ Run the Program
```bash
cd Structs
dotnet run
```