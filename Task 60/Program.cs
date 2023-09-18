/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */ 

Console.Clear();

Console.Write("Enter N of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter depth: ");
int deepness = Convert.ToInt32(Console.ReadLine());
if (column != deepness && row != deepness)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("At least 1 parameter must be the same as depth.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
else 
{
    int[,,] userArray = GetTensor(row, column, deepness);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    PrintTensor(userArray); 
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}


int[,,] GetTensor(int rows, int columns, int depth)
{
    Console.Clear();
    int min = 10;
    int max = 99;
    int[,,] array = new int[rows, columns, depth];
    for (int X = 0; X < array.GetLength(0); X++)
    {
        for (int Y = 0; Y < array.GetLength(1); Y++)
        {
            for (int Z = 0; Z < array.GetLength(2); Z++)
            {
                bool noRepetition;
                int random = 0;
                do
                {
                    noRepetition = false;
                    random = new Random().Next(min, max);
                    foreach (var item in array)
                    {
                        if (item == random) noRepetition = true;
                    }
                } while (noRepetition);

                array[X, Y, Z] = random;
            }
        }
    }
    return array;
}

void PrintTensor(int[,,] array)
{
    for (int X = 0; X < array.GetLength(0); X++)
    {
        for (int Y = 0; Y < array.GetLength(1); Y++)
        {
            for (int Z = 0; Z < array.GetLength(2); Z++)
            {
                Console.WriteLine($"array[{X}, {Y}, {Z}] = {array[Z, Y, Z]}");
            }
        }
    }
}


