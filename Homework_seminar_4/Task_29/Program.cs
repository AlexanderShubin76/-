// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void GetArrayFromString(string str)
{
    string str1 = String.Empty;
    char a = ',';
    char b = ' ';
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == a || str[i] == b) 
            str1 += $"";
        

        else str1 += $"{str[i]}";
    }

    int [] array = new int[str1.Length];
    for (int i = 0; i < str1.Length; i++)
    {
        array[i] = int.Parse(str1[i].ToString());
    }
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int number;
string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);

while (int.TryParse(Console.ReadLine(), out number) && number==1)
{
    Console.Write("Перечислите числа через запятую: ");
    
    GetArrayFromString(Console.ReadLine()!);
    System.Console.WriteLine(text);
}