# 📚 Dictionary in C# – Employee Directory

This C# console application demonstrates how to use **Dictionaries** with key-value pairs to manage a simple employee directory. Each employee is stored using a unique `int` key (ID) and a `string` value (name).

---

## 🚀 Features

- Initialises a `Dictionary<int, string>` to store employee IDs and names
- Adds entries manually using `.Add()`
- Accesses and updates values by key
- Removes entries using `.Remove()`
- Uses `.ContainsKey()` to check before inserting duplicates
- Uses `.TryAdd()` for safe conditional insertion
- Iterates through all key-value pairs using `foreach`

---

## 🧠 Concepts Practised

- ✅ Dictionaries in C#
- ✅ Key-value pair data structure
- ✅ Lookup, update, and deletion of items by key
- ✅ Dictionary iteration with `KeyValuePair<>`
- ✅ Safe insertion using `.ContainsKey()` and `.TryAdd()`
- ✅ Realistic use-case for ID-to-name mapping

---

## 🔤 Sample Output

```
Employee with id 102 already exist
ID: 103, Name: Rob Smith
ID: 104, Name: Flob Smith
ID: 105, Name: Dob Smith
ID: 102, Name: Jane Smith
```

---

## ▶️ How to Run

1. Ensure you have .NET SDK installed.
2. Open terminal in the project directory and run:

```bash
dotnet run