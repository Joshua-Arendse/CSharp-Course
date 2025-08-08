# 🔐 AccessModifiers – Exploring Access Control in C#

This console application demonstrates how **access modifiers** work in C#. It showcases the behaviour of `public`, `protected`, and `private` fields within a class hierarchy, helping you understand the boundaries of accessibility in object-oriented programming.

---

## 🎯 Objective

To practise and visualise how different access modifiers affect field visibility between a base class and its derived class.

---

## 📌 Features

| Modifier     | Description                                                                 |
|--------------|-----------------------------------------------------------------------------|
| `public`     | Accessible from anywhere in the program                                     |
| `protected`  | Accessible only within the class itself and any derived classes             |
| `private`    | Accessible only within the class where it is defined                        |

---

## 🧱 Class Structure

```csharp
class BaseClass
{
    public int publicField;
    protected int protectedField;
    private int privateField;

    public void ShowFields()
    {
        Console.WriteLine($"Public: {publicField}, Protected: {protectedField}, Private: {privateField}");
    }
}

class DerivedClass : BaseClass
{
    public void AccessFields()
    {
        publicField = 1;
        protectedField = 2;
        // privateField = 3; ❌ Not accessible here
    }
}
```

---

## 💡 Key Concepts

| Concept             | Applied In Code                     |
|---------------------|--------------------------------------|
| Public Field        | Modified and displayed freely        |
| Protected Field     | Modified within subclass             |
| Private Field       | Only accessible inside `BaseClass`   |
| Inheritance         | `DerivedClass` inherits `BaseClass`  |

---

## 💬 Output Example

```txt
Public: 1, Protected: 2, Private: 0
Public: 1, Protected: 2, Private: 0
```

Note: `privateField` is not set in the derived class, hence it remains `0`.

---

## ▶️ How to Run

Make sure you have .NET installed, then in terminal:

```bash
cd AccessModifiers
dotnet run
```
