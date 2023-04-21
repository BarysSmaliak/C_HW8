// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int [,] CreateArray (int length1, int length2) 
{
    int [,] array = new int [length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9); // Задал минимальное и максимальное значение элемента массива 
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int ReadInt (string arg)
{
    int num;
    Console.WriteLine($"Input {arg}: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("it,s not a number. Input the correct number");
    }
    return num;
}

int [,] SmallestValueToTheEnd (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = array [i,0];
        int temp=0;

        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i,j] > min)
            {
                temp = array[i,j];
                array[i,j] = array[i,j-1];
                array[i,j-1] = temp;
                
            }
            else
            {
                min = array[i,j];
            }

        }
    }
    return array;
}

int[,] DescendingOrder(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SmallestValueToTheEnd(array);
    }
    return array;
}


int length1 = ReadInt("number of lines in the array 'm'");
int length2 = ReadInt("number of columns in the array 'n'");
int [,] Array = CreateArray(length1, length2);
PrintArray(Array);
Console.WriteLine();
PrintArray(DescendingOrder(Array));