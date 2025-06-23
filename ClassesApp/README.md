# 🧱 ClassesApp – Object-Oriented Programming in C#

This C# console application demonstrates key **object-oriented programming (OOP)** principles through three custom classes: `Car`, `Customer`, and `Rectangle`. It covers constructors, properties, access modifiers, computed values, method usage, static members, and more.

---

## 📚 Concepts Practised

- ✅ Object creation & constructors (default and custom)
- ✅ Properties (get, set, read-only, write-only, computed)
- ✅ Access modifiers (`private`, `internal`, `readonly`, `const`)
- ✅ Static fields
- ✅ Named parameters
- ✅ Method encapsulation

---

## 🧩 Classes Overview

### 🚗 `Car` Class

Represents a car with model, brand, and luxury status.

**Features:**
- Custom constructor with `model`, `brand`, `isLuxury`
- Getter/setter for `Model`, `IsLuxury`
- Conditional logic in `Brand` property
- Console feedback on object creation
- `Drive()` method to simulate car action

```csharp
Car audi = new Car("A3", "Audi", false);
audi.Drive();
```

---

### 👤 `Customer` Class

Represents a customer with an auto-incremented ID and optional address/phone.

**Features:**
- Static field `nextId` for auto-assigned `Id`
- Read-only `Id` property
- Write-only `Password` property
- Overloaded constructors
- `SetDetails()` and `GetDetails()` methods
- Uses default parameter values

```csharp
Customer bob = new Customer("Bob", "Main St", "0712345678");
bob.Password = "secure123!";
bob.GetDetails();
```

---

### 🟥 `Rectangle` Class

Models a geometric rectangle with calculated area and appearance.

**Features:**
- `const` field for `NumberOfCorners`
- `readonly` field for colour
- Properties: `Width`, `Height`, `Area` (read-only)
- Constructor sets colour
- Method `DisplayDetails()` prints rectangle stats

```csharp
Rectangle r1 = new Rectangle("Red") { Width = 5, Height = 4 };
Console.WriteLine(r1.Area);  // 20
```

---

## 🧾 Program Highlights

- Modifies properties using user input (`audi.Brand = Console.ReadLine();`)
- Demonstrates named parameters with:
```csharp
Addnum(firstNum: 15, secondNum: 25);
```
- Calculates computed area via:
```csharp
public double Area => Width * Height;
```

---

## 🧪 Sample Output

```
A Audi of the model A3 has been created!
Brand is Audi
Brand is BMW - Luxury Edition
The customers name is Earl
Please enter customers name
Details about my new customer: Bob
I'm a A3 and I'm driving
I'm a i7 and I'm driving
Area of r1 is25
Details about the customer: Name is John Doe and ID is 1 ad the passsword is 
Colour: Red, Width: 0, Height: 0, Area: 0, Number of Corners: 4
```

---

## ▶️ How to Run

```bash
dotnet run
```

Ensure all classes are in the same namespace/project folder.

---

## 🔧 Notes

- Uses both auto-properties and full backing fields.
- Demonstrates encapsulation and constructor chaining.
- Computed properties and immutability (`readonly`) are well-modelled.
- Good real-world example of modelling customers and physical objects (cars, rectangles).

---

This project provides a solid foundation in **OOP concepts and class design** using C#. Ideal for learners stepping into object-oriented architecture. 🧱
