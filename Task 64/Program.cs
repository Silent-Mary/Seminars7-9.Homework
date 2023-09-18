/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */ 

Console.Clear();

void PrintNaturalNumbers(int N)
{
    if (N != 0)
    {
        Console.Write(N + " ");
        PrintNaturalNumbers(N - 1);
    }
}

Console.Write("Enter an integer: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
PrintNaturalNumbers(Number);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine();
