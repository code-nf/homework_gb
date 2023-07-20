// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int CountEvenInteger(int[] array)
// {
//     int count = 0;
//     for(int i =0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) count ++;
//     }
//     return count;
// }

// Console.Write("Input a length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the minimum possible value of three digits: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the maximum possible value of three digits: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(length, min, max);
// ShowArray(myArray);
// int result = CountEvenInteger(myArray);
// Console.Write($"There are {result} even numbers in the array");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddIndex(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }

// Console.Write("Input a length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the minimum possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the maximum possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(length, min, max);
// ShowArray(myArray);
// int result = SumOddIndex(myArray);
// Console.Write(result);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a number for the index {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

    void ShowArray(double[]array)
    {
        for(int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        Console.WriteLine();
    }
double DifferenceMaxMinNum(double[] array)
{
    double min = array.Min();
    double max = array.Max();
    double result = max - min;
    return result;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(length);
ShowArray(myArray);
double result = DifferenceMaxMinNum(myArray);
Console.Write($"The difference between the minimum and maximum number is {result}");