// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите целочисленное значение m >= 0: ");
int m1;
while (!int.TryParse(Console.ReadLine(), out m1) || m1 < 0)
{
    System.Console.Write("Некорректное значение. Введите целочисленное значение m >= 0: ");
}

Console.Write("Введите целочисленное значение n >= 0: ");
int n1;
while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0)
{
    System.Console.Write("Некорректное значение. Введите целочисленное значение n >= 0: ");
}
System.Console.WriteLine(FunAckermann(m1, n1));

int FunAckermann(int m, int n)
{
    if (m == 0)
        return (n + 1);

    if (n == 0)
        return FunAckermann(m - 1, 1);

    return FunAckermann(m - 1, FunAckermann(m, n - 1));

}