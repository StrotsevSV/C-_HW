﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число: "); // принимаент число
int numb = int.Parse(Console.ReadLine()); // считывает число пользователя
if (numb % 2 == 0) // проверка на четность
{
    Console.WriteLine("Все удалось, число чётное");
}
else
{
    Console.WriteLine("не четное, вводи заново");
}