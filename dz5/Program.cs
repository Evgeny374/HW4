// Задача 34.
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(5, -100, 1000);
// ShowArray(myArray);

// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] % 2 == 0)
//     count++;
// }
// Console.WriteLine($"{count}: четные числа в массиве");


// Задача 36.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(10, -100, 100);
// ShowArray(myArray);

// int sum = 0;
// for (int i = 1; i < myArray.Length; i+=2)
// {
//     sum = sum + myArray[i];
// }
// Console.WriteLine($"{sum}: Сумма элементов на нечетной позиции в массиве");


// Задача 38.
// Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Пример: [3 7 22 2 78] -> 76

double[] CreateRandomArray(int N, double start, double end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = Convert.ToDouble(new Random().Next(-10,100)) / 10; 
    }  
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] myArray = CreateRandomArray(10, -10, 10);
ShowArray(myArray);

double MaxNumber = myArray[0];
double MinNumber = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > MaxNumber)
    {
        MaxNumber = myArray[i];
    }
    else if (myArray[i] < MinNumber)
    {
        MinNumber = myArray[i];
    }
}
Console.WriteLine($"{MaxNumber} максимальное чиcло в массиве;");
Console.WriteLine($"{MinNumber} минимальное число в массиве");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива:{MaxNumber - MinNumber}");