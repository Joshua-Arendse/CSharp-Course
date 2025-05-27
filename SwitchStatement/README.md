# SwitchStatement – Using Switch and If-Else in C#

This C# console project demonstrates how to use `switch` statements to handle multiple conditions, as well as how to write equivalent logic using `if-else`.

## 🎯 What It Does

- Defines an `age` variable and checks it with a `switch` statement and `if-else`.
- Demonstrates `switch` usage with both integer and string values.
- Highlights how control flow can be simplified using `switch` instead of long `if-else` chains.

## 🧪 Sample Output

Good to go!
Good to go!
Username is Joshua


## 🔄 Logic Flow

### Age Switch
```csharp
switch (age)
{
    case 15: → "Too young to party in the club!"
    case 25: → "Good to go!"
    default: → "How old are you then?"
}

### Username Switch
switch (username)
{
    case "Joshua": → "Username is Joshua"
    case "bob": → "Username is bob"
    default: → "Username is Unknown"
}
