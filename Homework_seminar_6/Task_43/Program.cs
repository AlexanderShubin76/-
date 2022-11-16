// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1;
System.Console.Write("Введите целочисленное значение b1 в диапазоне от -1000 до 1000:");
while (!int.TryParse(Console.ReadLine(), out b1) || b1 < -1000 || b1 > 1000)
{
    System.Console.WriteLine("Введено некорректное значение. Введите челочисленное значение b1 в диапазоне от - 1000 до 1000: ");
}

int k1;
System.Console.Write("Введите целочисленное значение k1 в диапазоне от -1000 до 1000:");
while (!int.TryParse(Console.ReadLine(), out k1) || k1 < -1000 || k1 > 1000)
{
    System.Console.WriteLine("Введено некорректное значение. Введите челочисленное значение k1 в диапазоне от - 1000 до 1000: ");
}

int b2;
System.Console.Write("Введите целочисленное значение b2 в диапазоне от -1000 до 1000:");
while (!int.TryParse(Console.ReadLine(), out b2) || b2 < -1000 || b2 > 1000)
{
    System.Console.WriteLine("Введено некорректное значение. Введите челочисленное значение b2 в диапазоне от - 1000 до 1000: ");
}

int k2;
System.Console.Write("Введите целочисленное значение k2 в диапазоне от -1000 до 1000:");
while (!int.TryParse(Console.ReadLine(), out k2) || k2 < -1000 || k2 > 1000)
{
    System.Console.WriteLine("Введено некорректное значение. Введите челочисленное значение k2 в диапазоне от - 1000 до 1000: ");
}

FindIntersectionPoint(k1, b1, k2, b2);

void FindIntersectionPoint(int k1, int b1, int k2, int b2)
{
    float x; float y;
    if (k2 == k1)
    {
        System.Console.WriteLine("Прямые параллельны друг другу");
    }

    else
    {    
        x = (float) (b2 - b1) / (k1 - k2);
        y = (float) k1 * x + b1;
        System.Console.WriteLine($"Координаты пересечения прямых({x}, {y})");
    }
    

    
}