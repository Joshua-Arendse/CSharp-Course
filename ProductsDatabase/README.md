# 🛒 Products Database – LINQ & List Filtering in C#

This project demonstrates how to build a simple in-memory product database using a `List<Product>` and LINQ queries. It’s a great hands-on way to practise working with **collections**, **object properties**, and **functional programming** in C#.

---

## 💡 Project Overview

You’ll create a product list for a fictional shop, each with:

- **Name**
- **Price**
- **Stock**

Then you'll use **LINQ** to:

✅ Filter all products with stock greater than 10  
✅ Identify the **most expensive** product

---

## 🧾 Sample Product List

```csharp
List<Product> shop = new List<Product>
{
    new Product{Name="Fish",Price=50.0,Stock=8},
    new Product{Name="Chicken",Price=100.0,Stock=10},
    new Product{Name="Beef",Price=200.0,Stock=5},
    new Product{Name="Halls",Price=0.50,Stock=50},
    new Product{Name="Chips",Price=5.0,Stock=12}
};
```

---

## 🔍 LINQ Queries Used

```csharp
// Get all products with stock greater than 10
var popularProducts = shop.Where(x => x.Stock > 10).ToList();

// Get the most expensive product
var mostExpensive = shop.OrderByDescending(x => x.Price).First();
```

---

## 📦 Output Example

```
Halls
Chips
Beef, R200
```

---

## 🧠 Concepts Practised

| Concept           | Description |
|-------------------|-------------|
| Object Creation   | Defining and populating a `Product` class |
| Lists             | `List<Product>` to store and access data |
| LINQ              | `.Where()`, `.OrderByDescending()`, `.First()` |
| Filtering Data    | Products with stock > 10 |
| Sorting Data      | Finding the max price |
| Basic Console Output | Using `foreach` and `Console.WriteLine()` |

---

## ▶️ How to Run

Make sure you have the .NET SDK installed. Then run the project:

```bash
dotnet run
```