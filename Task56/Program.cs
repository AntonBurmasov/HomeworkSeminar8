﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumOfElements(int[,] matrix)
{
    int IndexOfRowWithMinSum = 0;
    int Sum = 0;
    int RowWithMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum = Sum + matrix[i, j];

        }

        if (i == 0)
        {
            RowWithMinSum = Sum;

        }


        if (RowWithMinSum > Sum)
        {
            RowWithMinSum = Sum;
            IndexOfRowWithMinSum = i;
        }

    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {IndexOfRowWithMinSum}");

}



int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
if (m == 1 || n == 1)
{
    Console.WriteLine("Массив должен быть прямоугольным и состоять больше, чем из одной строки и столбца.");
    return;
}
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
MinSumOfElements(matr);