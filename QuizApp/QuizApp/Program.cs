// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What is the colour you get by mixing blue and yellow?";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect it is: " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect it is: " + answer2);
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect it is: " + answer3);
}

Console.WriteLine($"Quiz Completed! You have scored {score}/3.");

if(score == 3)
{
    Console.WriteLine("Well done you have answered all question Correctly!");
}
else
{
    Console.WriteLine("You did not get all question right, better luck next time.");
}

Console.ReadKey();