# whileLoop – Demonstrating the While Loop in C#

This C# console application demonstrates the usage of a `while` loop by simulating a people counter. The user is prompted to press enter to increment a count, and any non-empty input stops the loop.

## 📋 Key Concepts

- Basic `while` loop
- User input handling with `Console.ReadLine()`
- String comparison
- Simple counter logic

## 🔁 How It Works

1. The program starts with an empty string.
2. As long as the user presses enter (i.e., inputs an empty string), the counter increases.
3. The loop exits when the user inputs any text.
4. It then displays the total number of counted entries.

```csharp
while (Text.Equals(""))
{
    Console.WriteLine("Press enter to Count and anything else to Stop Counting.");
    Text = Console.ReadLine();
    counter++;
    Console.WriteLine("Current people count is {0}.", counter);
}

## 💡 Example Output

Press enter to Count and anything else to Stop Counting.

Current people count is 1.
Press enter to Count and anything else to Stop Counting.

Current people count is 2.
Press enter to Count and anything else to Stop Counting.
stop
There are 3 people. Press enter to close the program.

## 🚀 How to Run

dotnet run