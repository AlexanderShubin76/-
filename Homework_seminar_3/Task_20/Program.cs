// Задача 21:
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.Clear();
void FindDistance (double ax, double ay, double bx, double by)
{
    double segment1 = ax - bx;
    double segment2 = ay - by; 
    double distanceSquare= Math.Pow(segment1, 2) + Math.Pow(segment2, 2);
    System.Console.WriteLine(Math.Sqrt(distanceSquare));
}

int number;
while(int.TryParse(Console.ReadLine(), out number) && number == 1)
{
    System.Console.Write("Введите координату точки A по оси абсцисс: ");
    double ax1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки A по оси ординат: ");
    double ay1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки В по оси абсцисс: ");
    double bx1 = double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите координату точки A по оси ординат: ");
    double by1 = double.Parse(Console.ReadLine()!);
    FindDistance (ax1, ay1, bx1, by1);
}