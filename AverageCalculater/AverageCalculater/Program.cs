// See https://aka.ms/new-console-template for more information

int currentScore = 0;
int sum = 0;
int counter = 0;

Console.WriteLine("Enter the Total Mark");
int totalMark = int.Parse(Console.ReadLine());


do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish!");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
        sum += currentScore;
        counter++;
    }
} while (currentScore != -1);

decimal average= sum/counter;
Console.WriteLine("The average score for your class is: " + average);

decimal percent = (average / totalMark) * 100;
Console.WriteLine($"Your class average percentage is {percent}%");

Console.ReadKey();