// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int result = number % 2;
if (result == 0)
{
    System.Console.WriteLine($"{number} - четное число");
}
else
{
    System.Console.WriteLine($"{number} - нечетное число");
}