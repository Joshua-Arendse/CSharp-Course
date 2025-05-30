# LoopsChallenge – Student Score Averager in C#

This C# console application uses a `while` loop to collect student scores from the user. The loop continues until the user enters `-1`, at which point it calculates and displays the average score.

## 🧠 Learning Concepts

- `while` loops
- `continue` and `if` conditionals
- `int.TryParse()` for safe string-to-int conversion
- Basic input validation

## 📋 Rules

- The user may enter multiple scores, one at a time.
- Only scores between `1` and `20` (inclusive) are valid.
- Typing `-1` ends the loop and triggers the average calculation.
- Invalid inputs are rejected with a prompt to try again.

## 🧮 Example Flow

Last number was 0
Please enter the next score
Current amount of entries 0
Please enter -1 to calculate the average when you are done.

18
Last number was 18
Please enter the next score
Current amount of entries 1
Please enter -1 to calculate the average when you are done.
21
Enter a value between 1 and 20!
Last number was 18
Please enter the next score
Current amount of entries 1
Please enter -1 to calculate the average when you are done.
10
Last number was 10
Please enter the next score
Current amount of entries 2
Please enter -1 to calculate the average when you are done.
-1

The average score of your students is 14


## 🚀 How to Run

```bash
dotnet run

