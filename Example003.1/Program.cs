// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Сделал для любых матриц

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

int[,] ProductOfTwoMatrices (int[,] array1, int[,]array2)
{
    int[,] productOfMatrices = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            productOfMatrices[i,j] = 0;
            for (int m = 0; m < array1.GetLength(1); m++)
            {
                productOfMatrices[i,j] += array1[i, m] * array2[m, j];
                //c[0,0]=a[0,0]*b[0,0] + a[0,1]*b[1,0] + a[0,2]*b[2,0] = 7*6 + 0*1 + 3*4 = 54 сам себя проверил)))
            }
        }
    }
    return productOfMatrices;
}



int strings1 = ReadInt("number of strings in the matrix1");
int columns1 = ReadInt("number of columns in the matrix1");
Console.WriteLine("The number of strings in matrix2 is equal to the number of columns in matrix1");
Console.WriteLine();
int columns2 = ReadInt("number of columns in the matrix2");
int [,] matrix1 = CreateArray(strings1, columns1);
int [,] matrix2 = CreateArray(columns1, columns2); 
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ProductOfTwoMatrices(matrix1, matrix2));
