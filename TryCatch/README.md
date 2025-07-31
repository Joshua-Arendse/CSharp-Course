# 🛠️ TryCatch – Exception Handling in C#

This C# console application demonstrates how to handle runtime exceptions gracefully using the `try-catch-finally` structure. It includes user input, division logic, and error reporting via both console and debug output.

---

## 🎯 Objective

To safely divide a number by user input and handle any runtime errors such as dividing by zero or entering invalid input (like letters).

---

## 📌 Features

| Feature                         | Description                                                                 |
|----------------------------------|-----------------------------------------------------------------------------|
| `try` block                     | Wraps code that might cause an exception                                   |
| `catch (Exception ex)`          | Catches any exception and shows a user-friendly error message              |
| `ex.Message`                    | Displays a concise description of the exception                            |
| `Debug.WriteLine()`             | Writes full error details to the Debug output during development           |
| `finally` block                 | Executes cleanup code regardless of whether an error occurred              |

---

## 🧪 How It Works

```csharp
try
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = 2;
    result = num2 / num1;
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    Debug.WriteLine(ex.ToString());
}
finally
{
    Console.WriteLine("This always executes");
}
```

---

## 🧠 Concepts Practised

| Concept                | Description                                        |
|------------------------|----------------------------------------------------|
| Exception Handling     | Prevents application crashes using `try-catch`     |
| Input Validation       | Parses input and handles conversion errors         |
| Debugging Support      | Uses `System.Diagnostics.Debug` for dev messages   |
| Finalisation Logic     | Ensures that post-error logic always runs          |

---

## ▶️ Run the App

Ensure you have the .NET SDK installed, then:

```bash
cd TryCatch
dotnet run
```