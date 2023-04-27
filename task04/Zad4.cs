/// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите число №1:  "); 
int numb1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите число №2:  "); 
int numb2 = int.Parse(Console.ReadLine());
Console.Write("Введите число №3:  "); 
int numb3 = int.Parse(Console.ReadLine());
int max = numb1;
// проверяет какое больше 

if (numb2 > max) 
{ 
    max = numb2;
}
if (numb3 > max)
{ 
    max = numb3;
}
Console.WriteLine("Максимальное значение: " + max); 