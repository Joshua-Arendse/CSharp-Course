````markdown
# 🧵 Multicast Delegates in C#

This project demonstrates how **multicast delegates** work in C#, allowing a single delegate instance to invoke **multiple methods** in sequence. It also shows how to safely invoke delegates, inspect their invocation lists, and remove methods dynamically.

---

## 📘 Key Concepts

### 🔹 Multicast Delegates  
A delegate that references **more than one method**. When invoked, it executes all attached methods in order.

### 🔹 Adding & Removing Methods  
Use `+=` to attach another method and `-=` to detach one from the invocation list.

### 🔹 Invocation Lists  
`GetInvocationList()` lets you inspect each method attached to the delegate and optionally run them one by one with error handling.

### 🔹 Safe Invocation  
Demonstrated with a helper method that checks null references before invoking.

---

## 🧠 How It Works

### ✔️ 1. Define the Delegate  
```csharp
public delegate void LogHandler(string message);
````

### ✔️ 2. Logger Class Has Multiple Methods

* `LogToConsole()`
* `LogToFile()`

Both match the delegate signature, making them attachable.

### ✔️ 3. Create a Multicast Delegate

```csharp
LogHandler logHandler = logger.LogToConsole;
logHandler += logger.LogToFile;
```

### ✔️ 4. Invoke the Multicast Delegate

Runs both logging methods in order.

### ✔️ 5. Iterate Through Invocation List

The code loops through:

```csharp
logHandler.GetInvocationList()
```

allowing individual execution with try/catch.

### ✔️ 6. Remove a Method

Before detaching:

```csharp
IsMethodInDelegate(logHandler, logger.LogToFile)
```

checks if the method exists in the delegate's list.

### ✔️ 7. Safe Invocation Method

`InvokeSafely()` ensures the delegate is not null before calling it.

---

## 🧾 Example Output

```
Console Log: Log this info!
File Log: Log this info!
Console Log: Event occured with error handling
File Log: Event occured with error handling
LogToFile method removed
Console Log: After removing the LofToFile
```

---

## 💡 What You Learn

| Concept                            | Description                                           |
| ---------------------------------- | ----------------------------------------------------- |
| **Multicast Delegates**            | A single delegate referencing multiple methods        |
| **Invocation Lists**               | Inspect and execute each method separately            |
| **Method Removal**                 | Dynamically detach specific methods from the delegate |
| **Safe Delegate Invocation**       | Prevent runtime errors from null delegates            |
| **Organised Event-Style Handling** | Foundation for event systems in C#                    |

---

## 🧱 Summary

This project teaches how to:

* Combine multiple methods into one callable delegate
* Loop through method entries in the invocation list
* Safely invoke delegates
* Dynamically detect and remove a specific method

Multicast delegates are essential when building **event-driven systems**, **logging frameworks**, and **notification pipelines** where multiple actions must happen from a single trigger.

---

## ▶️ Run the Program

```bash
cd MulticastDelegates
dotnet run
