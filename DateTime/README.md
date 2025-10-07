# 🕓 DateTime in C#

This project demonstrates how to use the **`DateTime`** and **`TimeSpan`** structures in C# to work with **dates, times, and date-based calculations**.

---

## 📘 Key Concepts

- Creating and displaying custom `DateTime` values  
- Accessing built-in properties like `DateTime.Now` and `DateTime.Today`  
- Adding and subtracting days  
- Getting specific components (year, month, day, hour, minute, etc.)  
- Calculating time differences using `TimeSpan`  
- Validating and parsing user input with `DateTime.TryParse()`  

---

## 🧠 Example Code

```csharp
using System;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2002, 01, 07);
            Console.WriteLine($"My birthday is {dateTime}");

            // Display current dates and times
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            // Display tomorrow’s date
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the " + tomorrow);

            // Day of the week
            Console.WriteLine("Today is " + DateTime.Today.DayOfWeek);

            // First day of a given year
            Console.WriteLine(GetFirstDayOfYear(2002));

            // Days in February (non-leap vs leap year)
            int days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine("Days in Feb 2002: " + days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: " + days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: " + now.Minute);

            Console.WriteLine($"The time is {DateTime.Now.Hour} o'clock and {DateTime.Now.Minute} minutes and {DateTime.Now.Second} seconds");

            // Ask for birthday input
            Console.WriteLine("Write your birthday in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old.", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
```

---

## 🧾 Output Example

```
My birthday is 2002/01/07 00:00:00
2025/10/06 00:00:00
2025/10/06 14:23:51
Tomorrow will be the 2025/10/07 00:00:00
Today is Monday
2002/01/01 00:00:00
Days in Feb 2002: 28
Days in Feb 2004: 29
Minute: 23
The time is 14 o'clock and 23 minutes and 51 seconds
Write your birthday in this format: yyyy-mm-dd
2002/01/07 00:00:00
You are 8620 days old.
```

---

## 💡 What You Learn

| Concept | Description |
|----------|--------------|
| **Creating DateTime** | `new DateTime(year, month, day)` |
| **Getting Current Time** | `DateTime.Now` returns current system time |
| **Getting Current Date** | `DateTime.Today` returns only the date (no time) |
| **Adding/Subtracting Dates** | `.AddDays(1)` or `.Subtract()` |
| **Leap Year Check** | `DateTime.DaysInMonth(year, month)` |
| **TimeSpan Calculations** | Use `.Subtract()` to get days, hours, etc. |
| **User Input Validation** | `DateTime.TryParse()` prevents crashes from invalid input |

---

## 🧩 Bonus: Useful DateTime Tricks

### 🔹 Display a Custom Date Format
```csharp
Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
```
👉 Output: `Monday, 06 October 2025`

### 🔹 Calculate Age in Years
```csharp
int age = DateTime.Now.Year - birthDate.Year;
if (DateTime.Now < birthDate.AddYears(age)) age--;
Console.WriteLine($"You are {age} years old.");
```

### 🔹 Get Time Between Two Dates
```csharp
TimeSpan diff = endDate - startDate;
Console.WriteLine($"Days between: {diff.Days}");
```

---

## ▶️ Run the Program

```bash
cd DateTime1
dotnet run
```

---

## 🧱 Summary

This project gives you a solid grasp of **C# date and time handling**, including:
- Creating, displaying, and manipulating dates  
- Performing date calculations  
- Handling user input safely  
- Formatting date output for real-world applications  

---

**Next Step:** Try extending it to calculate **next birthday countdowns** or **age in months and years**!

