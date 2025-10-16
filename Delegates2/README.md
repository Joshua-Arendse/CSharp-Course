```markdown
# 🧾 Delegates2 – Multi-Method Delegates in C#

This project expands on the **delegate** concept by demonstrating how delegates can **reference multiple methods** and be **switched dynamically** at runtime. It introduces the **LogHandler delegate** pattern for flexible logging — allowing logs to be directed to different targets (e.g., console, file, database).

---

## 📘 Key Concepts

- **Delegate Declaration** – defines a method signature (`LogHandler`) that all assigned methods must match.  
- **Dynamic Method Binding** – delegates can be reassigned to different methods at runtime.  
- **Loose Coupling** – allows switching between implementations (e.g. console or file logging) without changing program logic.  
- **Encapsulation of Behaviour** – the method logic is hidden; only the delegate’s signature matters.  

---

## 🧠 How It Works

| Step | Description | Example |
|------|--------------|----------|
| **1. Declare a Delegate** | Defines a method signature that the delegate will follow. | `public delegate void LogHandler(string message);` |
| **2. Assign Method to Delegate** | Attach a compatible method. | `logHandler = logger.LogToConsole;` |
| **3. Invoke Delegate** | Call the method via the delegate. | `logHandler("Logging to Console");` |
| **4. Switch Target** | Reassign the delegate to a new method dynamically. | `logHandler = logger.LogToFile;` |

---

## 💡 Example Output

```

Console Log: Logging to Console
File Log: Log some stuff

````

---

## 🧩 Explanation

| Concept | Description |
|----------|--------------|
| **Delegate Type Safety** | The methods assigned must match the delegate’s parameter and return types exactly. |
| **Dynamic Assignment** | You can easily switch or combine methods using `+=` or `-=`. |
| **Encapsulation** | The delegate doesn’t care *how* the method logs, only that it takes a `string` argument. |
| **Extensibility** | New log destinations (like database or cloud) can be added with minimal code changes. |

---

## 🧱 Summary

This example highlights the power of **delegates for flexible and maintainable code**, especially when used to abstract actions like logging.  
They enable:
- Swapping logic without touching existing code.  
- Passing behaviour as parameters.  
- Building **plug-and-play** architectures.

---

## ▶️ Run the Program

```bash
cd Delegates2
dotnet run
```