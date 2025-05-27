// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());


if(age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else if(age >= 13)
{
    Console.WriteLine("Are you with your parents? Answer y or n");
    string isWithParents=Console.ReadLine();
    if(isWithParents == "y")
    {
        Console.WriteLine("Go party in the club with your parents!");
    }
    else
    {
        Console.WriteLine("No party for you today!");
    }
}
else
{
    Console.WriteLine("No party for you!");
}
Console.ReadKey();