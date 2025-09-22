# ✊✋✌️ Rock-Paper-Scissors Game in C#

This project is a simple **console-based Rock-Paper-Scissors game** where the player competes against the computer.

---

## 📖 Features
- Player chooses between **Rock, Paper, or Scissors**.
- Computer randomly selects its choice.
- The program evaluates:
  - **Tie** (both choose the same).
  - **Player wins** (Rock beats Scissors, Paper beats Rock, Scissors beat Paper).
  - **Computer wins** (remaining cases).
- After each round, the player can choose to **play again**.

---

## 🖥️ Example Code

```csharp
Random random = new Random();
bool PlayAgain = true;
string player = "";
string computer = "";

while (PlayAgain)
{
    while(player != "ROCK" && player != "SCISSORS" && player != "PAPER")
    {
        Console.WriteLine("Choose between Rock, Paper or Scissors: ");
        player = Console.ReadLine()?.ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1: computer = "ROCK"; break;
        case 2: computer = "SCISSORS"; break;
        case 3: computer = "PAPER"; break;
    }

    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    if (player == computer)
        Console.WriteLine("It's a tie!");
    else if ((player == "ROCK" && computer == "SCISSORS") ||
             (player == "PAPER" && computer == "ROCK") ||
             (player == "SCISSORS" && computer == "PAPER"))
        Console.WriteLine("You win!");
    else
        Console.WriteLine("Computer wins!");

    Console.Write("Do you want to play again? (Y/N): ");
    string answer = Console.ReadLine()?.ToUpper();
    if (answer != "Y") PlayAgain = false;

    Console.WriteLine();
}

Console.WriteLine("Thanks for playing!");
```

---

## ▶️ Example Gameplay

```
Choose between Rock, Paper or Scissors:
rock
Player: ROCK
Computer: SCISSORS
You win!

Do you want to play again? (Y/N): y

Choose between Rock, Paper or Scissors:
scissors
Player: SCISSORS
Computer: ROCK
Computer wins!

Do you want to play again? (Y/N): n
Thanks for playing!
```

---

## 🧠 What You Learn
- Using **`Random`** to generate unpredictable computer choices.
- Using **loops** to continue gameplay until the user decides to stop.
- Using **string manipulation** (`.ToUpper()`) to make input case-insensitive.
- Implementing **basic game logic** with `if-else` conditions.

---

## ▶️ Run the Program
```bash
cd RockPaperScissors
dotnet run
```
