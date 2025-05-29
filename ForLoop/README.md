# ForLoop – Exploring For Loops in C#

This C# console application demonstrates different forms of `for` loops, showcasing how loop control variables can be used for various counting strategies.

## 🔍 What It Covers

- Basic loop incrementing
- Custom step values (e.g. +5)
- Odd number iteration using step size of 2

## 📋 Loop Demonstrations

1. **Simple counter (0–9)**:
   ```csharp
   for(int counter = 0; counter < 10; counter++)
   {
       Console.WriteLine(counter);
   }

2. Count in steps of 5 (0–45):

for (int counter = 0; counter < 50; counter += 5)
{
  Console.WriteLine(counter + " is lower than 50");
}

3. Odd numbers (1–19):

for(int num = 1; num < 20; num += 2)
{
    Console.WriteLine(num);
}

## 💻 Example Output

0
1
2
...
9
0 is lower than 50
5 is lower than 50
...
45 is lower than 50
1
3
5
...
19

## 🚀 How to Run

dotnet run
