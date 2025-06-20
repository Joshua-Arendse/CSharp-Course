# 🌦️ WeatherSimulator – Randomised Weather Data Generator in C#

This console application simulates weather conditions for a user-defined number of days. It randomly generates temperatures and assigns a weather condition based on logic and randomness. It then calculates useful statistics such as average temperature, min/max values, and the most common weather condition.

---

## 📚 Concepts Practised

- ✅ Random number generation
- ✅ Arrays (`int[]`, `string[]`)
- ✅ Multi-condition logic (`if-else`)
- ✅ Method creation and reuse
- ✅ Iteration (`for`, `foreach`)
- ✅ Statistical operations (average, min, max, frequency)

---

## 🧾 Program Flow

1. User inputs the number of days to simulate.
2. For each day:
   - A temperature is randomly generated between -10°C and 40°C.
   - A weather condition is assigned based on:
     - ≤ 0°C → "Snowy"
     - 1–24°C → Random: "Sunny", "Rainy", or "Cloudy"
     - ≥ 25°C → "Sunny"
3. Outputs each day's simulated data.
4. Calculates:
   - **Average temperature**
   - **Minimum temperature** (custom method)
   - **Maximum temperature** (built-in)
   - **Most common weather condition** (custom frequency analysis)

---

## 🧪 Example Output

```
Enter the number of days to simulate:
→ 5
It is 2 degrees and it is Cloudy
It is -4 degrees and it is Snowy
It is 30 degrees and it is Sunny
It is 10 degrees and it is Rainy
It is 0 degrees and it is Snowy
Average Temperature is: 7.6 degrees
The Max Temperature is: 30
The Min Temperature is: -4
Most common condition is: Snowy
```

---

## 🔧 Key Methods

### `CalculateAverage(int[] temperature)`
Returns the average of all temperatures.

### `MinTemperature(int[] temperature)`
Returns the smallest value in the array.

### `MostCommonCodition(string[] conditionsCheck)`
Counts occurrences and returns the most frequent weather condition.

---

## ✅ Improvements to Consider

- Fix bug in `CalculateAverage()` loop:  
  Replace:  
  ```csharp
  for (int i = 0; i < temperature[i]; i++)  // ❌ Wrong
  ```  
  With:  
  ```csharp
  for (int i = 0; i < temperature.Length; i++)  // ✅ Correct
  ```

- Handle exceptions for invalid user input using `int.TryParse()`.
- Allow temperatures and conditions to be printed in a formatted table.
- Add option to export results to a file.

---

## ▶️ How to Run

```bash
dotnet run
```

---

This project demonstrates practical use of **arrays, conditions, loops, randomness, and statistics** — perfect for intermediate C# learners. ☁️🌞❄️
