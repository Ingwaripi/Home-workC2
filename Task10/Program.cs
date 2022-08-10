// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите любое трезначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result_num1 = num % 100;
int result_num2 = result_num1 / 10;
Console.WriteLine(result_num2);