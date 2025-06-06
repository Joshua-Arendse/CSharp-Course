# 🎯 NumberGuessingGame – Guess the Random Number in C#

This mini-project challenges the user to guess a randomly generated number between 1 and 10. It demonstrates randomness, input validation, and conditional logic in a simple, engaging way.

---

## 📚 Concepts Practised

- ✅ Generating random numbers using `Random.Next()`
- ✅ Reading and parsing user input with `int.TryParse()`
- ✅ Conditional statements (`if-else`)
- ✅ Input validation and user feedback
- ✅ Working with the `Random` class

---

## 🧾 Summary

The program:

1. Generates a random number between 1 and 10.
2. Prompts the user to enter a guess.
3. Validates if the input is a number.
4. Compares the user’s guess with the random number.
5. Displays whether the guess was correct or incorrect.

---

## 🧪 Example Output

Guess a number

7
You guessed wrong, try again!

Guess a number

5
You guessed right!

Guess a number

hello
Haha you troll, enter a number.

---

## 🎲 Random Number Details

```csharp
Random random = new Random();
int randomNum = random.Next(1, 11); // 1 to 10 inclusive (max is exclusive)
