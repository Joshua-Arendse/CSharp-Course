// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the adventure game!");
Console.WriteLine("Enter your character's name: ");
string userCharacter = Console.ReadLine();
Console.WriteLine("What is your character type?(Warrior,Wizard or Archer)");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {userCharacter} the {characterType} find yourself at the end pf the dark forest.");
Console.WriteLine("Do you enter the forest or do you camp outside? [Enter/Camp]");
string choice1 = Console.ReadLine();

if(choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely entered the forest.");
}
else
{
    Console.WriteLine("You decided to camp till daylight.");
}

bool gameContinue = true;

if (gameContinue)
{
    Console.WriteLine("You have reached a fork in the road. Go left or right?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "Left")
    {
        Console.WriteLine("You have found a Treasure chest!");
        gameContinue = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast. fight or flee? [fight/flee]");
        string fightchoice = Console.ReadLine();
        if (fightchoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if(luck > 5)
            {
                Console.WriteLine("You have defeated the beast!");
                if(luck > 8)
                {
                    Console.WriteLine("The beast dropped a Treasure!");
                }
            }
            else
            {
                Console.WriteLine("You Died.");
                gameContinue = false;
            }
        }
    }
}

Console.WriteLine("Thank you for playing the game.");
Console.WriteLine("Game over.");

Console.ReadKey();