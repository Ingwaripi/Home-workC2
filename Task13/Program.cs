﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (num > 100)
    {
        int num1 = (num % 100) % 10 ;
        Console.WriteLine(num1);
        break;
    }
    else 
    {
        Console.WriteLine("нет");
        break;
    }
}
