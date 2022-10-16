// Задача 4
// Напишите программу, которая принимает на вход три 
// и выдаёт максимальное из этих чисел.

System.Console.Write("Введите число_1: ");
int number_1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_2: ");
int number_2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_3: ");
int number_3 = int.Parse(Console.ReadLine()!);

int max = number_1;
if (max > number_2)
{
    if (max > number_3)
    {
        Console.WriteLine($"Max = {max}");
    }
    else
    {
        Console.WriteLine($"Max = {number_3}");
    }
}
else 
{
    if (number_2 > number_3)
    {
        Console.WriteLine($"Max = {number_2}");
    }
    else 
    {
        Console.WriteLine($"Max = {number_3}");
    }
}