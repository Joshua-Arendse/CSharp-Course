# ⚠️ ThrowExceptions – Manual Exception Throwing in C#

This beginner-level console app demonstrates how to use the `throw` keyword in C# to manually trigger exceptions when user input is invalid. It validates a user’s age and throws meaningful error messages if the input is not acceptable.

---

## 🎯 Objective

To practise manually throwing exceptions using `throw` for:
- Invalid data types (e.g., letters instead of numbers)
- Illogical values (e.g., negative age or unrealistic age)

---

## 📌 Features

| Feature                 | Description                                                                 |
|-------------------------|-----------------------------------------------------------------------------|
| `throw new Exception()` | Manually creates and throws exceptions for invalid input                   |
| Input validation        | Ensures that user input is both a number and within a logical range        |
| Custom error messages   | Tells the user exactly what went wrong                                     |
| Encapsulation           | Validates data inside a separate method `GetUserAge()`                     |

---

## 🧪 Code Breakdown

```csharp
static int GetUserAge(string input)
{
    int age;
    if (!int.TryParse(input, out age))
    {
        throw new Exception("You didn't enter a valid age.");
    }
    if (age < 0 || age > 120)
    {
        throw new Exception("Your age must be between 0 and 120");
    }
    return age;
}
```

---

## 💬 How It Works

1. Asks the user to enter their age.
2. Validates the input:
   - If it's not a number → throws a custom exception.
   - If it's outside a realistic range → throws a different custom exception.
3. If input is valid → continues without errors.

---

## 🧠 Concepts Practised

| Concept             | Explanation                                          |
|---------------------|------------------------------------------------------|
| Exception Throwing  | Intentionally triggering errors using `throw`        |
| Defensive Coding    | Preventing invalid states early                      |
| Input Validation    | Checking both data type and value range              |
| Method Usage        | Splitting logic into clean, reusable methods         |

---

## ▶️ Run the App

Make sure you have the .NET SDK installed, then:

```bash
cd ThrowExceptions
dotnet run
```

---

## 💡 Example Output

```
Enter your age:
abc
Unhandled exception. System.Exception: You didn't enter a valid age.
```