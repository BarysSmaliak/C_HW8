// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int[] SumElementInLine (int[,]array)
{
    Console.WriteLine("Elements sums in the strings:");
    int[]arrayOfLinesSums = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayOfLinesSums[i] += array[i, j];
        }
        Console.Write(arrayOfLinesSums[i] + " ");
    }
    return arrayOfLinesSums;
}

void MinElementsSum (int[]array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"String with minimum sum of elements - " + (minIndex +1));
}


int length1 = ReadInt("number of string in the array 'm'");
int length2 = ReadInt("number of columns in the array 'n'");
int [,] Array = CreateArray(length1, length2);
PrintArray(Array);
Console.WriteLine();
MinElementsSum(SumElementInLine(Array));