//  Задача 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2;   -1, -7, 567, 89, 223-> 3

// Console.Write("Введите ваши числа через пробел: ");
// int[] numbers = GetArrayFromString(Console.ReadLine());

// Console.WriteLine($"Числа больше нуля: {ResultArray(numbers)}");

// int[] GetArrayFromString(string stringArray) 
// {                                             
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

// int ResultArray(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (numbers[i] > 0) result++;
//     }
//     return result;
// }


//  Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение чисел: b1, k1, b2, k2: ");

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double GetPoint(double b1, double b2, double k1, double k2)
{
    double numberX = 0;
    double numberY = 0;
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        numberX = (b2 - b1) / (k1 - k2);
        numberY = k2 * numberX + b2;
        Console.WriteLine($"Точка пересечения двух прямых: {numberX}{numberY}");
    }
    return numberX;
    return numberY;
}

double getpoint = GetPoint(b1, b2, k1, k2);