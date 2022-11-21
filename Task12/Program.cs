// Задача 12. Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли первое число квадратом второго.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    return false;
}
bool result = Multiplicity(num1, num2);
Console.WriteLine(result ? "Кратно" : $"Некратно, остаток = {num1 % num2}");