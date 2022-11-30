//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9




double RandomDouble (double min, double max)
{
    Random Buffer  = new Random();
    double result = (Buffer.NextDouble() - 0.5) * (max - min);
    return result;   
}

double [,] FillArray (int rows, int columns, double min, double max)
{
    double [,] result = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result [i,j] = RandomDouble (min, max);
        }
    }
    return result;
}


void WriteArray ( double [,] Array)
{
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.Length / rows;

    Console.WriteLine($"number of rows: {rows}, number of columns: {columns}");
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {Array [i, j]:f2} ");
        }
    }
    Console.WriteLine("\n");
}

int columns, rows;

Console.Clear();
Console.WriteLine($"Enter number of columns: ");
columns = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter number of rows: ");
rows = int.Parse(Console.ReadLine()!);

double [,] Array = FillArray(rows, columns, -100, 100);
WriteArray (Array);

//Console.WriteLine($"Random number is: {RandomDouble(-100, 100)}");

