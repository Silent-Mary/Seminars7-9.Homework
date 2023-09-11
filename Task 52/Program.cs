/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */ 

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

Console.WriteLine("Enter N of rows, N of columns, min N & max N for range: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] userMatrix = GetRandomMatrix(rows, columns, min, max);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
PrintMatrix(userMatrix);
Console.ForegroundColor = ConsoleColor.White;
