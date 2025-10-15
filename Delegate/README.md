```markdown
# 🔔 Delegate – Understanding Delegates in C#

This project demonstrates the concept of **delegates** in C#, which are type-safe references to methods. Delegates allow methods to be **assigned to variables**, **passed as parameters**, and **invoked dynamically**, forming the foundation for **events, callbacks, and functional programming patterns** in C#.

---

## 📘 Key Concepts

- **Delegate Declaration** – defines a method signature that compatible methods can use.  
- **Delegate Instantiation** – binds a delegate instance to a specific method.  
- **Delegate Invocation** – calls the method via the delegate.  
- **Type Safety** – the method assigned must match the delegate’s signature exactly.  
- **Reusability** – allows passing methods around like variables for flexible program design.

---

## 🧠 How It Works

| Step | Description | Example |
|------|--------------|----------|
| **1. Declaration** | Defines a delegate type that can reference methods with a specific signature. | `public delegate void Notify(string message);` |
| **2. Instantiation** | Creates a delegate instance and assigns a matching method to it. | `Notify notifyDelegate = ShowMessage;` |
| **3. Invocation** | Executes the method through the delegate. | `notifyDelegate("Hello, Delegates!");` |

---

## 💡 Example Behaviour

```

Hello, Delegates!

````

---

## 🧩 Explanation

| Concept | Description |
|----------|--------------|
| **Delegate Type** | Works like a “method pointer”, ensuring the method signature matches (same return type and parameters). |
| **Reusability** | You can change the assigned method dynamically at runtime. |
| **Loose Coupling** | Methods and classes can communicate without direct references. |
| **Foundation for Events** | Events in C# use delegates under the hood. |

---

## 🧱 Summary

This simple example introduces how **delegates decouple method calls** and form the backbone of more advanced patterns such as:
- **Events** (`event` keyword)  
- **Callbacks** (methods passed as parameters)  
- **LINQ and Lambdas** (anonymous delegate syntax)  

---

## ▶️ Run the Program

```bash
cd Delegate
dotnet run
````