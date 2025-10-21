```markdown
# 🧩 Generics in C#

This project introduces **Generics** in C#, showing how they allow developers to write **reusable and type-safe code** without duplicating logic for multiple data types.  

It compares **non-generic methods** (separate methods for `int[]` and `string[]`) to a **single generic method** that can handle any array type using **type parameters**.

---

## 📘 Key Concepts

- **Generic Methods (`<T>`)** – enable code reuse with different data types.  
- **Type Safety** – ensures only valid types are used, avoiding runtime casting errors.  
- **Eliminates Redundancy** – replaces multiple similar methods with one flexible implementation.  
- **Performance** – avoids boxing/unboxing that occurs with `object` types.  

---

## 🧠 How It Works

| Step | Description | Example |
|------|--------------|----------|
| **1. Traditional Methods** | Create a separate method for each data type. | `PrintIntArray(int[] array)` and `PrintStringArray(string[] array)` |
| **2. Define a Generic Method** | Use a type parameter `<T>` that acts as a placeholder for any data type. | `public static void PrintArray<T>(T[] array)` |
| **3. Iterate Through Array** | Use `foreach` to print each element of the generic array. | `foreach (T t in array)` |
| **4. Call the Generic Method** | The compiler infers the type automatically. | `PrintArray(intArray);` and `PrintArray(stringArray);` |

---

## 💡 Example Output

```

1
2
3
4
One
Two
Three
Four

````

---

## 🧩 Explanation

| Concept | Description |
|----------|--------------|
| **Type Parameter (`<T>`)** | Represents a placeholder for the data type that will be provided at runtime. |
| **Type Inference** | C# automatically determines the type used for `<T>` when the method is called. |
| **Code Reusability** | One method can handle arrays of any data type — integers, strings, doubles, etc. |
| **Compile-Time Safety** | Prevents accidental type mismatches or runtime casting errors. |

---

## 🧱 Summary

This project demonstrates how **Generics** make your code:
- **More reusable** (one method for all types)  
- **Type-safe** (no invalid casts)  
- **Cleaner and more maintainable**

Generics are widely used in:
- `List<T>` and `Dictionary<TKey, TValue>`  
- Custom reusable libraries  
- Strongly-typed data structures  

---

## ▶️ Run the Program

```bash
cd Generics
dotnet run
````