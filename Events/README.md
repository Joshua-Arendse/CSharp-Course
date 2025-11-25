```markdown
# 🔔 Events in C#

This project demonstrates how **events** work in C#, using delegates and publisher–subscriber patterns to create clean, decoupled communication between classes.

---

## 📘 Key Concepts

### 🔹 Events  
Events allow a class to **notify** other classes when something happens — without knowing who is listening. This creates a flexible publisher–subscriber system.

### 🔹 Delegates in Events  
A delegate defines the **method signature** for event handlers.  
Here, the event uses:

```

public delegate void Notify(string message);

```

Any method that matches this signature can subscribe.

### 🔹 Publisher (Event Source)  
`EventPublisher` declares an event:

```

public event Notify OnNotify;

```

And triggers it using:

```

OnNotify?.Invoke(message);

```

The `?.` ensures the event is only invoked when subscribers exist.

### 🔹 Subscriber (Event Listener)  
`EventSubscriber` has a method matching the delegate signature:

```

public void OnEventRaised(string message)

```

It subscribes to the event using:

```

publisher.OnNotify += subscriber.OnEventRaised;

```

---

## 🧠 How It Works

### ✔️ 1. The Publisher Raises an Event  
`RaiseEvent("test")` triggers the event if someone is subscribed.

### ✔️ 2. The Subscriber Receives the Notification  
The subscriber's method runs automatically:

```

Event received: test

```

### ✔️ 3. Publisher Doesn’t Know the Subscriber  
The publisher only knows it “has an event.”  
This is **loose coupling**, essential in scalable applications.

### ✔️ 4. Supports Multiple Subscribers  
More subscribers can be added with:

```

publisher.OnNotify += anotherHandler;

```

All will run when the event is raised.

---

## 🧾 Example Output

```

Event received: test

````

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **Events** | A mechanism for broadcasting notifications |
| **Delegates** | Define the signature required for event-handler methods |
| **Publisher–Subscriber Pattern** | Decouples event creators from event listeners |
| **Safe Invocation** | Using `?.Invoke()` to avoid null errors |
| **Event Handling Best Practices** | Using `On` naming conventions (`OnNotify`) |

---

## 🧱 Summary

This project gives you a clear understanding of:

- How events are declared  
- How events are raised  
- How subscribers attach handlers  
- How delegates define event handler signatures  
- Why events create clean, scalable, decoupled code  

This pattern is foundational for **UI events**, **game engines**, **real-time systems**, and many parts of the .NET framework.

---

## ▶️ Run the Program

```bash
cd Events
dotnet run
````