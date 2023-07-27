/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double[,] CreateRandom2DArrayDouble(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().NextDouble();
    
    return array;
}


void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArrayDouble(rows, columns);
Show2dArray(myArray);*/


/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет

int[,] CreaterandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}

void GetNumberByIndexesIn2DArray(int[,] array)
{
    Console.Write("Input index rows: ");
    int indexRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index columns: ");
    int indexColumns = Convert.ToInt32(Console.ReadLine());

    if(indexRows < array.GetLength(0) && indexColumns < array.GetLength(1))
        Console.Write($"The number in the array with indexes {indexRows} and {indexColumns} is {array[indexRows,indexColumns]}");
    else Console.Write($"There are no numbers in the array with indexes {indexRows} and {indexColumns}");
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterandomArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine();

GetNumberByIndexesIn2DArray(myArray);*/


/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreaterandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }

}

double[] AverageColumnNumbers(int[,] array)
{
    double[] averageArray = new double[array.Length];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        double result = sum / averageArray.Length;
        averageArray[j] = result;
    }
    return averageArray;
}

void ShowDoubleArray(double[]array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreaterandomArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine();
double[] averageArray = AverageColumnNumbers(myArray);
ShowDoubleArray(averageArray);

