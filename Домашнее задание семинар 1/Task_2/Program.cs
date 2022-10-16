// Задача 2
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

System.Console.Write("Введите число_1: ");
double number_1 = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_2: ");
double number_2 = double.Parse(Console.ReadLine()!);
double max = number_1;
if (max > number_2)
{
    System.Console.WriteLine($"max = {number_1}");
}
else
{
    System.Console.WriteLine($"max = {number_2}");
}