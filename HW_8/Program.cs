// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] GetArray()
// {
//     int [,] result = new int [rows,columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result [i,j] = new Random().Next(10);
//         }
//     }
//     return result;
// }

// int [,] ChageRows(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int x = 0; x < result.GetLength(1)-1; x++)
//             {
//                 if (result[i,x]<result[i,x+1])
//                 {
//                     int temp = result[i,x+1];
//                     result[i,x+1] = result[i,x];
//                     result[i,x] = temp;
//                 }
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// int [,] matrix = GetArray();
// PrintArray(matrix);

// Console.WriteLine();

// PrintArray(ChageRows(matrix));

// _______________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] GetArray()
// {
//     int [,] array = new int [rows,columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i,j] = new Random().Next(10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// int GetRowNumber (int [,] array)
// {
//     int row = 0;
//     int minSum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minSum = minSum + array[0,i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           sum = sum + array[i,j];
//         }
//         if (minSum > sum)
//         {
//           minSum = sum;
//           row = i;
//         }
//       }
//       return row;
// }

// int [,] matrix = GetArray();
// PrintArray(matrix);

// Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(matrix)+1}");

// ______________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int m = 2;
// int n = 2;

// int [,] GetArray(int [,] array)
// { 
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array [i,j] = new Random().Next(10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < matrix1.GetLength(1); k++)
//       {
//         sum += matrix1[i,k] * matrix2[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int [,] array1 = new int [m,n];
// PrintArray(GetArray(array1));

// Console.WriteLine();

// int [,] array2 = new int [m,n];
// PrintArray(GetArray(array2));

// Console.WriteLine();
// Console.WriteLine("Результирующая матрица будет:");
// Console.WriteLine();

// int [,] resultMatrix = new int [m,n];
// SumMatrix(array1,array2,resultMatrix);
// PrintArray(resultMatrix);


// ____________________________________________________________________

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int [,,] array3D = new int [2,2,2];
// GetArray(array3D);
// PrintIndex(array3D);

// void GetArray(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 array [i,j,z] = new Random().Next(10,100);
//             }
//         }
//     }
// }

// void PrintIndex(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 Console.Write($"{array3D[i,j,z]}({i},{j},{z})  ");
//             }
//         }
//     }
// }


// __________________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];
int count = 0;
int i = 0;
int j = 0;

for (j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = 1 + count;
    count++;
}

j = 3;
for (i = 0; i < array.GetLength(0); i++)
{
    array[i, j] = 1 + count;
    count++;
}

i = 3;
for (j = 2; j >= 0; j -= 1)
{
    array[i, j] = 1 + count;
    count++;
}

j = 0;
for (i = 2; i >= 1; i-=1)
{
    array[i, j] = 1 + count;
    count++;
}

i = 1;
for (j = 1; j <= 2; j ++)
{
    array[i, j] = 1 + count;
    count++;
}

i = 2;
for (j = 2; j >= 1; j -=1)
{
    array[i, j] = 1 + count;
    count++;
}

for (i = 0; i < array.GetLength(1); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("   ");