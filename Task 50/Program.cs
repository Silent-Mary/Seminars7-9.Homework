/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();

int[,] GetRandomMatrix(int row, int column, int start, int end)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(start, end+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < matrixToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();

    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
         for (int j = 0; j < matrixToPrint.GetLength(1); j++)
         {
            System.Console.Write(matrixToPrint[i, j] +"\t");  
         } 
    Console.WriteLine();
    }
}

void GetMatrixElement(int[,] matrix, int row, int column)
{
    if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1)) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Element with index [{row}, {column}] is {matrix[row, column]}.");
    }

    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Such element does not exist.");
    }
}

Console.WriteLine("Enter N of rows, N of columns, min N & max N for range: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Now enter row & column indexes of an element you want: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
int colIndex = Convert.ToInt32(Console.ReadLine());

int[,] userMatrix = GetRandomMatrix(rows, columns, min, max);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
PrintMatrix(userMatrix);
Console.WriteLine();
GetMatrixElement(userMatrix, rowIndex, colIndex);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


