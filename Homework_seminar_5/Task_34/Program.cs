// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.Write("Задайте количество чисел в массиве в диапазоне от 2 до 100: ");
int length;
while(!int.TryParse(Console.ReadLine(), out length)|| length > 100 || length < 2)
{
    System.Console.WriteLine("Некорректное значение. Введите число от 2 до 100: ");
}

int[] massive = Getarray(length);
PrintArray(massive);

int result = ShowQuantityOfEvenNumbers(massive);
System.Console.WriteLine($"Количество четных чисел в массиве: {result}");


int [] Getarray(int length, int minValue= 100, int maxValue = 1000)
{
    int [] array = new int [length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray (int[] array)
{
    System.Console.WriteLine("Получен массив: [" + string.Join(", ", array) + "]");
}

int ShowQuantityOfEvenNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
        continue;
    }
    return count;
}
