// See https://aka.ms/new-console-template for more information

//1. Sum of The Rows Exercise
using System;

int[,] array = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

for (int i = 0; i < 3; i++) // Loop through each row
{
    int sum = 0;
    for (int j = 0; j < 3; j++) // Loop through each column in the current row
    {
        sum += array[i, j]; // Add the element to the sum
    }
    Console.WriteLine(sum); // Print the sum of the current row
}

Console.ReadKey();

//2. Multiplication table that prints the multiplication table for numbers 1 to 10

for(int i = 1;i <= 10; i++)
{
    for (int j = 1;j <= 10; j++)
    {
        int multiples = i * j;
        
        if(j==10) // when it reaches 10 it moves to the next line
        {
            Console.Write(multiples + "\n");
        }else
        {
            Console.Write(multiples + "\t");
        }//using Write and not WriteLine so that the \t (tab) will work effectively
    }
}

Console.ReadKey();

//3. Find the Largest Number in an array

int[] largeNum = new int[] { 12, 45, 67, 89, 327, 98, 2, 38, 231, 87 };
int larger = 0;

foreach (int num in largeNum)
{
    if (larger < num)
    {
        larger = num;
    }
}
Console.WriteLine("The largest number is: " + larger);

Console.ReadKey();

//4. Reverse an Array:

int length = largeNum.Length;
Console.WriteLine("Reversed Array:");
for (int i = (length-1); i >=0; i--)
{
    Console.Write(largeNum[i] + "\t");
}
Console.Write('\n');
Console.ReadKey();

//5. Count Vowels in a String:

Console.WriteLine("Type something and I will tell you how many vowels are inside of it:");
string input = Console.ReadLine();
input = input.ToLower();
int vowelNum = 0;

foreach (char c in input)
{
    switch (c)
    {
        case 'a':
            vowelNum++;
            break;
        case 'e':
            vowelNum++;
            break;
        case 'i':
            vowelNum++;
            break;
        case 'o':
            vowelNum++;
            break;
        case 'u':
            vowelNum++;
            break;
    }
}

Console.WriteLine("You have {0} Vowels.",vowelNum);

Console.ReadKey();

//6. Sum of Digits: takes a number and calculates the sum of its digits.

Console.Write("Type a random number: ");
string num1 = Console.ReadLine();
int sum1 = 0;
foreach (char i in num1)
{
    int j = i - '0'; // The ASCII value for the character '0' is 48, '1' is 49, and so on up to '9', which is 57. By subtracting the ASCII value of '0' from any digit character, you get its integer value.
    sum1 += j;
}
Console.WriteLine(sum1);
Console.ReadKey();

//7. Fibonacci Sequence: prints the first N numbers in the Fibonacci sequence.

Console.Write("Enter the number of terms in the Fibonacci sequence: ");
int N = int.Parse(Console.ReadLine());

int first = 0, second = 1, next;

for (int i = 0; i < N; i++)
{
    if (i <= 1)
    {
        next = i;
    }
    else
    {
        next = first + second;
        first = second;
        second = next;
    }
    Console.Write(next + " ");
}
Console.Write("\n");
Console.ReadKey();

//8. Prime Numbers: prints all prime numbers between 1 and 100.

int primeNum = 3;

for (int i = 1;i < 101; i++)
{
    if ((i % 2) == 0)
    {

    }else if((i%3) == 0) 
    {
        
    }else if((i%5) == 0)
    {

    }else if((i%7) == 0)
    {

    }else
    {
        Console.Write(i + " ");
        primeNum++;
    }
}

Console.WriteLine("There are {0} Prime numbers from 1 to 100", primeNum);
Console.ReadKey();

//9. Pattern Printing: prints a pyramid pattern of stars:

Console.Write("Enter the number of rows for the pyramid: ");
int rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    // Print leading spaces
    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }

    // Print stars
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    // Move to the next line
    Console.WriteLine();
}

Console.ReadKey();