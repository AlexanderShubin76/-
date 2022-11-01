// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Makenumber(int number1, int number2)
{

if (number2 == 0)
    System.Console.WriteLine("1");

else 
    {
    int result = 1;
    
    for (int i = 0; i <number2; i++)
    {
        result *= number1;
    }
    System.Console.WriteLine(result);
    }
    }


string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);
int number;

while (int.TryParse(Console.ReadLine(), out number) && number==1)
{
    Console.Write("Введите число А: ");
    int numberA;
    while (!int.TryParse(Console.ReadLine(), out numberA) || numberA <= 0)
    {
        System.Console.Write("Введите цифру > 0: ");
    }
    

    Console.Write("Введите число B: ");
    int numberB;
   while (!int.TryParse(Console.ReadLine(), out numberB) || numberB < 0)
    {
        System.Console.Write("Введите цифру >= 0: ");
    }

    Makenumber(numberA, numberB);
    System.Console.WriteLine(text);
}