// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49



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

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
   int[,] NewMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
   
   for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        { 

           NewMatrix[i, j] = matrix1[i,j] * matrix2[i,j];


        }

    }

 return NewMatrix;


}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");

int[,] FirstMatr = GetMatrix(m, n);
PrintMatrix(FirstMatr);
Console.WriteLine("");

int[,] SecondMatr = GetMatrix(m, n);
PrintMatrix(SecondMatr);
Console.WriteLine("");

Console.WriteLine("Произведение элементов двух матриц:");
int[,] NewMatrix = MultiMatrix(FirstMatr, SecondMatr);

PrintMatrix(NewMatrix);