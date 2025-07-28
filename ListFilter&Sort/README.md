# 🔢 List Filter and Sort – Lambda Challenge in C#

This beginner-friendly C# console project demonstrates how to filter and sort a list using only **lambda expressions** and built-in list methods—**no loops** allowed!

---

## 🎯 Challenge Description

- Start with a predefined list of integers.
- Remove all numbers **less than 50**.
- Sort the remaining numbers in **descending order**.
- Display the final sorted list using a `ForEach` lambda.

---

## 🧪 Sample Data

Initial list:
```csharp
List<int> numbers = new List<int> { 
    12, 324, 2543, 123, 12, 6757, 978, 12, 67, 98, 64, 57, 24, 14, 18, 723, 73, 18, 38, 49, 47 
};
```

---

## 🔍 Lambda-Only Approach

```csharp
numbers.RemoveAll(x => x < 50);  // Filter out all numbers < 50
numbers.Sort();                  // Sort in ascending order
numbers.Reverse();               // Convert to descending order
numbers.ForEach(x => Console.WriteLine(x)); // Output
```

---

## 🧠 Concepts Covered

| Concept                | Demonstrated |
|------------------------|--------------|
| List Filtering         | ✅ `.RemoveAll(lambda)` |
| Sorting Lists          | ✅ `.Sort()`, `.Reverse()` |
| Lambda Expressions     | ✅ All logic via lambdas |
| Functional Output      | ✅ `.ForEach(lambda)` |
| No Manual Loops        | ✅ Challenge constraint |

---

## ▶️ How to Run

Make sure you have the .NET SDK installed. Then run:

```bash
dotnet run
```