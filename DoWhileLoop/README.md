# DoWhileLoop – Demonstrating the Do-While Loop in C#

This C# console application demonstrates the usage of the `do-while` loop by prompting the user to enter the names of friends repeatedly until the total length of all names entered reaches at least 20 characters.

## 📋 Key Concepts

- Use of the `do-while` loop, which ensures the loop body runs at least once
- String manipulation and concatenation
- Tracking cumulative string length

## 🔁 How It Works

The program:
1. Asks the user to enter a friend's name.
2. Calculates the length of each name entered.
3. Accumulates the total length until it reaches or exceeds 20 characters.
4. Ends once the character limit is met or exceeded.

```csharp
do
{
    Console.WriteLine("Enter the name of a friend:");
    string friendName = Console.ReadLine();
    int nameLength = friendName.Length;
    lengthOfText += nameLength;
    wholeText += nameLength;
} while (lengthOfText < 20);

## 💡 Example Output

Enter the name of a friend:
Alice
Enter the name of a friend:
Bob
Enter the name of a friend:
Catherine

## 🚀 How to Run

dotnet run