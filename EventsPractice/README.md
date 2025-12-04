```markdown
# 🏠 Smart Home Event System – Events & EventArgs Practice in C#

This project simulates a **Smart Home system** using C# events, custom `EventArgs`, and the publisher–subscriber pattern.  
It demonstrates how multiple sensors can trigger alerts that are handled by a central hub.

---

## 📘 Key Concepts

### 🔹 Multiple Custom EventArgs Types  
The project uses two event data classes:

- **TemperatureEventArgs** – carries the new temperature value  
- **DoorEventArgs** – indicates whether the door is open  

This allows each event to pass meaningful, strongly typed information.

---

### 🔹 Publishers (Sensors)

There are two sensors that **raise events** when something important happens:

#### ✅ `TemperatureSensor`
- Has a `Temperature` property  
- Raises an event when temperature exceeds **30°C**  
- Uses `EventHandler<TemperatureEventArgs>`

#### ✅ `DoorSensor`
- Has an `IsOpen` property  
- Raises an event when the door becomes open  
- Uses `EventHandler<DoorEventArgs>`

Each sensor wraps event invocation inside a protected method (`OnTemperatureChanged`, `OnDoorChanged`), following C# best practices.

---

### 🔹 Subscriber (SmartHomeHub)

The hub receives and reacts to events:

- Handles temperature alerts  
- Handles door opening alerts  
- Prints useful information, including the **sender** device  

This class demonstrates how a single subscriber can listen to different event types.

---

## 🔧 How It Works (Flow)

1. Sensor property changes  
2. Condition is checked (temperature > 30, door == open)  
3. Sensor raises an event  
4. SmartHomeHub receives the event  
5. Hub prints an alert with the event data  

---

## 🧾 Example Output

```

Alert: temperature is too high! It is 35 Degrees. Sender is: EventsPractice.TemperatureSensor
Alert the Door is open!

````

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **EventHandler<T>** | Strongly typed event pattern |
| **Custom EventArgs** | Pass structured data with events |
| **Multiple Publishers** | Handling events from different sources |
| **Smart Subscriber Design** | One class reacting to different events |
| **Encapsulation of Event Raising** | Using protected virtual methods |
| **Real-world Simulation** | Mimics a smart home event system |

---

## 🧱 Summary

This project gives you hands-on experience with:

- Custom event data  
- Multiple event sources  
- Encapsulated event raising  
- A central hub that reacts to system events  
- Event-driven design used in real IoT systems, UI frameworks, and service architecture  

It's an excellent step toward mastering **events, EventArgs patterns, and decoupled architecture** in C#.