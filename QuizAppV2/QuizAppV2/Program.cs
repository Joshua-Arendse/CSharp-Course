namespace QuizAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?", // Question Text
                    new string[]{"Paris","Berlin","London","Madrid"}, // Answers Array
                    1 // CorrectAnswerIndex
                ),
                new Question(
                    "What is 2+2?", // Question Text
                    new string[]{"3","4","5","6"}, // Answers Array
                    1 // CorrectAnswerIndex
                ),
                new Question(
                    "Who wrote 'Hamlet'?", // Question Text
                    new string[]{"Shakespeare","Goethe","Austen","Dickens"}, // Answers Array
                    0 // CorrectAnswerIndex
                ),
                new Question(
                    "What is an Apple?", // Question Text
                    new string[]{"Apple","Vegetable","Fruit","Alien"}, // Answers Array
                    2 // CorrectAnswerIndex
                ),
                new Question(
                    "How many provinces does South-Africa have?", // Question Text
                    new string[]{"3","7","12","9"}, // Answers Array
                    3 // CorrectAnswerIndex
                )
            };


            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
