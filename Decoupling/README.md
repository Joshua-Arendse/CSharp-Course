# 🔗 Decoupling – Using Interfaces for Flexible Logging

This project demonstrates **decoupling** in C# by using **interfaces** to separate the application logic from the logging mechanism.  
Instead of the `Application` class being tied to a specific logging system (e.g., file or database), it depends only on an **interface (`ILogger`)**, making the code flexible and easy to extend.

---

## 📖 Concepts Covered
- **Interfaces (`ILogger`)**
  - Defines a contract with a `Log(string message)` method.
- **Decoupling**
  - The `Application` class does not depend on specific logging classes (`FileLogger`, `DatabaseLogger`).
  - Makes the system easier to maintain, extend, and test.
- **Dependency Injection**
  - `ILogger` is injected into the `Application` class via the constructor.

---

## 🖥️ Example Code

```csharp
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        string directoryPath = @"C:\Logs";
        string filePath = Path.Combine(directoryPath, "log.txt");

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        File.AppendAllText(filePath, message + "\n");
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to database: {message}");
    }
}

public class Application
{
    private readonly ILogger _logger;
    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.Log("Work started");
        // Do the work
        _logger.Log("Work done!");
    }
}
```

---

## ▶️ Usage Example

```csharp
ILogger fileLogger = new FileLogger();
Application app = new Application(fileLogger);
app.DoWork();

ILogger dbLogger = new DatabaseLogger();
app = new Application(dbLogger);
app.DoWork();
```

---

## ✅ Output Example

If using `FileLogger`, the log file will contain:
```
Work started
Work done!
```

If using `DatabaseLogger`, the console will show:
```
Logging to database: Work started
Logging to database: Work done!
```

---

## 🧠 What You Learn
- How to use **interfaces** to decouple code.
- How **dependency injection** improves flexibility.
- How to implement multiple interchangeable logging systems.

---

## ▶️ Run the Program
```bash
cd Decoupling
dotnet run
```