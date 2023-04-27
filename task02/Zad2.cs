// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
 
// a = 5; b = 7 -> max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3 
 
//на вход принимает два числа 
Console.Write("Введите число №1:  "); 
int numb1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите число №2:  "); 
int numb2 = int.Parse(Console.ReadLine()); 
// проверяет какое больше 
if (numb1 > numb2) 
{ 
    Console.Write("Наибольшее число: " + numb1); // выводит больше 
    Console.WriteLine("  Наименьшее число: " + numb2); // выводит наименьшее 
} 
else if (numb2 > numb1) 
{ 
    Console.Write("Наибольшее число: " + numb2); // выводит больше 
    Console.WriteLine("  Наименьшеее число: " + numb1); // выводит наименьшее 
} 
else if (numb1 == numb2) 
{ 
    Console.WriteLine("Введи значения заново ДОЛБАЕБ, ОНИ ОДИНАКОВЫЕ"); 
}
