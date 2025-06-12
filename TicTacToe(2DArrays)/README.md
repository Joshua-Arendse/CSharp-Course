# 🧮 MultiDimensionalArrays – 2D Arrays in C#

This project demonstrates how to declare, initialise, update, and access **2D (two-dimensional) arrays** in C#. It includes practical examples like coordinate grids and a simple Tic Tac Toe board.

---

## 📚 Concepts Practised

- ✅ Declaring and initialising 2D arrays
- ✅ Accessing elements with `[row, column]` indices
- ✅ Updating array elements
- ✅ Representing data in a grid format

---

## 🧾 Summary

The program explores:

1. **Declaring a 3×3 integer array**:
   ```csharp
   int[,] array2DDeclare = new int[3, 3];

2. **Initialising a 2D array with values**:
   ```csharp
   int[,] array2DInitialize = { { 1, 2 }, { 3, 4 } };

3. **Modifying array values**:
   ```csharp
   array2DInitialize[0, 0] = 5;

4. **Creating a visual index map using a string[,]**:
   ```csharp
   string[,] understandingIndexes = {
    {"0,0","0,1","0,2"},
    {"1,0","1,1","2,2"},
    {"2,0","1,1","2,2"}
    };

4. **Tic Tac Toe field representation**:
   ```csharp
   string[,] ticTactoeField = {
    {"O","X","X"},
    {"O","O","X"},
    {"X","X","O"}
    };

## 🧪 Example Output

1
5
X

The first output is the original value of [0, 0], then it's updated to 5, followed by the value at [1, 2] in the Tic Tac Toe grid.