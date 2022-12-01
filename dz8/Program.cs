// Задача 54.
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//  каждой строки двумерного массива.

// Console.Write("Введите количество строк массива: ");
// int row = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = int.Parse(Console.ReadLine());

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array = new int[row, column];

// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < column; j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }
// PrintArray(array);

// void SortMintoMaxArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, j])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// SortMintoMaxArray(array);
// Console.WriteLine();
// PrintArray(array);


// Задача 56. 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//  находить строку с наименьшей суммой элементов.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void GetResultArray(int[,] array)
// {
//     int minSumRow = 0;
//     int minSum = 0;
//     int sum = 0;

//     for (int j = 0; j < columns; j++)
//     {
//         minSum += array[0, j];

//     }
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             sum += array[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             minSumRow = i;
//         }
//         sum = 0;
//     }
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"|{array[minSumRow, j]}");
//     }
//     Console.WriteLine($"|-> Cторка с минимальной суммой номер {minSumRow + 1}");

// }

// Console.WriteLine();
// GetResultArray(array);


// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

// Console.Write("Введите количество строк массива A: ");
// int rowsA = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива A: ");
// int columnsA = int.Parse(Console.ReadLine());
// Console.Write("Введите количество строк массива B: ");
// int rowsB = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива B: ");
// int columnsB = int.Parse(Console.ReadLine());

// if(columnsA!=rowsB)
// {
//   Console.Write("Такие матрицы нельзя перемножить.Попробуйте заново ввести данные "); 
//   return; 
// }

// int[,] A = GetArray(rowsA, columnsA, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MultiplicationABarray(int[,]arrayA, int[,]arrayB)
// {
//     int[,] resultmatrix = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 resultmatrix[i, j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//     }
//     return resultmatrix;
// }
// Console.WriteLine("Результат умножения матриц:");
// PrintArray(MultiplicationABarray(A,B));


// 8 4  10 5
// 6 2  3 10
// 8*10 + 4*3   8*5+ 4*10  92 80
// 6*10+ 2*3   6*5 + 2*10  66 50


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//   добавляя индексы каждого элемента.

// int[,,] array3D = new int[3, 3, 3];
// FillArray(array3D);
// PrintIndex(array3D);

// К сожалению для 4на4на4 массива уже не работает->будут уже трехзначные цифры
// Но задача поставлена так, что задаю свой массив:мой будет 3*3*3

// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }


// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
