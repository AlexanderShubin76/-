// Задача 15:
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void ShowRestDay(int dayWeek) 
{
    if (dayWeek == 6 || dayWeek == 7) 
    System.Console.WriteLine("Да");

    if (dayWeek < 6)
    System.Console.WriteLine("Нет");

    else if (dayWeek < 1 || dayWeek > 7) 
    System.Console.WriteLine("Некорректное значение");
}

System.Console.Write("Введите число: ");
int dayNumber = int.Parse(Console.ReadLine()!);
ShowRestDay(dayNumber);