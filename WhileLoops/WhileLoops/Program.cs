// See https://aka.ms/new-console-template for more information

Random random = new Random();

int secretNum = random.Next(1, 101);
int userNum = 0;
int counter = 0;

Console.WriteLine("Guess the number I am thinking of between 1 and 100.");

while (userNum != secretNum)
{
    counter++;
    Console.WriteLine("Enter your guess: ");
    userNum = int.Parse(Console.ReadLine());
    
    if (userNum > secretNum)
    {
        Console.WriteLine("Too high, guess again!");
    }else if (userNum < secretNum)
    {
        Console.WriteLine("Too low, guess again!");
    }
    else
    {
        Console.WriteLine("You guessed right the number is " + secretNum);
        Console.WriteLine($"It took you {counter} number of times to get it.");
    }
}


Console.ReadKey();