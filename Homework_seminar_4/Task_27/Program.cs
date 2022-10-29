// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void GetSumDigitsinNumber(int numberX)
{
string str = numberX.ToString();
int sum = 0;
for (int i = 0; i < str.Length; i++)
{
   sum += int.Parse(str[i].ToString());
}
System.Console.WriteLine(sum);
}

int number;
string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);

while (int.TryParse(Console.ReadLine(), out number) && number==1)
{
    Console.Write("Введите число: ");
    int numberN;
    
    while (!int.TryParse(Console.ReadLine(), out numberN) || numberN < 0)
    {
        System.Console.Write("Введите цифру >= 0: " );
    }

    GetSumDigitsinNumber(numberN);
    System.Console.WriteLine(text);
}