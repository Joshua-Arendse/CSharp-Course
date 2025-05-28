# EnhancedIfStatement – Ternary Operator in Action (C#)

This C# console application demonstrates the use of the ternary (conditional) operator to determine the physical state of matter based on temperature.

## 🔍 What It Covers

- **Standard `if-else` structure**
- **Ternary operator**: `condition ? true_result : false_result`
- **Nested ternary operators** for multiple outcomes

## 🧪 Scenario

Temperature is evaluated in degrees Celsius:

- Below 0°C → **solid**
- Between 0°C and 100°C → **liquid**
- Above 100°C → **gas**

## 💻 Example Output

State of matter is solid
State of matter is liquid
State of matter is gas


## 📚 Code Breakdown

```csharp
// Traditional if-else
if (temp < 0)
    stateOfMatter = "solid";
else
    stateOfMatter = "liquid";

// Ternary form
stateOfMatter = temp < 0 ? "solid" : "liquid";

// Nested ternary to include gas
stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
