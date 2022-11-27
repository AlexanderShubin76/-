// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите целочисленное значение N > 1: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
{
    System.Console.Write("Некорректное значение. Введите целочисленное значение N > 1: ");
}
ShowNumbers(n);
void ShowNumbers(int number, int a = 1)
{
    System.Console.Write($"{number}");

    if (number == a)
        return;

    System.Console.Write(", ");
    ShowNumbers(number - 1);
}