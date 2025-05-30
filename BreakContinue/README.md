# BreakContinue – Demonstrating Break and Continue in C#

This C# console application illustrates how to use the `break` and `continue` keywords in `for` loops to alter the control flow based on conditions.

## 📋 Key Concepts

- `break`: Exits the loop immediately when a specific condition is met.
- `continue`: Skips the rest of the loop's body for the current iteration when a condition is met.

## 🔁 How It Works

### Break Example

The loop prints numbers from `0` to `9`, but stops when it reaches `3`.

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if(i == 3)
    {
        Console.WriteLine("At 3 we stop!");
        break;
    }
}

## Continue Example
The loop iterates from 0 to 9. If the number is even (i % 2 == 0), it prints "Odd Number!" and skips the rest of the iteration. If the number is odd, it prints the number itself.

```csharp

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Odd Number!");
        continue;
    }
    Console.WriteLine(i);
}

## 💡 Example Output

0
1
2
3
At 3 we stop!
Odd Number!
1
Odd Number!
3
Odd Number!
5
Odd Number!
7
Odd Number!
9

## 🚀 How to Run

dotnet run