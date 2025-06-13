# 🧠 ProgrammingChallenges – C# Beginner Exercises Collection

This project contains 9 mini-programs bundled into one file. Each exercise demonstrates a key programming concept such as loops, arrays, conditionals, string processing, and number theory.

---

## 📚 Concepts Practised

- ✅ 2D and 1D Arrays
- ✅ Nested `for` loops
- ✅ `foreach` loops
- ✅ String and character processing
- ✅ Number properties and logic (sum of digits, primes, Fibonacci)
- ✅ Pattern printing
- ✅ Input/output handling

---

## 🧾 Exercises Included

### 1. **Sum of the Rows in a 2D Array**
Loops through each row of a 3x3 integer array and prints the sum per row.
```csharp
int[,] array = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
```

### 2. **Multiplication Table (1–10)**
Prints a formatted multiplication table using `\t` and nested loops.

### 3. **Find Largest Number in Array**
Uses a `foreach` loop to find the maximum value in an integer array.

### 4. **Reverse an Array**
Loops from end to start of an array and prints each element.

### 5. **Count Vowels in a String**
Takes input from the user and counts the vowels (`a`, `e`, `i`, `o`, `u`) using a `switch` statement.

### 6. **Sum of Digits**
Prompts the user for a number (as a string) and calculates the sum of its digits by converting characters to integers.

### 7. **Fibonacci Sequence**
Generates and prints the first N terms in the Fibonacci sequence based on user input.

### 8. **Prime Numbers (1 to 100)**
Prints all prime numbers from 1 to 100 using modular arithmetic. Approximates prime checking (does not strictly check for primality).

### 9. **Pyramid Pattern Printing**
Takes the number of rows and prints a centred pyramid of `*` characters using nested loops.

---

## ▶️ How to Run

```bash
dotnet run
```

> ⚠️ Input prompts are built-in for some exercises, so be ready to type when prompted.

---

## 🧪 Sample Outputs

- **Vowel Count Input:**  
  `Type something and I will tell you how many vowels are inside of it:`  
  `→ Hello World!`  
  `→ You have 3 Vowels.`

- **Sum of Digits:**  
  `Type a random number:`  
  `→ 12345`  
  `→ 15`

- **Fibonacci:**  
  `Enter the number of terms in the Fibonacci sequence:`  
  `→ 7`  
  `→ 0 1 1 2 3 5 8`

- **Pyramid Pattern (input: 4):**
```
   *
  ***
 *****
*******
```

---

## 💡 Ideas for Extension

- Turn each exercise into a method for modular reuse.
- Add input validation (`TryParse`) for safer execution.
- Refactor into a menu-driven program to select challenges.

---

This is a powerful practice set for strengthening your problem-solving skills in C#. Great for interviews, challenges, or revising the fundamentals. 💪
