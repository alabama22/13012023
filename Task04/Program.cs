﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78 
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа:");
int numberA=Convert.ToInt32 (Console.ReadLine());
int numberB=Convert.ToInt32 (Console.ReadLine());
int numberC=Convert.ToInt32 (Console.ReadLine());

if(numberA>numberB && numberA>numberC)
{
    Console.WriteLine($"{numberA}=max");

}
else if (numberB>numberA && numberB>numberC)
{
    Console.WriteLine($"{numberB}=max");
}
else
{
   Console.WriteLine($"{numberC}=max");
}
