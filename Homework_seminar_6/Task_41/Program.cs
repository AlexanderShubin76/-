// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите числа через запятую: ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);
System.Console.WriteLine($"[{string.Join(", ", numbers)}]");

CountNumbers(numbers);

int[] GetArrayFromString(string str)
{
    int length = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ',')
        {
            length++;
        }
    }

    int[] array = new int[length];
    int k = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string temp = string.Empty;
        while (str[i] != ',')
        {
            if (i != str.Length - 1)
            {
                temp += str[i].ToString();
                i++;
            }

            else
            {
                temp += str[i].ToString();
                break;
            }
        }
        
        array[k] = int.Parse(temp);
        k++;
    }
    return array;
}

void CountNumbers(int[] numbers)
{
    int count = 0;
    foreach (var item in numbers)
    {
        if (item > 0)
            count++;
    }

    System.Console.WriteLine($"В заданном массиве больше '0': {count} чисел");
}
