//Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет



int [,] FillArray (int rows, int columns, int min, int max)
{
    int [,] result = new int [rows, columns];
    Random k = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           result [i,j] = k.Next(min, max);
        }
    }
    return result;
}


void WriteArray ( int [,] Array)
{
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.Length / rows;

    Console.WriteLine($"number of rows: {rows}, number of columns: {columns}");
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {Array [i, j]} ");
        }
    }
    Console.WriteLine("\n");
}

int [] FindNumberPosition (int [,] Array, int target)
{
    int [] result = new int [2];
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            if (target == Array [i, j])
            {
                result [0] = i;
                result [1] = j;
                return result;
            }
        }
    }
    result [0] = -1;
    result [1] = -1;
    return result;
}


int columns, rows;

Console.Clear();

Console.WriteLine($"Enter number of columns: ");
columns = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Enter number of rows: ");
rows = int.Parse(Console.ReadLine()!);

int [,] Array = FillArray(rows, columns, -100, 100);

WriteArray (Array);

Console.WriteLine($"Enter the target number: ");
int target = int.Parse(Console.ReadLine()!);

int [] indexOfNumber = FindNumberPosition( Array, target );

if (indexOfNumber[0] == -1) Console.WriteLine($"There no such number in the array.");
else Console.WriteLine($"The target number is in the row {indexOfNumber[0]+1}, column {indexOfNumber[1]+1}");


