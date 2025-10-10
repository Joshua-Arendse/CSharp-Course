# 🧮 MathClass in C#

This project demonstrates how to use the **`System.Math`** class in C# to perform a variety of mathematical operations such as rounding, powers, roots, trigonometry, and absolute value calculations.

---

## 📘 Key Concepts

- Using `Math.Ceiling()` and `Math.Floor()` for rounding numbers up or down  
- Comparing values using `Math.Min()` and `Math.Max()`  
- Calculating exponents and roots with `Math.Pow()` and `Math.Sqrt()`  
- Using the mathematical constant `Math.PI`  
- Finding absolute values and cosine values with `Math.Abs()` and `Math.Cos()`  
- Applying maths functions in practical scenarios (areas, conversions, random values)

---

## 🧾 Output Example

    Ceiling: 16
    Floor: 15
    Lower of num1 13 and num2 9 is 9
    Higher of num1 13 and num2 9 is 13
    3 to the power of 5 is 243
    PI is: 3.141592653589793
    The square root of 25 is 5
    Always positive is 25
    cos of 1 is: 0.54030230586814

---

## 💡 What You Learn

| Concept | Description |
|---------|-------------|
| **Math.Ceiling()** | Rounds a number *up* to the nearest integer |
| **Math.Floor()** | Rounds a number *down* to the nearest integer |
| **Math.Min() / Math.Max()** | Returns the smaller or larger of two values |
| **Math.Pow()** | Raises a number to a given power |
| **Math.Sqrt()** | Calculates the square root |
| **Math.Abs()** | Returns the absolute (positive) value |
| **Math.PI** | The constant π (Pi ≈ 3.14159) |
| **Math.Cos()** | Returns the cosine of an angle (in radians) |

---

## 🧩 Bonus Examples

**Calculate the area of a circle**
    
    double radius = 5;
    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"Area of circle: {area:F2}");

**Generate a random integer between two values**
    
    Random rand = new Random();
    int randomNumber = rand.Next(1, 101);
    Console.WriteLine($"Random number: {randomNumber}");

**Convert degrees to radians**
    
    double radians = degrees * (Math.PI / 180);

---

## ▶️ Run the Program

    cd MathClass
    dotnet run

---

## 🧱 Summary

This project strengthens your understanding of the **C# `Math` class** and its core functions. After working through it you will be able to:

- Perform precise numerical operations  
- Round and compare numbers  
- Use mathematical constants and functions in practical code  
- Build small utilities such as calculators, geometry helpers, or random-value generators
