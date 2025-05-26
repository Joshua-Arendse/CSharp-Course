# TryParse – Safe Input Parsing in C#

This project illustrates how to safely handle user input in C# using the `int.TryParse()` method. It helps avoid runtime errors when parsing strings that may not be valid integers.

## 💡 What It Does

- Prompts the user to enter a temperature value.
- Attempts to convert the input string to an integer using `TryParse`.
- If conversion fails, sets the temperature to `0` and notifies the user.
- Outputs temperature-based advice using `if-else` statements.

## 🧠 Key Concepts

- `int.TryParse()` for safe string-to-integer conversion.
- Use of `out` parameters.
- Conditional logic with `if`, `else if`, and `else`.
- Handling user input gracefully.

## 🧪 Example Output

```text
What is the temperature?
twelve
Value entered, was no number. 0 set as temperature
Take the coat
