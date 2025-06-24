# 🧠 QuizAppV2 – Object-Oriented Quiz Console Application

**QuizAppV2** is an improved, fully object-oriented C# console quiz game. It separates concerns using custom classes (`Question` and `Quiz`) and supports multiple-choice questions with coloured feedback, structured formatting, and final results analysis.

---

## 📚 Concepts Practised

- ✅ Object-Oriented Programming (OOP)
- ✅ Custom classes with constructors and methods
- ✅ Arrays and loops
- ✅ Input validation (`TryParse`)
- ✅ Console formatting and colour styling
- ✅ Encapsulation and private fields

---

## 🧩 Class Breakdown

### `Question.cs`
Defines a single quiz question.

```csharp
public class Question
{
    public string QuestionText { get; }
    public string[] Answers { get; }
    public int CorrectAnswerIndex { get; }

    public bool IsCorrectAnswer(int choice)
}
```

---

### `Quiz.cs`
Handles quiz flow, question display, scoring, and feedback.

```csharp
public class Quiz
{
    private Question[] _questions;
    private int _score;

    public void StartQuiz();
    private void DisplayQuestion(Question question);
    private void DisplayResults();
    private int GetUserChoice();
}
```

---

### `Program.cs`
Initialises quiz questions and starts the game.

```csharp
Question[] questions = new Question[]
{
    new Question("What is the capital of Germany?", new[]{"Paris","Berlin","London","Madrid"}, 1),
    ...
};

Quiz myQuiz = new Quiz(questions);
myQuiz.StartQuiz();
```

---

## 🧪 Example Output

```
╔═════════════════════════════════════════════════════════════════════════════╗
║                                 QUESTIONS                                   ║
╚═════════════════════════════════════════════════════════════════════════════╝
What is 2+2?
   1. 3
   2. 4
   3. 5
   4. 6
Your answer (Number): 2
Correct!

╔═════════════════════════════════════════════════════════════════════════════╗
║                                  RESULTS                                    ║
╚═════════════════════════════════════════════════════════════════════════════╝
Quiz Finished. Your score is: 4 out of 5
Excellent Work!
```

---

## ▶️ How to Run

```bash
dotnet run
```

Make sure all three files are in the same `namespace` and project folder:
- `Program.cs`
- `Quiz.cs`
- `Question.cs`

---

## 📌 Features

- Multiple-choice questions with dynamic answer display
- Immediate feedback after each question
- Final score and performance assessment
- Colour-coded feedback using `Console.ForegroundColor`
- Validates user input to prevent errors

---

## 🚀 Future Improvements

- Randomise question order
- Support dynamic number of answers
- Add categories or difficulty levels
- Store questions in an external file (JSON or XML)
- Track high scores or quiz history

---

This project is a great example of applying **OOP principles** in a fun and interactive way, with clean user experience and solid programming structure. Ideal for portfolios and beginner-intermediate C# developers. 🎯
