# 🧠 MethodsAndFunctionsPractice – Multi-Tool Console App in C#

This C# console application features **five distinct tools**, each implemented as a method-based mini-program. It's designed to strengthen your understanding of **functions, parameters, return types, recursion, and string manipulation**.

---

## 🧪 Tools Included

### 1. 🌡️ Degree Converter
Converts a user-input temperature between Celsius and Fahrenheit using appropriate formulas.

```csharp
ToCelsius(f)  = (5.0 / 9.0) * (f - 32)
ToFahrenheit(c) = (9.0 / 5.0) * c + 32
```

### 2. ➕ Simple Calculator
Performs basic arithmetic operations between two numbers:
- Addition
- Subtraction
- Multiplication
- Division (with zero check)

### 3. 🔁 String Reversal
Takes a sentence or word and returns the reverse using a loop-based method.

```csharp
ReverseString("hello") → "olleh"
```

### 4. ✳️ Factorial Calculator
Calculates the factorial of a number using **recursion**.

```csharp
Factorial(5) → 5 * 4 * 3 * 2 * 1 = 120
```

### 5. 🔄 Palindrome Checker
Checks if a word or sentence is a palindrome (ignoring case and spaces) by comparing it to its reverse.

```csharp
"racecar" → true  
"hello"   → false
```

---

## 📚 Concepts Practised

- ✅ Method declaration and usage
- ✅ Parameters and return types
- ✅ Conditional logic
- ✅ Recursion
- ✅ String manipulation
- ✅ Input handling and user interaction

---

## ▶️ How to Run

```bash
dotnet run
```

Each section will pause using `Console.ReadKey()` to allow for sequential interaction.

---

## 💡 Notes

- Uses `char.Parse()` for input operations; consider adding input validation for robustness.
- For palindrome checking, string input is trimmed, lowercased, and stripped of spaces before comparison.
- Factorial method uses recursion — which is elegant for small inputs but could be improved with iteration for larger numbers.

---

## 🚀 Future Enhancements

- Add a main menu system for navigating between tools.
- Enhance input validation using `TryParse()` methods.
- Add support for decimal input in the factorial and palindrome logic (for mathematical flexibility or Unicode strings).

---

This project is ideal for **mastering method structuring, logic building, and user input handling** in C#. 🧰
