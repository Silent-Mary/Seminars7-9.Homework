/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 

Console.Clear();

int SumInterval(int min, int max)
{
    if (min != max) return min + SumInterval(min + 1, max);
    else return min;
}

Console.Write("Enter starting point: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter ending point: ");
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"> Sum of integers from {start} to {end} is {SumInterval(start, end)}.");
Console.WriteLine();
