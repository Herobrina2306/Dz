﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа через энтер");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
        Console.WriteLine($"мах = {a}");
    }
    else
    {
        Console.WriteLine($"max = {c}");
    }
}
else
{
    if(b>c)
    {
        Console.WriteLine($"max = {b}");
    }
    else
    {
        Console.WriteLine($"max = {c}");
    }
}