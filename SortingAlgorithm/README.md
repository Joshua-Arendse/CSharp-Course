Here you go — your full **single-textbox, ready-to-paste README** in the same format you requested:

````markdown
# 🔄 Custom Sorting Algorithm Using Delegates in C#

This project demonstrates how to build a **flexible sorting system** in C# using **delegates**, allowing you to sort objects (in this case, `Person` instances) by *any* criteria — age, name, or custom logic you define.

---

## 📘 Key Concepts

- **Delegates as Comparison Functions**  
  A delegate defines a *method signature*, allowing different comparison methods to be passed into the sorter.

- **Custom Sorting Algorithm**  
  Uses a simple nested-loop (similar to bubble/selection sort) to compare and swap elements.

- **Reusable & Extensible**  
  You can sort `Person[]` by **Age**, **Name**, or any custom rule by providing a matching comparison method.

- **`CompareTo()`**  
  A built-in method returning:
  - `-1` → first value is smaller  
  - `0` → equal  
  - `1` → first value is larger  

---

## 🧠 How It Works

### ✔️ 1. Define a Comparison Delegate
```csharp
public delegate int Comparison<T>(T x, T y);
````

This allows you to pass in any method that compares two `Person` objects.

### ✔️ 2. Create a Sorter Class

The sorter loops through the array and swaps items based on the comparison.

### ✔️ 3. Create Comparison Methods

* `CompareByAge`
* `CompareByName`

Each one returns the result of `.CompareTo()`.

### ✔️ 4. Use the Sorter

Call:

* `sorter.Sort(people, CompareByAge);`
* `sorter.Sort(people, CompareByName);`

---

## 🧾 Example Output

```
Bob,25
Alice,30
Charlie,35
Denis,36

Alice,30
Bob,25
Charlie,35
Denis,36
```

---

## 💡 What You Learn

| Concept                   | Description                                               |
| ------------------------- | --------------------------------------------------------- |
| **Delegates**             | Pass behaviour (comparison logic) as a parameter.         |
| **Custom Sorting**        | Build your own sorting algorithm using delegates.         |
| **Flexible Architecture** | Sort by any criteria without rewriting the sorting logic. |
| **Use of CompareTo()**    | Standard way to compare numeric or string fields.         |

---

## 🧱 Summary

This project teaches how to create a **reusable sorting mechanism** by separating *how to sort* from *what sorting logic to use*.
By combining delegates with simple sorting loops, you gain a deeper understanding of:

* Behaviour injection
* Dynamic comparison logic
* Reusability and clean design patterns

---

## ▶️ Run the Program

```bash
cd SortingAlgorithm
dotnet run
```