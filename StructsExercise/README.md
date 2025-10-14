```markdown
# 📅 StructsExercise – Working with `struct`, DateTime, and Event Overlaps

This project demonstrates how to **create and use a C# `struct`** to represent calendar events, calculate their duration, and determine whether two events overlap in time. It reinforces **struct usage, constructor validation, `DateTime` arithmetic, and simple scheduling logic**.

---

## 📘 Key Concepts

- Declaring and using **C# structs** (`struct`)  
- Implementing a **custom constructor** with validation (throws on invalid ranges)  
- Calculating **duration** between two dates using `TimeSpan` (`TotalDays`)  
- Checking **date overlaps** between two events using range comparison  
- Using exceptions to enforce logical rules (start date must be before end date)

---

## 🧠 Behaviour & Methods

**`Event` struct (summary)**  
- Fields: `DateTime StartDate`, `DateTime EndDate`  
- Constructor: validates `StartDate < EndDate`, throws `ArgumentException` otherwise  
- `GetDuration()` → returns event length in days (`(EndDate - StartDate).TotalDays`)  
- `IsOverlapping(Event other)` → returns `true` when ranges intersect:
  - overlap condition: `StartDate < other.EndDate && EndDate > other.StartDate`

---

## 🧾 Example Output

```

Event 1 Duration: 9 days
Event 2 Duration: 10 days
Events Overlap: True

````

---

## 💡 What You Learn

| Concept | Description |
|---------|-------------|
| **Struct Creation** | Lightweight value-type useful for small, related data (events). |
| **Constructor Validation** | Prevents creating logically invalid events (start ≥ end). |
| **DateTime Arithmetic** | `EndDate - StartDate` returns a `TimeSpan`; use `TotalDays`. |
| **Overlap Logic** | Two events overlap if one starts before the other ends AND ends after the other starts. |
| **Exception Handling** | Use exceptions to fail fast on invalid input and keep data consistent. |

---

## ▶️ Run the Program

```bash
cd StructsExercise
dotnet run
````

---

## 🧱 Summary

This exercise strengthens your ability to:

* Model small domain concepts using `struct`
* Work with `DateTime` and `TimeSpan` for scheduling calculations
* Implement robust validation in constructors
* Apply simple interval-overlap logic useful in calendars, bookings or resource scheduling
