# 🛒 List of Objects in C# – Product Catalogue

This console application demonstrates how to manage a list of **objects** using C#’s `List<T>` with custom class types. The app creates a simple product catalogue, adds new items, and filters products using LINQ based on price.

---

## 🚀 Features

- Declares and initialises a list of `Product` objects
- Adds new items dynamically
- Uses `foreach` to display object data
- Filters the list with LINQ (`.Where(...)`)
- Displays only products under a certain price (e.g. R1)

---

## 🧠 Concepts Practised

- ✅ Creating and using custom classes (`Product`)
- ✅ Initialising lists with object literals
- ✅ LINQ `.Where()` for filtering based on conditions
- ✅ Lambda expressions for inline condition checks
- ✅ Basic iteration and display formatting

---

## 📦 Product Class

```csharp
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}
```

---

## 🧪 Sample Output

```
Available Products: 
Product name: Apple for R0.8.
Product name: Banana for R0.3.
Product name: Cherry for R3.8.
Product name: Berry for R2.99.

Avaliable products under R1.
Product name: Apple for R0.8.
Product name: Banana for R0.3.
```

---

## ▶️ How to Run

1. Make sure you have the .NET SDK installed
2. Run the project from the terminal:

```bash
dotnet run