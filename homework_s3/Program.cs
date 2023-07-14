/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// bool IsPalindrome(int num)
// {
//     int rev_calc = num;
//     int rev_num = 0;
//     while (rev_calc > 0)
//     {
//         int last_num = rev_calc % 10;
//         rev_num = rev_num * 10 + last_num;
//         rev_calc = rev_calc / 10;
//     }
//     return (num == rev_num);
// }
// Console.Write("input nuber: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(IsPalindrome(num) == true) Console.WriteLine("да");
// else Console.WriteLine("нет");

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// double DistansIn3D(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int A = x2 - x1;
//     int B = y2 - y1;
//     int C = z1 - z2;
//     return Math.Sqrt(A * A + B * B + C * C);
// }

// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(DistansIn3D(x1, y1, z1, x2, y2, z2),2));

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64
*/

// void NumCube(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.WriteLine($"{count} - {count * count * count}");
//         count ++;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// NumCube(num);