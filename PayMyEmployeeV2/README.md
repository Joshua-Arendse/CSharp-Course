# 🧾 PayMyEmployeeV2 – Windows Forms Salary Calculator in C#

This is a **C# Windows Forms Application** that calculates an employee’s net pay after applying deductions for Pension, Medical Aid, and UIF. It provides a user-friendly interface to input employee data and displays a formatted salary breakdown.

---

## 📸 Screenshot

![PayMyEmployeeV2 UI](4bc5fe43-9103-4442-8faa-ba7769e4fd4c.png)

---

## 🧠 Features

- Input fields for:
  - Name
  - Surname
  - Employee ID
  - Hours Worked
  - Hourly Rate
- "Calculate Pay" button:
  - Computes gross salary and applies:
    - Pension Fund: 5%
    - Medical Aid: 6%
    - UIF: 4%
  - Displays formatted output in a rich textbox.
- "Clear" button:
  - Resets all input fields and the output box.

---

## 🧮 Calculation Logic

```csharp
double TotalPay = hourlyRate * hoursWorked;

double pensionFund = TotalPay * 0.05;
double medicalAid = TotalPay * 0.06;
double UIF = TotalPay * 0.04;

double Deductions = pensionFund + medicalAid + UIF;
double ActualPay = TotalPay - Deductions;
```

---

## 🖥️ Technologies Used

- C#
- Windows Forms (WinForms)
- Visual Studio Designer for UI layout

---

## ▶️ How to Run

1. Open the project in **Visual Studio**.
2. Build the solution.
3. Press `F5` or click **Start** to run the application.

---

## 💡 Notes

- Error handling (e.g. for non-numeric input) is not yet implemented. Consider wrapping `double.Parse` calls in `try-catch` or using `TryParse()` for a safer experience.
- The UI has a “Matrix”-style background for a fun aesthetic.

---

## 📌 Future Improvements

- Add input validation
- Display detailed deduction breakdown
- Option to print or export pay slip
- Local currency formatting (e.g. R###.##)

---

This project demonstrates how to combine **UI development with business logic** in C# using Windows Forms. Perfect for students or anyone building a payroll prototype. 💼
