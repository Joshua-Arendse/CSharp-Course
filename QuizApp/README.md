# ❓ QuizApp – Simple Console Quiz in C#

This project is a simple console-based quiz game that tests the user with three questions. It demonstrates how to gather input, compare answers, track score, and display results in a user-friendly format.

---

## 📚 Concepts Practised

- ✅ `Console.ReadLine()` input handling
- ✅ String comparison with `.ToLower()` and `.Trim()`
- ✅ Conditional logic (`if-else`)
- ✅ Score tracking using an `int` counter
- ✅ Output formatting with `Console.WriteLine()` and string interpolation

---

## 📋 Questions in the Quiz

1. **What is the capital of Germany?** → `Berlin`  
2. **What is 2+2?** → `4`  
3. **What is the colour you get by mixing blue and yellow?** → `Green`

---

## 🧪 Example Output

What is the capital of Germany?

berlin
Correct!
What is 2+2
5
Incorrect it is: 4
What is the colour you get by mixing blue and yellow?
green
Correct!
Quiz Completed! You have scored 2/3.
You did not get all question right, better luck next time.

---

## 🧠 Key Features

- Answers are case-insensitive and whitespace-tolerant
- Uses `.Trim()` and `.ToLower()` for fair answer evaluation
- Final score feedback changes depending on performance

---

## ▶️ How to Run

```bash
dotnet run
