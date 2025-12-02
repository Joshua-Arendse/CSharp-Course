```markdown
# 🌡️ EventArgs & EventHandler – Strongly Typed Event System in C#

This project demonstrates how to use **EventArgs**, **EventHandler**, and **EventHandler<TEventArgs>** to build a clean, strongly-typed event system. It shows how to raise events with additional data and how subscribers can receive both the **sender** and **event arguments**.

---

## 📘 Key Concepts

### 🔹 EventArgs Class (Custom Data for Events)
The project includes a custom class:

```

public class TemperatureChangedEventArgs : EventArgs
{
public int Temperature { get; }
public TemperatureChangedEventArgs(int temperature) { Temperature = temperature; }
}

```

This allows the event to pass strong, typed information instead of relying on strings.

---

### 🔹 EventHandler<T> Delegate
`EventHandler<TemperatureChangedEventArgs>` automatically enforces the correct method signature:

```

(object sender, TemperatureChangedEventArgs e)

```

So all event handlers receive:

- The **sender** object that raised the event  
- Event data containing the new **temperature**  

---

### 🔹 Temperature Monitor (Publisher)

The `TemperatureMonitor` class exposes:

- A `TemperatureChanged` **event**  
- A `Temperature` property containing logic  
- A protected method to safely raise the event  

Each time the temperature value changes, the event is raised:

```

TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(temp));

```

---

### 🔹 Temperature Alert (Subscriber)

The subscriber listens for the event and responds:

```

public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
{
Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender}");
}

```

This gives you both context (**sender**) and data (**Temperature**).

---

### 🧾 Example Output

```

Please enter the temperature
38
Alert: temperature is 38 sender is: EventArgsAndEventHandler.TemperatureMonitor

````

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **EventArgs Pattern** | Best practice for passing data via events |
| **EventHandler<T>** | Strongly typed events with automatic signature enforcement |
| **Publisher–Subscriber Pattern** | Clean decoupling between event source and listeners |
| **Encapsulated Event Raising** | Use of protected `OnTemperatureChangedEvent()` |
| **Sender Context** | See which object raised the event |
| **Avoiding Custom Delegates** | Modern C# prefers `EventHandler<TEventArgs>` |

---

## 🧱 Summary

This project shows how to build a professional-level C# event system using:

- Custom `EventArgs` for structured event data  
- `EventHandler<T>` for strong typing  
- Encapsulated raising methods  
- A clean publisher–subscriber model  

These patterns are used everywhere in .NET—UI events, file watchers, networking, real-time monitoring, and more.

---

## ▶️ Run the Program

```bash
cd EventArgsAndEventHandler
dotnet run
````