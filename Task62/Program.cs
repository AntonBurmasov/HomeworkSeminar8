// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

// Делал данную задачу сам, без помощи интернета и решения на семинаре, реализация топорная, но ничего лучше не придумал. 
// На семинаре решение было гораздо удобной и универсальней.


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}       ");
        }
        Console.WriteLine();
    }
}


 int[,] matrix = new int[4, 4];

 int i = 0;
 int j = 0;
 int value = 1;


    while(j< matrix.GetLength(0))
    {
     matrix[i,j] = value;
      value++;
      j++;
    }
     j = j - 1;
     value = value - 1;

    while(i< matrix.GetLength(1))
    {
       matrix[i, j] = value;
      value++;
      i++;

    }
  i = i - 1;
  value = value - 1;
  

   while(j > -1)
    { 
       matrix[i ,j] = value;
      value++;
      j = j - 1;
     
    }

 j = j + 1;
value = value - 1;

 while(i > 0)
 {
  matrix[i,j] = value;
  value++;
  i = i - 1;

}
i = i + 1;
value = value - 1;
 while(j < 3)
 {
  matrix[i,j] = value;
  value++;
  j++;
 }
 j = j - 1;
value = value - 1;

 while(i < 3)
 {
  matrix[i,j]= value;
  value++;
 i++;
 }
 i = i - 1;
 value = value - 1;

 while(j > 0)
 {
  matrix[i,j] = value;
  value++;
  j--;

 }
 

PrintMatrix(matrix);