# 📊 StudentGradeTracker – Grade Input and Analysis Console App

**StudentGradeTracker** is a beginner-friendly C# console application that lets a student enter their personal details and a set of test/exam grades. It stores the grades, calculates the average, and displays all the details neatly.

---

## 🧠 Concepts Practised

- ✅ Custom classes (`Student`)
- ✅ Arrays
- ✅ Looping with `while`
- ✅ User input and validation
- ✅ Encapsulation and class design
- ✅ Method creation (`AddGrade`, `GetAverageGrade`, `DisplayDetails`)

---

## 🧾 Program Flow

1. Prompts user for:
   - Number of grades to be entered
   - Student name
   - Student ID
2. Accepts each grade one-by-one in a loop
3. Stores grades in an internal array
4. Displays:
   - Name and ID
   - All grades
   - Average grade

---

## 🧩 Class: `Student`

```csharp
public class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int[] Grades { get; set; }

    public void AddGrade(int grade);
    public double GetAverageGrade();
    public void DisplayDetails();
}
```

Grades are stored in a fixed-length array, determined by the user at runtime.

---

## 🧪 Sample Output

```
How many tests/exams do you want to enter?
→ 3
Enter your name:
→ Joshua
Enter your ID:
→ ST123

Add your grade(percentage):
→ 85
Add your grade(percentage):
→ 90
Add your grade(percentage):
→ 78

Name: Joshua
ID: ST123
Grades: 85 90 78
Average Grade: 84.33
```

---

## ▶️ How to Run

```bash
dotnet run
```

The program runs in the terminal and waits for inputs step-by-step.

---

## ✅ Key Features

- Prevents entering more grades than allowed
- Handles average calculation safely (avoids divide-by-zero)
- Easy-to-read output format
- Class encapsulates logic for grade storage and analysis

---

## 💡 Ideas for Future Features

- Add grade letter evaluation (A/B/C/D/F)
- Accept decimal grades (convert to `double`)
- Store student data in a file or database
- Add multiple students in one run

---

This project is perfect for understanding how to use **classes, arrays, and basic data processing** in a real-world context. 🎓
