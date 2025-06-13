# 🧾 MethodBasics – C# Methods, Parameters, and Return Types

This project explores how to define and use methods in C#. It demonstrates the difference between `void` and `return` methods, how to pass parameters, and how to capture and reuse return values. Ideal for beginners learning about method structure and logic reuse.

---

## 📚 Concepts Practised

- ✅ `void` methods (no return value)
- ✅ Methods with parameters
- ✅ Methods with return values
- ✅ Calling methods multiple times
- ✅ Passing variables as arguments
- ✅ Capturing return values from methods

---

## 🧾 Method Types Explained

### 🔹 Void Method (no parameters)
```csharp
void MyFirstMethod()
{
    Console.WriteLine("The Method was called");
}
```
Called like this:
```csharp
MyFirstMethod();
```

### 🔹 Void Method (with parameter)
```csharp
void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("You passed this argument " + myString);
}
```
Example usage:
```csharp
WriteSomethingSpecific("Josh");
```

### 🔹 Method with Return Type and Parameters
```csharp
int AddTwoValues(int value1, int value2)
{
    return value1 + value2;
}
```
Example usage:
```csharp
int result = AddTwoValues(10, 20);
Console.WriteLine("The result is " + result);
```

---

## 🧪 Example Output

```
The Method was called
The Method was called
The Method was called
The Method was called
This is outside the method
I'm writng something!
You passed this argument Josh
The result is 42
Enter a number, I will add 10 to it!
25
The result is 35
```

---

## ▶️ How to Run

```bash
dotnet run
```

---

## 💡 Tips

- Method names should start with a capital letter by convention in C#.
- `void` means the method does not return any data.
- Return values can be stored in variables or used inline.
- Parameters allow you to reuse logic with different input values.

---

This project is foundational for mastering **code reuse, logic structuring, and functional design** in C#. 🔁
