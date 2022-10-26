// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Console.Clear();
// void FindCompareDigits (int number)
// {
//     int digit5 = number % 10;
//     int digit4 = number / 10 % 10;
//     int digit3 = number / 100 % 10;
//     int digit2 = number / 1000 % 10;
//     int digit1 = number / 10000 % 10;

// if (digit5 == digit1 && digit4 == digit2)
//     System.Console.WriteLine("Число является палиндромом");

// else System.Console.WriteLine("Число не является палиндромом");
// }

// int number1;
// while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
// {
//     System.Console.WriteLine("Введите число: ");
//     int terminalNumber = int.Parse(Console.ReadLine()!);
//     FindCompareDigits(terminalNumber);
// }
 
//  Решение 2

void FindCompareDigits(string number)
{
    int len = number.Length;
    if (len == 5)
    {
        if (number[0]==number[4] && number[1]==number[3])
        {
            System.Console.WriteLine("Число является палиндромом");
        }
        
        else System.Console.WriteLine("Число не является палиндромом"); 
    }

    else System.Console.WriteLine("Число не является пятизначным");
}

int number1;

while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число: ");
    string terminalNumber = Console.ReadLine()!;
    FindCompareDigits(terminalNumber);
}

