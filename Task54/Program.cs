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
    for(int q = 0; q < matrix.GetLength(1); q++)
    {
     for(int i = 0; i < matrix.GetLength(0); i++)
      {  int a = i;
         int b = 0; 
        for(int j = 1; j < matrix.GetLength(1); j++)
        {
            
            if(matrix[i,j]<matrix[a,b])
            {
              temp = matrix[a,b];
              matrix[a,b] = matrix[i,j];
              matrix[i,j] = temp;
              
               
            }
           b++;   
        }
        
        b = 1;
        a++;   
        } 
          
        
      }
}



int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
OrderedArray(matr);
Console.WriteLine("");
PrintMatrix(matr);



