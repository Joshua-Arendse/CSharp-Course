# 🧊 MultiDimensionalArraysAdvanced – 2D and 3D Arrays in C#

This project explores more advanced array concepts in C#, including how to declare and work with **3D arrays** and how to iterate over 2D arrays using nested loops. It lays the foundation for understanding structured and layered data.

---

## 📚 Concepts Practised

- ✅ Declaring and initialising 3D arrays
- ✅ Accessing elements in 3D arrays (`[x, y, z]`)
- ✅ Iterating over 2D arrays using nested `for` loops
- ✅ Using `.GetLength(dimension)` to dynamically get array size

---

## 🧾 Summary

### 1. **3D Array Declaration**:
```csharp
int[,,] Array3D = new int[3, 3, 3];
```

### 2. **3D Array Initialisation**:
```csharp
string[,,] simple3DArray =
{
    {
        { "000", "001" },
        { "010", "011" }
    },
    {
        { "100", "101" },
        { "110", "111" }
    }
};
```

### 3. **2D Array Looping**:
```csharp
int[,] arrayName = new int[3, 3];

for (int i = 0; i < arrayName.GetLength(0); i++)
{
    for (int j = 0; j < arrayName.GetLength(1); j++)
    {
        Console.Write(arrayName[i, j] + " ");
    }
    Console.WriteLine();
}
```

---

## 🧪 Example Output

```
0 0 0 
0 0 0 
0 0 0 
```

> Since the 2D array elements haven't been assigned any values, all default to `0`.

---

## ▶️ How to Run

```bash
dotnet run
```

---

## 💡 Tips

- Use `.GetLength(dimensionIndex)` for flexible array traversal.
- 3D arrays are structured like layers: `[layer, row, column]`.
- You can combine `for` loops for deeper 3D traversal if needed.

---

This project helps you visualise and manage **multi-layered data structures**, useful in games, simulations, and matrix operations. 🧠
