/*
Задача 25.
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Пример: 3, 5 -> 243 (3⁵); 2, 4 -> 16
*/

// Console.WriteLine("Введите числа A и B");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (b < 0)
// Console.WriteLine("Введите число В больше нуля");
// else
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine($" Число А в степени В:{result}");
// }


/*
Задача 27.
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример: 452 -> 11; 82 -> 10; 9012 -> 12
*/

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// void GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"Cумма цифр числа: {sum}");
// }
// GetSumNums(n);


/*
Задача 29.
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Пример: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]
*/

// int [] array={0,0,0,0,0,0,0,0};
// int i=0;

// while (i<array.Length)
// {
//     Console.Write($"etner {i+1} digit: ");
//     array[i]=Convert.ToInt32(Console.ReadLine());
//     i++;
// }

// var str=string.Join(" ", array);
// Console.WriteLine(str);
