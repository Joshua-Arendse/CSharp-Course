// See https://aka.ms/new-console-template for more information

//creating an instance of the Random Class
Random random = new Random();
//this will give us a random number between 1 and 10
int randomNum = random.Next(1, 11); //the max value is exclusive

Console.WriteLine("Guess a number");

string inputString= Console.ReadLine();
int num1 = 0;

bool isNumber= int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNum)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
}
else
{
    Console.WriteLine("Haha you troll, enter a number.");
}

Console.ReadKey();
