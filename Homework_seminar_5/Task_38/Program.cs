// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
System.Console.WriteLine("Задайте количество чисел в массиве в диапазоне от 2 до 100: ");
int length;
while (!int.TryParse(Console.ReadLine(), out length) || length < 2 || length > 100)
{
    System.Console.WriteLine("Некорректное значение. Введите число от 2 до 100: ");
}

double[] massive = GetArray(length);
PrintArray(massive);

double difference = GetDiffBetweenMinMax(massive);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {difference}");

double[] GetArray (int length, int minValue = 0, int maxValue = 1001)
{
    double[] array = new double[length];
    int randomInteger;
    for (int i = 0; i < array.Length; i++)
    {
        randomInteger = new Random().Next(minValue, maxValue);
        array[i] = new Random().NextDouble() * randomInteger;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Получен массив: [" + string.Join(", ", array) + "]");
}

double GetDiffBetweenMinMax(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array [0];
    for (int k = 1; k < length; k++)
    {
        if (array[k] > maxNumber)
            maxNumber = array[k];

        else if (array[k] < minNumber)
            minNumber = array[k];
    }

    double diff = maxNumber - minNumber;
    return diff;
}
