// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void FindDistance (double ax, double ay, double az, double bx, double by, double bz)
{
    double segment1 = ax - bx;
    double segment2 = ay - by;
    double segment3 = az - bz;
    double distance = Math.Sqrt(Math.Pow(segment1, 2) + Math.Pow(segment2, 2) + Math.Pow(segment3, 2));
    System.Console.WriteLine(distance);
}

int number;
while(int.TryParse(Console.ReadLine(), out number) && number == 1)
{
    System.Console.Write("Введите координату точки A по оси абсцисс: ");
    double ax1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки A по оси ординат: ");
    double ay1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки A по оси аппликат: ");
    double az1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки В по оси абсцисс: ");
    double bx1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки В по оси ординат: ");
    double by1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки В по оси аппликат: ");
    double bz1 = double.Parse(Console.ReadLine()!);
    FindDistance (ax1, ay1, az1, bx1, by1, bz1);
}