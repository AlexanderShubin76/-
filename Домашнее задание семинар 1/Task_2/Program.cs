// Задача 2
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

System.Console.Write("Введите число_1: ");
int number_1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_2: ");
int number_2 = int.Parse(Console.ReadLine()!);
int max = number_1;
if (max > number_2)
{
    System.Console.WriteLine($"max = {number_1}");
}
else
{
    System.Console.WriteLine($"max = {number_2}");
}