```markdown
# 📉 EventsChallenge – Stock Price Alert System in C#

This project demonstrates how to build a **simple stock monitoring system** using **events**, **delegates**, and **encapsulation**. When the stock price drops below a user-defined threshold, the system automatically triggers an alert.

---

## 📘 Key Concepts

### 🔹 Custom Delegate  
The project uses a delegate to define the signature of methods that handle stock alerts:

```

public delegate void StockPriceChangedHandler(string message);

```

Any method matching this signature can subscribe to stock alerts.

---

### 🔹 Event-Driven Stock Monitoring  
The `Stock` class exposes:

- A `Price` property  
- A `Threshold` property  
- An event:  
  `public event StockPriceChangedHandler OnStockPriceChanged;`

Whenever `Price` is updated, the setter checks whether the price falls below the threshold:

- If **yes** → event is raised  
- If **no** → program continues without notification  

---

### 🔹 Safe Event Invocation  

```

OnStockPriceChanged?.Invoke(message);

```

This ensures the event is only triggered if at least one subscriber is listening.

---

### 🔹 Subscriber Class  
`StockAlert` contains the event handler:

```

public void OnStockPriceChanged(string message)
{
Console.WriteLine("Stock Alert: " + message);
}

```

This method executes automatically whenever the event is fired.

---

### 🔹 Usage in Program  
The main program:

- Creates a `Stock` and `StockAlert` object  
- Subscribes the alert to the event  
- Sets a price threshold  
- Simulates price updates to trigger the event  

---

## 🧾 Example Output

```

Stock Alert: Stock price is below threshold!

````

This appears when the price drops under the threshold (e.g., from 130 → 110).

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **Custom Delegates** | Define message format for event notifications |
| **Events in C#** | Notify subscribers when important state changes occur |
| **Property Setters with Logic** | Trigger logic when values change |
| **Encapsulation** | Keep fields private while exposing safe public properties |
| **Publisher–Subscriber Pattern** | Stock publishes events, alert subscribes |
| **Null-Safe Event Invocation** | `?.Invoke()` prevents runtime errors |

---

## 🧱 Summary

This project helps you understand how to:

- Build scalable, event-driven systems  
- Trigger alerts based on real-time data changes  
- Use delegates and events to reduce coupling  
- Design reusable subscriber classes  
- Encapsulate logic inside property setters  
- Simulate patterns used in finance, monitoring systems, and UI frameworks  

---

## ▶️ Run the Program

```bash
cd EventsChallenge
dotnet run
````