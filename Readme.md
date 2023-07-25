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

