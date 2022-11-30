//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] FillArray (int rows, int columns, int min, int max)
{
    int [,] result = new int [rows, columns];
    Random k = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           result [i,j] = k.Next(min+1, max);
        }
    }
    return result;
}


void WriteArray ( int [,] Array)
{
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.Length / rows;
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            string c = (Array[i,j] > 0) ? " " : "";
            Console.Write($"\t{c}{Array [i, j]:d2}");
        }
        Console.Write("\n");
    }
}

void WriteArray1D ( double [] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"\t{Array [i]:f2}");
    }
    Console.WriteLine("\n");
}



double [] FindAriphmeticMeanByColumns (int [,] Array)
{
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.Length / rows;
    double [] result = new double [columns];

    for (int j = 0; j < columns; j++)
    {
        double accumulator = 0;
        for ( int i = 0; i < rows; i++)
        {
            accumulator += Array [i, j];
        }
        result [j] = accumulator / rows;
    }

    return result;
}

int columns, rows;

Console.Clear();

Console.WriteLine($"Enter number of columns: ");
columns = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Enter number of rows: ");
rows = int.Parse(Console.ReadLine()!);

int [,] Array = FillArray(rows, columns, -100, 100);
Console.WriteLine($"Values of the array items are:");
WriteArray (Array);

double [] ariphmeticMeansRow = FindAriphmeticMeanByColumns( Array );
Console.WriteLine($"Values of ariphmetic means by columns are: ");
WriteArray1D (ariphmeticMeansRow);
