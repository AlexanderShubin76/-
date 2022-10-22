// Задача 10:
//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.
int FindSecondNumber(int number)
{
    return ((number / 10) % 10);
}
System.Console.Write("Введите трехзначное число: ");
int number_1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(FindSecondNumber(number_1));