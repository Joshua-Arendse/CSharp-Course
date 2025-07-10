# 📋 Lists in C#

This beginner-friendly C# console app explores core functionality of the `List<T>` class. It demonstrates how to create, modify, sort, and filter generic lists using string and integer examples.

---

## 🚀 Features

- Create and add elements to lists
- Remove items (including all occurrences of a value)
- Use `foreach` loops to display list contents
- Initialise a list using collection initialiser syntax
- Sort a list using `.Sort()`
- Filter a list using `.FindAll()` with a lambda expression

---

## 🧠 Concepts Practised

- `List<T>` operations (`Add`, `Remove`, `Sort`, `FindAll`)
- Foreach loops and lambda expressions
- Filtering data using predicates
- Safe deletion from lists with conditions
- Basic use of multiple `List<T>` objects

---

## 🧪 Sample Output

```
Current colours in the list:
red
green
blue
red

Current colours in the list:
green
blue

Current colours in the list:
red
blue
green
red

Unsorted List:
10
5
15
3
9

Sorted List:
3
5
9
10
15

All numbers 10 and above:
10
15
```

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or **VS Code**
2. Ensure you have the **.NET SDK** installed
3. In the terminal, run:

```bash
dotnet run
```