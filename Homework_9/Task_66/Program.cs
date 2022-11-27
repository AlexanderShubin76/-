// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целочисленное значение M >= 0: ");
int m1;
while (!int.TryParse(Console.ReadLine(), out m1) || m1 < 0)
{
    System.Console.Write("Некорректное значение. Введите целочисленное значение M >= 0: ");
}

Console.Write("Введите целочисленное значение N > M: ");
int n1;
while (!int.TryParse(Console.ReadLine(), out n1) || n1 <= m1)
{
    System.Console.Write("Некорректное значение. Введите целочисленное значение N > M: ");
}
System.Console.WriteLine(GetSumNumbers(m1, n1));
int GetSumNumbers(int m, int n)
{
    if (m == n)
        return n;

    return m + GetSumNumbers(m + 1, n);
}