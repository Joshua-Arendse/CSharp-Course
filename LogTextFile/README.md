# 📝 LogTextFile – Writing to a Text File in C#

This project demonstrates how to **log messages into a text file** in C# using the `System.IO` namespace.  
It covers working with **directories**, **files**, and the `File.AppendAllText` method.

---

## 📖 Concepts Covered
- **Verbatim string literals (`@`)**
  - Allows paths to be written without escaping backslashes (`@"C:\Logs"` instead of `"C:\\Logs"`).

- **Directory Handling**
  - `Directory.Exists(path)` checks if a directory exists.
  - `Directory.CreateDirectory(path)` creates it if not.

- **File Handling**
  - `Path.Combine(dir, file)` creates a valid file path.
  - `File.AppendAllText(path, text)` writes text to a file (creates it if it does not exist).

---

## 🖥️ Example Code

```csharp
string directoryPath = @"C:\Logs";
string filePath = Path.Combine(directoryPath, "log.txt");
string message = "This is a log entry";

// Create directory if it doesn't exist
if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

// Append message to file
File.AppendAllText(filePath, message + "\n");
```

---

## ▶️ Usage Example

1. Run the program.
2. A folder **C:\Logs** will be created (if it doesn’t already exist).
3. A file named **log.txt** will be created/updated with the log entry.

**Example `log.txt`:**
```
This is a log entry
```

Every run appends a new entry.

---

## 🧠 What You Learn
- How to work with file paths in C#.
- Creating directories programmatically.
- Writing and appending text to files.
- Why `@` is useful in file paths.

---

## ▶️ Run the Program
```bash
cd LogTextFile
dotnet run
```