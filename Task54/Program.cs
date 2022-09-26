// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
//  возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void OrderedArray(int[,] matrix)
{   
    
    int temp = 0;
    int a = 0;
    int b = 0;
    int x = 0;
    int y = 1;
     for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for(int j = 0; j < matrix.GetLength(1) * matrix.GetLength(1); j++)
        {
            while(y < matrix.GetLength(1))
            {
              if(matrix[a,b]> matrix[x,y])
              {
              temp = matrix[x,y];
              matrix[x,y] = matrix[a,b];
              matrix[i,j] = temp;
              y++;
              b++;
              }
            }
        } 
        a++;   
        x++;
      }

}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
OrderedArray(matr);
PrintMatrix(matr);



