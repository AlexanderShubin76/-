// Дополнительно. Дан массив чисел. Напишите функцию, которая ищет 
// заданное число в массиве и показывает нужный индекс в нем. 
// При отсутствии числа возвращать -1.

System.Console.Write("Задайте количество чисел в массиве в диапазоне от 2 до 100: ");
int length;
while(!int.TryParse(Console.ReadLine(), out length)|| length > 100 || length < 2)
{
    System.Console.WriteLine("Некорректное значение. Введите число от 2 до 100: ");
}

int[] massive = GetArray(length);
PrintArray(massive);

System.Console.Write("Задайте чиcло для поиска в массиве в диапазоне от -1000 до 1000: ");
int numberInMassive;
while(!int.TryParse(Console.ReadLine(), out numberInMassive)|| numberInMassive > 1000 || numberInMassive < -1000)
{
    System.Console.WriteLine("Некорректное значение. Введите число от -1000 до 1000: ");
}

int index = FindNumberShowIndex(massive, numberInMassive);
System.Console.WriteLine($"Индекс числа {numberInMassive}: {index}");

int [] GetArray(int length, int minValue = - 1000, int maxValue = 1001)
{
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Получен массив: [" + string.Join(", ", array) + "]");
}

int FindNumberShowIndex(int[] array, int number)
{
    index = -1;
    for (int i = 0; i < length; i++)
    {
        if (array[i] == number)
        {    index = i;
             break;
        }
    }
    return index;
}