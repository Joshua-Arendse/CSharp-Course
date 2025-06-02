# ClassesAndObjects – Building and Using Classes in C#

This project demonstrates the basics of object-oriented programming (OOP) in C#, focusing on how to define and use classes, constructors, member variables, and methods.

## 🧠 What You’ll Learn

- How to define a class (`Car`)
- The difference between fields (member variables) and methods
- Constructor overloading and default parameters
- How to create and interact with object instances

---

## 🚗 Project Summary

This program simulates basic behaviour of car objects by:

1. Creating `Car` objects using constructors
2. Displaying their details (name, horsepower, colour)
3. Performing actions like `Drive()` and `Stop()` based on user input

---

## 📦 Class: `Car`

### Fields:
- `_name` (string) – the name of the car
- `_hp` (int) – horsepower
- `_colour` (string) – car colour (default: "black")

### Methods:
- `Drive()` – Outputs that the car is driving
- `Stop()` – Outputs that the car has stopped
- `Details()` – Outputs the car's colour, name, and horsepower

### Constructor:
```csharp
public Car(string name, int hp = 0, string colour = "black")

### 🧪 Example Output

Audi A4 was created!
Audi A4 is driving
The blue car Audi A4 has 250 horsepower
BMW M5 was created!
BMW M5 is driving
The black car BMW M5 has 350 horsepower
Press 1 to stop the car.
1
Audi A4 stopped!

### 🚀 How to Run

Open the project in Visual Studio or VS Code

Run using:

dotnet run