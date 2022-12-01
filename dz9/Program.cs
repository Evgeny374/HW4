// Задача 64: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
// M = 5; N = 1. -> "5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(m,n);

void PrintNumbers(int m, int n)
{
    Console.Write($"{m}, ");
    if (m == n) return;
    PrintNumbers(m - 1, n);
}

// 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.Clear();
// Console.WriteLine("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите N: ");
// int n = int.Parse(Console.ReadLine());


// SumDigit(n, m);

// int SumDigit(int n, int m)
// {

//     int start = m;
//     int end = n;
//     if (m > n)
//     {
//         start = n;
//         end = m;
//     }
//     return (end + start) * (end - start + 1) / 2; 
// }

// Console.WriteLine(SumDigit(n, m));


// Задача 68: Напишите программу вычисления функции Аккермана
// //  с помощью рекурсии. Даны два неотрицательных числа m и n. 
// // m = 2, n = 3 -> A(m,n) = 29

// Console.Write("Введите число n : ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите число m : ");
// int m = int.Parse(Console.ReadLine());
// Ackermann(m, n);

// int Ackermann(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Ackermann(m - 1, 1);
//     if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
//     return Ackermann(m, n);
// }

// Console.WriteLine($"{Ackermann(m, n)}");
