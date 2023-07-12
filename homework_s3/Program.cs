/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool IsPalindrome(int num)
{
    int rev_calc = num;
    int rev_num = 0;
    while (rev_calc > 0)
    {
        int r = rev_calc % 10;
        rev_num = rev_num * 10 + r;
        rev_calc = rev_calc / 10;
    }
    return (num == rev_num);
}
Console.Write("input nuber: ");
int num = Convert.ToInt32(Console.ReadLine());
if(IsPalindrome(num) == true) Console.WriteLine("да");
else Console.WriteLine("нет");

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64
*/