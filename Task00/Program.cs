﻿// Зачада 0. Напишите программу, которая
// 1. На вход принимает число и
// 2. Выдает его квадрат (число умноженное само на себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");

