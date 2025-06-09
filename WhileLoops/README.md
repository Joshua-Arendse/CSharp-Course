# 🔐 SecretNumberGame – Guess the Number (1–100)

This interactive console game challenges the user to guess a secret number randomly selected by the computer between 1 and 100. It uses loops, random number generation, and conditional feedback to guide the user toward the correct answer.

---

## 📚 Concepts Practised

- ✅ `while` loop for repeated guessing
- ✅ Random number generation with `Random.Next()`
- ✅ Input parsing with `int.Parse()`
- ✅ Conditional logic (`if`, `else if`, `else`)
- ✅ Tracking attempts with a counter
- ✅ Output formatting and feedback

---

## 🧾 Summary

The program:

1. Picks a random number between 1 and 100 using `Random.Next(1, 101)`.
2. Prompts the user to guess the number repeatedly.
3. Provides feedback:
   - "Too high"
   - "Too low"
   - "Correct!"
4. Tracks the number of attempts made.
5. Displays the total guesses taken when the correct number is found.

---

## 🧪 Example Output

Guess the number I am thinking of between 1 and 100.
Enter your guess:
50
Too low, guess again!
Enter your guess:
75
Too high, guess again!
Enter your guess:
62
You guessed right the number is 62
It took you 3 number of times to get it.