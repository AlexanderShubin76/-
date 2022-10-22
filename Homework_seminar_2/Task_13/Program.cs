// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void FindThirdNumber(int number)
{
    number = Math.Abs(number); 

    if (number < 100)
    System.Console.WriteLine("Третьей цифры нет");

    else
    {
        while (number >= 1000)
        {
            number = number / 10;
        }
        System.Console.WriteLine($"{number % 10}");
    }
}

System.Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
FindThirdNumber(number1);

// System.Console.Write("Введите число: ");
// int number = Math.Abs(int.Parse(Console.ReadLine()!));
// if (number < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// if (number>=100)
// {
// while (number >= 1000)
// {
// number = number / 10;
// }
// System.Console.WriteLine( $"{number % 10}");}
