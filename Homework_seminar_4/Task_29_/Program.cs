// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void GetArrayFromString(string str)
{
    int length = 8;
    int [] array = new int[length];
    
    for (int i = 0, k = 0; i < str.Length; i++)
    {
        string symbol = str[i].ToString();
        
        if (symbol == "," || symbol == " ")
        {
            if (symbol == ",")
            {
                k++;
            }
            continue;
        }

        if (k>= length)
        {
            System.Console.WriteLine($"Вы ввели больше {length} чисел. Сохранились первые {length} чисел");
        }
        array[k] = array[k] * 10 + int.Parse(symbol);
    }

    
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int number;
string text = "Введите значение 1 для запуска программы "
+ "или любое другое значение для остановки программы.";

System.Console.WriteLine(text);

while (int.TryParse(Console.ReadLine(), out number) && number==1)
{
    Console.Write("Введите 8 чисел через запятую: ");
    
    GetArrayFromString(Console.ReadLine()!);
    System.Console.WriteLine(text);
}