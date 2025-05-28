# TernaryOperatorChallenge – Weather Feedback via Ternary Logic (C#)

This C# console app challenges you to use nested ternary operators to output a message based on the temperature entered by the user. It also includes input validation using `int.TryParse()`.

## 🔍 What It Covers

- **User input validation** using `TryParse`
- **Ternary operator** for compact decision logic
- **Nested ternary** conditions for multiple cases

## 🌡️ Temperature Evaluation Logic

- **≤ 15°C** → _"it is too cold here"_
- **16°C – 28°C** → _"it is ok"_
- **> 28°C** → _"it is hot here"_

## 💻 Example Output

Enter the Temperature:
12
it is too cold here

Copy
Edit
Enter the Temperature:
22
it is ok

Copy
Edit
Enter the Temperature:
35
it is hot here

Copy
Edit
Enter the Temperature:
abc
Not a valid Temperature.


## 📚 Key Code

```csharp
string temp1 = temp <= 15 ? "it is too cold here" 
             : temp <= 28 ? "it is ok" 
             : "it is hot here";
