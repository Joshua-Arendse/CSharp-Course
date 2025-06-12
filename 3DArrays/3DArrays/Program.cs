// See https://aka.ms/new-console-template for more information

int[,,] Array3D = new int[3, 3, 3];

string[,,] simple3DArray =
{
    {
        {"000","001" },
        {"010","011" }
    },
    {
        {"100","101" },
        {"110","111" }
    }
};

// Iterating over 2D arrays using loops

int[,] arrayName = new int[3, 3];

// Iterate over rows
for (int i = 0; i < arrayName.GetLength(0); i++)
{
    // Iterate over columns
    for (int j = 0; j < arrayName.GetLength(1); j++)
    {
        // Access and do something with each element
        Console.Write(arrayName[i, j] + " ");
    }
    Console.WriteLine(); // Move to the next line after printing each row
}


Console.ReadKey();