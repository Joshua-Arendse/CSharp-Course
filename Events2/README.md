```markdown
# 🌡️ Events2 – Temperature Monitoring with Events in C#

This project demonstrates how to use **events**, **delegates**, and **property setters** to build a simple yet powerful **temperature monitoring system**. When the temperature crosses a threshold, an automatic alert is raised.

---

## 📘 Key Concepts

### 🔹 Delegate for Event Handling  
A delegate defines the method signature for handlers that respond to the temperature change:

```

public delegate void TemperatureChangeHandler(string message);

```

Any method that matches this signature can subscribe.

### 🔹 Event-Driven Temperature Monitoring  
`TemperatureMonitor` contains:

- A private backing field `_temperature`
- A public property `Temperature`
- An event `OnTemperatureChanged` that fires when the temperature exceeds **30°C**

Whenever the property is updated, it checks:

- If the temperature > 30 → raise the event  
- Otherwise → no alert

### 🔹 Protected Virtual Event Trigger  
The event is raised through a protected method:

```

protected virtual void RaiseTemperatureChangedEvent(string message)

```

This allows **derived classes** to override or extend the event behaviour.

### 🔹 Subscriber Class  
`TemperatureAlert` listens for temperature change alerts with:

```

public void OnTemperatureChanged(string message)

```

This method is automatically executed when the event is triggered.

### 🔹 User Interaction  
The program asks the user for a temperature value, updates the monitor, and fires events if necessary.

---

## 🧾 Example Output

```

Please enter the temperature
31
Alert: Temperature is above threshold!

````

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **Custom Delegates** | Define the method signature for event handlers |
| **Events with Property Setters** | Trigger logic whenever a value is changed |
| **Encapsulation** | Using private fields with public properties |
| **Event Safety** | Using `?.Invoke()` prevents null reference exceptions |
| **Inheritance-Friendly Events** | `protected virtual` allows method overriding |
| **Publisher–Subscriber Pattern** | Monitor raises an event, alert class responds |

---

## 🧱 Summary

This project teaches you how to:

- Detect changes inside property setters  
- Raise events when conditions are met  
- Create subscriber classes to react to notifications  
- Build loosely coupled, event-driven systems  
- Handle real-time monitoring patterns (temperature, sensors, stock updates, etc.)

This structure is similar to how **IoT sensors**, **game systems**, and **UI event handlers** work behind the scenes.

---

## ▶️ Run the Program

```bash
cd Events2
dotnet run
````