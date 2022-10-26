// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void FindCube(int number)
{
    for (int i = 1; i < number; i++)
    {
        System.Console.Write($"{Math.Pow(i,3)}, ", "");                   
    }
    System.Console.WriteLine($"{Math.Pow(number,3)}");
}

int number1;
while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N");
    int numberN = int.Parse(Console.ReadLine()!);
    FindCube (numberN);
}

