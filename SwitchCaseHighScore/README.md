# SwitchCaseHighScore – Basic High Score Tracker in C#

This C# console application implements a simple high score tracker that compares player scores to the current high score and updates it if the new score is higher.

## 🕹️ What It Does

- Stores a static high score and player name.
- Uses a method called `Highscore(score, player)` to:
  - Compare the input score to the current high score.
  - Print whether the high score has been beaten or remains unchanged.
  - Update the high score and holder if needed.

## 📦 Example Output

The Old Highscore of 600 could not be broken and is still held by Joshua.
New Highscore is 650!
New Highscore holder is Rick!
New Highscore is 999!
New Highscore holder is Joshua!


## 🔍 Code Highlights

- **Static Variables:** Used to persist the high score (`HScore`) and player (`HSPlayer`) across method calls.
- **Conditional Logic:** `if-else` checks whether the current score beats the high score.
- **Method Design:** `Highscore()` takes two parameters – score and player – for each attempt.

## 🚀 How to Run

```bash
dotnet run
