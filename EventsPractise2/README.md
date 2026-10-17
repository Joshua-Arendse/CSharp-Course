# 📈 EventsPractise2 – Events with EventArgs in C#

This project builds on basic events by using the standard .NET event pattern: `EventHandler<TEventArgs>`, a custom `EventArgs` class, and the `sender` parameter. A `Stock` publishes a `PriceChanged` event whenever its price changes, and two subscribers react to it: a `DashBoard` that displays every update and a `PriceAlert` that warns once and then unsubscribes itself.

---

## 📘 Key Concepts

### 🔹 Custom EventArgs
`StockPriceChangedEventArgs` inherits from `EventArgs` and carries the event data (`StockName` and `NewPrice`) to subscribers.

### 🔹 EventHandler&lt;T&gt;
Instead of declaring a custom delegate, the built-in generic delegate is used:
```csharp
public event EventHandler<StockPriceChangedEventArgs> PriceChanged;
```

### 🔹 The `On...` Raise Method
`OnPriceChanged` is a `protected virtual` method that raises the event, so derived classes can override how it fires:
```csharp
PriceChanged?.Invoke(this, e);
```

### 🔹 Raising Events from a Property
The `Price` setter only raises the event when the value actually changes (`value != _Price`).

### 🔹 Unsubscribing
`PriceAlert` uses `-=` to remove its own handler after the threshold is crossed, so it only warns once.

---

## 🧠 How It Works

### ✔️ 1. Define the Event Data
```csharp
public class StockPriceChangedEventArgs : EventArgs
```
Holds the stock name and the new price.

### ✔️ 2. Create the Publisher
`Stock` exposes the `PriceChanged` event and raises it from the `Price` setter when the price changes.

### ✔️ 3. Create the Subscribers
- `PriceAlert(threshold)` warns when `NewPrice > Threshold`, then unsubscribes.
- `DashBoard` prints every price update.

Both handlers match the `(object sender, StockPriceChangedEventArgs e)` signature.

### ✔️ 4. Subscribe to the Event
```csharp
stock.PriceChanged += priceAlert.OnPriceChanged;
stock.PriceChanged += dashBoard.OnPriceChanged;
```

### ✔️ 5. Change the Price
```csharp
stock.Price = 88;
stock.Price = 90;
stock.Price = 99;
stock.Price = 120;
```
Each change triggers the event and runs the subscribed handlers in order.

### ✔️ 6. Unsubscribe Safely
When the price hits 120, `PriceAlert` casts `sender` back to `Stock` and removes itself:
```csharp
var stock = (Stock)sender;
stock.PriceChanged -= this.OnPriceChanged;
```
The `DashBoard` handler still runs for that same event.

---

## 🧾 Example Output

```
Gold updated: new price = 88
Gold updated: new price = 90
Gold updated: new price = 99
Warning: The price of Gold is too high at 120
Gold updated: new price = 120
```

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **EventHandler&lt;T&gt;** | The standard built-in delegate for events that carry data |
| **Custom EventArgs** | Pass event data to subscribers in a clean, typed way |
| **Sender Parameter** | Lets a handler know which object raised the event |
| **Protected Virtual On-Methods** | The convention for raising events and allowing overrides |
| **Unsubscribing with -=** | A handler can remove itself once its job is done |
| **Property-Triggered Events** | Raise events only when a value actually changes |

---

## 🧱 Summary

This project demonstrates how to:

- Create a custom `EventArgs` class to carry event data
- Use `EventHandler<T>` instead of writing your own delegate
- Raise an event from a property setter
- Have multiple subscribers react independently to the same event
- Unsubscribe a handler at runtime

This is the same pattern used throughout the .NET framework and in UI, messaging, and monitoring code.

---

## ▶️ Run the Program

```bash
cd EventsPractise2
dotnet run
```

---

## ⏭️ Next Step

Try adding a second `PriceAlert` with a lower threshold, a "price dropped" alert, or a `Stock` subclass that overrides `OnPriceChanged`. You could also initialise `PriceChanged` as nullable (`EventHandler<StockPriceChangedEventArgs>?`) to clear the nullable warning, since the project has nullable reference types enabled.
