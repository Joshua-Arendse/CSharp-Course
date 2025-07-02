# 🧮 OOP Calculator

A simple object-oriented C# console calculator. This project demonstrates encapsulation using a `Calculator` class with properties and methods for basic arithmetic operations. The user interacts through a text-based interface that supports repeated calculations.

---

## 🚀 Features

- Accepts two numbers from the user
- Performs addition, subtraction, multiplication, and division
- Looping interface for multiple calculations
- Division by zero handling
- Clean separation between UI and logic (OOP)

---

## 🧠 Concepts Practised

- Object-Oriented Programming (OOP)
- Properties and encapsulation
- Methods with return values
- Input handling and infinite loops
- Switch statements and error handling

---

## 🗂️ Project Structure

| File | Description |
|------|-------------|
| `Program.cs` | Main logic for user input, operation selection, and result output |
| `Calculator.cs` | Class with properties and methods for performing calculations |

---

## 🧪 Sample Output

```
Simple Calculator
Enter first number: 20
Enter second number: 5
Choose operation (+, -, *, /) or type 'exit' to quit: *
Result: 100

Simple Calculator
Enter first number: 10
Enter second number: 0
Choose operation (+, -, *, /) or type 'exit' to quit: /
Error: Cannot divide by zero.
Result: NaN
```

---

## ▶️ How to Run

1. Open the folder in **Visual Studio** or **VS Code**
2. Make sure the [.NET SDK](https://dotnet.microsoft.com/download) is installed
3. In the terminal:

```bash
dotnet run
```