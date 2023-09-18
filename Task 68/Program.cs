/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */ 

Console.Clear();

int Ackermann(int M, int N)
{
    if (M == 0)         return N + 1;
    else if (N == 0)    return Ackermann(M - 1, 1);
    else                return Ackermann(M - 1, Ackermann(M, N - 1));
}

Console.Write("Enter value for M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value for N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m >= 0 && n >= 0) 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"A(m,n) = "+Ackermann(m, n)+".");
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ackermann function doesn't allow negative values.");
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

