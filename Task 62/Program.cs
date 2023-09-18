/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */ 
Console.Clear();

System.Console.Write("Enter N of rows & columns: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
System.Console.Write("Enter starting point: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = Spiral(rows, columns, start);
Console.WriteLine();

int[,] Spiral(int rows, int cols, int starts)
{
    int[,] array = new int[rows, cols];             
    int end = rows * cols;                          
    int right = cols - 1;                           
    int bottom = rows - 1;                          
    int left = 0;                                   
    int top = 1;                                    
    int direction = 1;                              
    int y = 0;                                     
    int x = 0;
    int pause = 500;                                

    for (int i = starts; i <= end + starts - 1; i++)
    {
        array[y, x] = i;                            
        PrintCurrent(array, y, x);                  
        Thread.Sleep(pause);                        

        if (direction == 1 && x < right) x++;       
        else if (direction == 1 && x == right)      
        {
            direction = 2;                          
            right--;                                
        }
        if (direction == 2 && y < bottom) y++;      
        else if (direction == 2 && y == bottom)     
        {
            direction = 3;                          
            bottom--;                               
        }
        if (direction == 3 && x > left) x--;        
        else if (direction == 3 && x == left)       
        {
            direction = 4;                          
            left++;                                 
        }
        if (direction == 4 && y > top) y--;         
        else if (direction == 4 && y == top)        
        {
            direction = 1;                          
            top++;                                 
            x++;                                    
        }
    }
    return array;
}

void PrintCurrent(int[,] array, int y, int x)                   
{
    Console.SetCursorPosition(0, 0);  
    Console.ForegroundColor = ConsoleColor.Cyan;                      
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}