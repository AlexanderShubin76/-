// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
void CheckNumber(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        System.Console.WriteLine("Да");
    }

    else System.Console.WriteLine("Нет");
}

System.Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
CheckNumber(number1);
