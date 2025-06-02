# 🚗 Properties – Encapsulation in C#

This project introduces the concept of **properties** in C#. Properties provide controlled access to class fields and are a core feature of object-oriented programming and encapsulation.

---

## 📚 Concepts Practised

- ✅ Private fields
- ✅ Public properties (`get` / `set`)
- ✅ Encapsulation
- ✅ Access modifiers (`private`, `public`)
- ✅ Object instantiation

---

## 🔍 Project Summary

The program defines a `Car` class with a private field `_name` and a public property `Name`. This allows reading and modifying the `_name` field in a safe, controlled way via `get` and `set`.

### Class: `Car`

```csharp
private string _name;

public string Name
{
    get { return _name; }
    set { _name = value; }
}
