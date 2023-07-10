// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNum(int num)
// {
//     int result = (num % 100 - num % 10) / 10;
//     return result;
// }

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = SecondNum(number);
// Console.Write($"Вторая цифра числа {number} - это {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdNum(int num)
// {
//     int result = -9999;
//     if (num >= 100)
//     {
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         result = num % 10;
//     }
//     return result; 
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = ThirdNum(number);
// if(result == -9999)Console.Write($"У числа {number} третьей цифры нет");
// else Console.Write(result);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool WeekendDay(int num)
// {
//     if(num == 6 || num == 7) return true;
//     else return false;
// }

// int number = Convert.ToInt32(Console.ReadLine());
// bool result = WeekendDay(number);
// Console.Write(result);