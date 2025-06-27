# C# Practice Projects – Beginner Console Apps

This repository contains a collection of beginner-level C# console applications. Each project was created while learning fundamental programming concepts in C#. The goal is to practise syntax, understand the basics of programming, and build a strong foundation for more advanced software development.

---

## 📁 Project List

| Project Name               | Description |
|----------------------------|-------------|
| `HelloWorld`               | Basic program that prints "Hello, World!" to the console. |
| `BeepApp`                  | Demonstrates simple method calls with `Console.Beep()` and output. |
| `Var1`                     | Declares numeric variables, performs arithmetic, and uses multiple data types. |
| `Var2`                     | Demonstrates string concatenation and `.ToUpper()` method. |
| `Conversion`               | Demonstrates implicit and explicit type conversions and `.ToString()`. |
| `ParsingString`            | Parses numeric strings using `int.Parse()` and `float.Parse()`. |
| `DatatypesAndVariables`    | Outputs different data types including `byte`, `sbyte`, `long`, `char`, and more. |
| `StringManipulation`       | Covers string formatting, interpolation, and verbatim strings. |
| `StringMethods`            | Uses string methods like `.Trim()`, `.Substring()`, `.ToLower()`, `.ToUpper()`. |
| `StringMethods2`           | Demonstrates `IndexOf()` and `string.Concat()` for combining input. |
| `VoidMethods`              | Uses basic `void` methods with and without parameters. |
| `Methods`                  | Arithmetic methods that return values (add, multiply, divide). |
| `MethodChallenge`          | Uses a method to greet several people with custom names. |
| `UserInput`                | Accepts and converts user input using `Convert.ToInt16()` and `int.Parse()`. |
| `IfStatements`             | Uses conditional statements to display temperature advice. |
| `TryParse`                 | Parses input safely using `int.TryParse()` and handles fallback. |
| `NestedIfStatements`       | Uses nested conditionals to simulate login/access logic. |
| `IfStatementsLogin`        | Simulates registration and login using username/password. |
| `TernaryOperatorChallenge` | Uses nested ternary operators to evaluate temperature categories. |
| `SwitchStatement`          | Implements `switch-case` for numeric and string comparisons. |
| `SwitchCaseHighScore`      | Tracks and updates a high score using class members and conditions. |
| `EnhancedIfStatement`      | Compares ternary logic to traditional `if-else`. |
| `Operators`                | Demonstrates arithmetic, relational, and logical operators. |
| `TryCatchAndFinally`       | Uses `try-catch-finally` blocks to handle format and divide-by-zero exceptions. |
| `ForLoop`                  | Shows standard and stepped `for` loops for counting and iteration. |
| `DoWhileLoop`              | Uses a `do-while` loop to collect names until a character length limit is reached. |
| `whileLoop`                | Simulates a people counter that increments until input breaks the loop. |
| `BreakContinue`            | Demonstrates how to interrupt or skip loop iterations with `break` and `continue`. |
| `LoopsChallenge`           | Collects scores between 1–20 and calculates average after user exits. |
| `Arrays`                   | Covers multiple ways to declare and initialise arrays. |
| `ForEachLoop`              | Demonstrates looping over arrays with a `foreach` loop. |
| `PracticeCode`             | Reinforces variable declaration, reassignment, and array indexing. |
| `SmallCalculator`          | Adds numbers using `Convert.ToInt32()` and `int.Parse()` with user input. |
| `QuizApp`                  | A 3-question quiz with answer checking, score tracking, and feedback. |
| `NumberGuessingGame`       | A number guessing game using `Random.Next()` and input validation. |
| `CountingLoops`            | Demonstrates upward and downward `for` loops with output at each step. |
| `RocketAnimation`          | Console animation using `Console.Clear()` and `Thread.Sleep()`. |
| `AdventureGame`            | Text-based RPG with character input, choices, and random outcomes. |
| `ClassAverageCalculator`   | Calculates class average and percentage based on user input. |
| `ProgrammingChallenges`    | Collection of mini-exercises: sum of digits, Fibonacci, primes, patterns, etc. |
| `WeatherSimulator`         | Generates random weather conditions over a number of days, with average calculation. |
| `MethodsAndFunctionsPractice` | Group of five mini apps: degree converter, calculator, string reversal, factorial, palindrome checker. |
| `ClassesAndObjects`        | Demonstrates class creation, constructors, and object instantiation. |
| `Properties`               | Introduces properties with `get` and `set` to encapsulate private fields. |
| `Members`                  | Uses access modifiers, a constructor, and methods to encapsulate data and behaviour. |
| `ClassesApp`               | Advanced OOP with constructors, properties, named parameters, readonly fields, and computed properties. |
| `QuizAppV2`                | Fully object-oriented multiple choice quiz with a `Question` and `Quiz` class. |
| `StudentGradeTracker`      | Tracks student scores with an array and calculates the average. |
| `ToDoList`                 | Console-based task manager using a `List<Task>` with due dates and completion status. |
| `BankAccountSimulator`     | Simulates a real-world bank account with deposit, withdrawal, and encapsulated balance.

---

## 🔧 Technologies Used

- **Language**: C#
- **Framework**: .NET 6 / .NET Core
- **IDE**: Visual Studio / Visual Studio Code

---

## 🧠 Concepts Covered

| Topic                     | Covered In Projects |
|--------------------------|----------------------|
| ✅ Variables & Data Types | `Var1`, `DatatypesAndVariables`, `PracticeCode` |
| ✅ Input & Output         | Almost all projects |
| ✅ Type Conversion        | `Conversion`, `SmallCalculator`, `TryParse` |
| ✅ Conditionals           | `IfStatements`, `AdventureGame`, `QuizApp` |
| ✅ Loops & Control Flow   | `ForLoop`, `LoopsChallenge`, `BreakContinue`, `ProgrammingChallenges` |
| ✅ Methods & Reusability  | `VoidMethods`, `MethodBasics`, `AddTwoValues`, `MethodsAndFunctionsPractice` |
| ✅ Arrays & Indexing      | `Arrays`, `ForEachLoop`, `MultiDimensionalArraysAdvanced` |
| ✅ OOP (Classes & Objects)| `ClassesAndObjects`, `Properties`, `Members`, `ClassesApp`, `BankAccountSimulator` |
| ✅ Exception Handling     | `TryCatchAndFinally`, `TryParse` |
| ✅ Randomness & Games     | `NumberGuessingGame`, `RocketAnimation`, `WeatherSimulator`, `AdventureGame` |
| ✅ Mini Challenges        | `ProgrammingChallenges`, `ClassAverageCalculator`, `StudentGradeTracker` |

---

## ▶️ Running Projects

Make sure you have the .NET SDK installed.

To run a project:
```bash
cd ProjectFolderName
dotnet run
```