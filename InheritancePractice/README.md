# 🚗 Inheritance Practice

This project demonstrates **inheritance** in C#, showing how a base class (`Vehicle`) can be extended by a derived class (`Car`) while overriding methods.

---

## 📖 Concepts Covered
- **Base Class (`Vehicle`)**
  - Properties: `Make`, `Model`, `Year`.
  - Constructor to initialise these values.
  - `DisplayInfo()` method marked as `virtual` (allowing overrides).

- **Derived Class (`Car`)**
  - Inherits from `Vehicle`.
  - Adds its own property: `NumDoors`.
  - Calls the base constructor with `: base(make, model, year)`.
  - Overrides the `DisplayInfo()` method to provide additional detail.

---

## 🖥️ Example Code

```csharp
Car car1 = new Car("BMW", "i8", 2025, 2);
car1.DisplayInfo();
```

**Output:**
```
This Car is a BMW:i8 made in 2025 with 2 doors.
```

---

## 🧠 What You Learn
- How to define a **base class** with shared properties and methods.
- How to create a **derived class** that adds its own functionality.
- The use of `virtual` (base) and `override` (derived) keywords.
- How constructors in derived classes can call **base constructors** with `: base()`.

---

## ▶️ Run the Program
```bash
cd InheritancePractice
dotnet run
```
