// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: ");
int numberA=Convert.ToInt32 (Console.ReadLine());
int numberB=Convert.ToInt32 (Console.ReadLine());

if (numberA>numberB)
{
    Console.WriteLine($"{numberA}=max");
}
else 
{
    Console.WriteLine($"{numberB}=max");
}