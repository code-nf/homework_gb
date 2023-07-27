// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ExponentiationNum(int number, int degree)
// {
//     int result = number;
//     for(int count = 1; count < degree; count++)
//     {
//         result = result * number;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input degree: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// Console.Write(ExponentiationNum(number, degree));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigits(int number)
// {
//     int sum = 0;
//     for(int count = 1; number > 0; count++)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write(SumDigits(number));


// // Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

int ReadInt (string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

int[] CreateArray(int size)
    {
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        array[i] = ReadInt($"Введите число в {i} индекс массива");
        return array;
    }    

    void ShowArray(int[]array)
    {
        for( int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
    }


    int size = ReadInt("Введите количество элементов в массиве");
    int[]myArray = CreateArray(size);
    ShowArray(myArray);