// Дополнительно.
// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11
void FindPrimeNumbers(int number)
{
    System.Console.Write("2, ");
    for (int i = 2; i <= number; i++)
    {
        System.Console.Write($"{number}, ", "");
    }
    System.Console.Write($"{number}, ", "");
}

int number1;
while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N");
    int numberN;

    if (int.TryParse(Console.ReadLine(), out numberN) && numberN >= 2)
        FindPrimeNumbers(numberN);
    
    else System.Console.WriteLine("Некорректное значение");
}