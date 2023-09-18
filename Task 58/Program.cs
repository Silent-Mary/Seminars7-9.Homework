/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */ 

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

int[,] MultiplyMatrix (int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int columns = matrix1.GetLength(1);
    int[,] product = new int[rows, columns];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            product[row, column] = matrix1[row, column] * matrix2[row, column];
        }
    }
    return product;
}

Console.WriteLine("Enter N of rows, N of columns, min N & max N for range: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int min1 = Convert.ToInt32(Console.ReadLine());
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Enter min & max range for the 2nd matrix: ");
int min2 = Convert.ToInt32(Console.ReadLine());
int max2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] userMatrix1 = GetRandomMatrix(rows, columns, min1, max1);
int[,] userMatrix2 = GetRandomMatrix(rows, columns, min2, max2);
Console.ForegroundColor = ConsoleColor.Cyan;
PrintMatrix(userMatrix1);
Console.WriteLine();
PrintMatrix(userMatrix2);
Console.WriteLine(); 

Console.ForegroundColor = ConsoleColor.Green;
PrintMatrix(MultiplyMatrix(userMatrix1, userMatrix2));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(); 
