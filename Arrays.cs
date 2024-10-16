using System;

//2D - array:

Console.WriteLine("2D Array:");

int[,] Array2D = new int[4, 4];
Random rnd = new Random();

//Array erstellen:
for (int x = 0; x < Array2D.GetLength(1); x++)
{
    for (int y = 0; y < Array2D.GetLength(0); y++)
    {
        Array2D[x, y] = rnd.Next(2, 99);
    }
}

//Array ausgeben:
for (int x = 0; x < Array2D.GetLength(1); x++)
{
    for (int y = 0; y < Array2D.GetLength(0); y++)
    {
        Console.Write(Array2D[x, y] + " \t ");

    }
    Console.WriteLine();
}

//Diaonale:
Console.WriteLine("Diagonale:");
for (int x = 0; x < Array2D.GetLength(1); x++)
{

    for (int y = 0; y < Array2D.GetLength(0); y++)
    {
        if (x == y)
        {
            Console.Write(Array2D[x, y]);

        }
        Console.Write("\t");
    }
    Console.WriteLine();
}
