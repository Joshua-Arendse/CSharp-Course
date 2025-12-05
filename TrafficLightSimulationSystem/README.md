```markdown
# 🚦 Traffic Light Simulation System – Events, Timers & State Cycling in C#

This project simulates a **real traffic light system** using:

- **Events** (`EventHandler<T>`)
- **Timers** (`System.Timers.Timer`)
- **Custom EventArgs**
- **Automatic state cycling** (Green → Orange → Red)

It demonstrates how time-based events trigger updates that subscribers can react to — similar to real-world IoT or embedded traffic systems.

---

## 📘 Key Concepts

### 🔹 Custom EventArgs  
`TrafficLightEventArgs` carries the **current colour** of the traffic light.

### 🔹 Publisher — `TrafficLight`  
This class:

- Stores a list of colours: Green → Orange → Red  
- Uses a **timer** to switch between them  
- Raises the `LightChanged` event every time the colour updates  
- Adjusts the timer duration based on the current colour  
  - Green → 5 seconds  
  - Orange → 3 seconds  
  - Red → 4 seconds  

The traffic light cycles continuously using modular arithmetic:

```

currentIndex = (currentIndex + 1) % colors.Count;

```

This makes the light "wrap around" automatically.

### 🔹 Subscriber — `TrafficController`  
This class listens to the traffic light’s event and:

- Prints the colour change notification  
- Reacts immediately when the event fires  

---

## 🧾 Example Output

```

Light is Green
Light changed to Green
Light changed to Orange
Light changed to Red
Light changed to Green
...

````

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **System.Timers.Timer** | Trigger actions automatically after intervals |
| **EventHandler<T>** | Strongly typed events with custom data |
| **State Machine Basics** | Cycling through repeating states |
| **Dynamic Timer Intervals** | Adjusting timer behaviour at runtime |
| **Publisher/Subscriber Pattern** | Decoupling light logic from the controller |
| **Encapsulated Event Raising** | Using protected virtual methods |

---

## 🧱 Summary

This project gives you hands-on experience with:

- Timers that simulate real-time behaviour  
- Custom event data and notifications  
- Dynamic state cycling  
- A clean separation between "device" (traffic light) and "system logic" (controller)  
- Real-world style timing logic used in embedded systems, signalling systems, and automation  

---