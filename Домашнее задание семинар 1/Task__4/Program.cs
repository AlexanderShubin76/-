// Задача 4
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

System.Console.Write("Введите число_1: ");
double number_1 = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_2: ");
double number_2 = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите число_3: ");
double number_3 = double.Parse(Console.ReadLine()!);

double max = number_1;
// if (max > number_2)
// {
//     if (max > number_3)
//     {
//         Console.WriteLine($"Max = {max}");
//     }
//     else
//     {
//         Console.WriteLine($"Max = {number_3}");
//     }
// }
// else 
// {
//     if (number_2 > number_3)
//     {
//         Console.WriteLine($"Max = {number_2}");
//     }
//     else 
//     {
//         Console.WriteLine($"Max = {number_3}");
//     }
// }
if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}
Console.WriteLine($"Max = {max}");