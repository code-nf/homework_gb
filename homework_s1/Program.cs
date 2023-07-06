/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1 < num2)
{
    max = num2;
}
Console.WriteLine($"max = {max}");
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1 < num2) max = num2;
if (num2 < num3) max = num3;
if (num1 < num3) max = num3;

Console.WriteLine(max);
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;

if (result == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= num)
{
    if(current % 2 == 0) Console.Write(current + ", ");
    current++;
}
*/
