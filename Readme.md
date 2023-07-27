12345 / 10 = 1234
12345 / 100 = 123
12345 / 1000 = 12
12345 / 10000 = 1

12345 % 10 = 5
12345 % 100 = 45
12345 % 1000 = 345
12345 % 10000 = 2345

void ShowArray(double[]array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

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

int[] CopyArray(int[] array1)
{
    int[] array2 = new int[array1.Length];
    for(int i =0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
    return array2;cd
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

Sem 7

// int[,] CreaterandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;

// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");

//         }

//         Console.WriteLine();

//     }

// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of rows: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreaterandomArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aij = i+j. Выведите полученный массив на экран.

/*int[,] CreaterandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    
    return array;

}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }

        Console.WriteLine();

    }

}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreaterandomArray(rows, columns);
Show2dArray(myArray);*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

/*int[,] CreaterandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}


void ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i = i + 2)
        
        for(int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i,j] *= array[i,j];
        }
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }

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
ChangeArray(myArray);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


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
        {
            Console.Write(array[i,j] + " ");

        }

        Console.WriteLine();

    }

}

int SumIndexMainDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i,i];
    }
    return sum;
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
int result = SumIndexMainDiagonal(myArray);
Console.Write(result);
