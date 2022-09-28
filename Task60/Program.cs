// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)





    int leftRange = -10; int rightRange = 10;


    int[,,] Matrix3D = new int[2, 2, 2];
    int[] array = new int[8];

    Random rand = new Random();
     
    for(int i = 0; i < array.Length; i++)
    { int number = rand.Next(leftRange, rightRange +1);
      array[i] = number;
      if(i > 0)
      {
      for(int j = 0; j < i; j++)
      {
        if(array[i] == array[j])
        {
          i = i - 1; 
         
        }
      }
      }
    }
     int count = 0;

 for(int i = 0; i < Matrix3D.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix3D.GetLength(1); j++)
        {
            for(int q = 0; q < Matrix3D.GetLength(2); q++)
            {
            Matrix3D[i,j,q] = array[count];
              Console.WriteLine($"{Matrix3D[i, j, q]} ({i}, {j}, {q})");
             count++;
            }


        }
    }




