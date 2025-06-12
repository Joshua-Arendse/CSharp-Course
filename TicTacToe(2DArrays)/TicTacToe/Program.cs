// See https://aka.ms/new-console-template for more information

int[,] array2DDeclare = new int[3, 3];
//[0] [0] [0]
//[0] [0] [0]
//[0] [0] [0]

int[,] array2DInitialize = { { 1, 2 }, { 3, 4 } };
//[1] [2] -row 0
//[3] [4] -row 1

string[,] understandingIndexes =
{
    {"0,0","0,1","0,2" },
    {"1,0","1,1","2,2" },
    {"2,0","1,1","2,2" }
};

Console.WriteLine(array2DInitialize[0, 0]);

array2DInitialize[0, 0] = 5;
Console.WriteLine(array2DInitialize[0, 0]);


string[,] ticTactoeField =
{
    {"O","X","X" },
    {"O","O","X" },
    {"X","X","O" }
};



Console.WriteLine(ticTactoeField[1, 2]);

Console.ReadKey();