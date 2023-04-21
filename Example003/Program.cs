// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Сделал для матриц 2х2

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

int[,] ProductOfTwoMatrices (int[,] array1, int[,]array2)
{
    int[,] productOfMatrices = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            productOfMatrices[i,j] = array1[i, 0] * array2[0, j] + array1[i, 1] * array2[1, j];
        }
    }
    return productOfMatrices;
}

int [,] matrix1 = CreateArray(2, 2);
int [,] matrix2 = CreateArray(2, 2); 
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ProductOfTwoMatrices(matrix1, matrix2));