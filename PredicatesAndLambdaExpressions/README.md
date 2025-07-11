# 🧠 Predicates & Lambda Expressions in C#

This C# console app demonstrates how to use **Predicates** and **Lambda Expressions** with a `List<T>`. The goal is to understand how to filter collections based on conditions using concise and readable syntax.

---

## 🚀 Features

- Uses `Predicate<T>` to define filter logic
- Applies `.FindAll()` on a list with a lambda expression
- Demonstrates how to write inline and reusable filter conditions
- Shows how lambda syntax translates logic into expressive one-liners

---

## 🧠 Concepts Practised

- ✅ Lambda expressions: `x => x >= 10`
- ✅ Predicate delegates
- ✅ Filtering with `.FindAll()`
- ✅ `List<T>` and collection processing
- ✅ Functional thinking and concise syntax

---

## 🧪 Sample Output

```
All numbers 10 and above:
10
15
25
18
```

---

## 🔍 Key Explanation

```csharp
Predicate<int> isGreaterThanTen = x => x >= 10;
List<int> filtered = numbers.FindAll(isGreaterThanTen);
```

This declares a **predicate** that evaluates whether a number is greater than or equal to 10, and then applies it to filter the list.

---

## ▶️ How to Run

Make sure you have the .NET SDK installed.

```bash
dotnet run