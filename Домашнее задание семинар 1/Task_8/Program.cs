// Задача 8
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число (N): ");
int number_N = int.Parse(Console.ReadLine()!);
int last_number = number_N;
if (last_number % 2 == 0)
{
    last_number = number_N;
}
else
{
    last_number = number_N - 1;
}
int number_before_N = 2;
System.Console.Write($"{number_before_N}, ");
while (number_before_N < last_number - 2)
{
    number_before_N = number_before_N + 2;
    System.Console.Write($"{number_before_N}, ");
}
System.Console.Write($"{last_number}.");