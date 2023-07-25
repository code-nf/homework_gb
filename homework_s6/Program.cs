// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a number for the index {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void IdentifyPositiveNumbers(int num)
// {
//     int count = 0;
//     int result = 0;
//     for(int i = 0; num > 0 ; i++)
//     {
//         result = num % 10;
//     }
// }

// Console.Write("Input a length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(length);
// ShowArray(myArray);

void Positives() //как говорили, не обязательно всё хранить в памяти и возвращать
{
int count = 0;
Console.WriteLine("Input number of numbers, my number-loving friend:");
int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("Input number, my number-loving friend:");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a > 0) count++;
    }
Console.WriteLine($"Your number of positive numbers in amount of number is {count}");
}

Positives();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
