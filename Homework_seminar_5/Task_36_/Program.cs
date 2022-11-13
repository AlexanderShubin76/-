// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Write("Задайте количество чисел в массиве в диапазоне от 2 до 100: ");
int length;
while(!int.TryParse(Console.ReadLine(), out length)|| length > 100 || length < 2)
{
    System.Console.WriteLine("Некорректное значение. Введите число от 2 до 100: ");
}

int[] massive = GetArray(length);
PrintArray(massive);
int sum = FindSumOfELements (massive);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");

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

int FindSumOfELements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0)
            result += array[i];
        
    }
    return result;
}