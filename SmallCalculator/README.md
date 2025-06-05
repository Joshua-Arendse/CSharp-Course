# 🧮 SmallCalculator – Basic Integer Addition in C#

This project demonstrates how to read user input from the console, convert string inputs into integers, and calculate the sum using both `Convert.ToInt32()` and `int.Parse()` methods.

---

## 📚 Concepts Practised

- ✅ Reading user input via `Console.ReadLine()`
- ✅ Type conversion from `string` to `int`
- ✅ Using `Convert.ToInt32()` and `int.Parse()`
- ✅ Variable declaration and arithmetic
- ✅ Output formatting with `Console.WriteLine()`

---

## 🧾 Summary

The program guides the user through two addition operations:

1. **First method:**  
   Uses `Convert.ToInt32()` to convert input strings into integers before performing addition.

2. **Second method:**  
   Uses `int.Parse()` directly within the `ReadLine()` statement to simplify input conversion.

---

## 🧪 Example Output

Enter the first whole number:
10
Enter the second whole number:
20
The Sum of 10 and 20 is equal to 30
Enter the first whole number:
5
Enter the second whole number:
15
The Sum of 5 and 15 is equal to 20


---

## ❗ Error Handling Note

- If the user enters **non-numeric characters**, both `Convert.ToInt32()` and `int.Parse()` will throw a runtime exception.
- No validation is included — this is a raw demonstration of conversion and parsing.

---

## ▶️ How to Run

```bash
dotnet run
