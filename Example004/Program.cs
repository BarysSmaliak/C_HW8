// Задача 60. ...Сформируйте трёхмерный массив из случайных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int [,,] CreateArray (int length1, int length2, int length3) 
{
    int [,,] array = new int [length1, length2, length3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                array[i, j, m] = new Random().Next(0, 50); // Задал мин и макс значение элементов массива 
            }
            
        }
    }
    return array;
}

void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($" {array[i, j, m]}(" + $" {i}, {j}, {m})");
            }
            Console.WriteLine();
        }
    }
}


PrintArray(CreateArray(2,2,2));