// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
PrintArray(GetArrayRandom(array));
FindRowMinSum(array);

int[,] GetArrayRandom(int[,] massive, int minvalue = 0, int maxvalue = 9)
{

    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            massive[i, j] = rnd.Next(minvalue, maxvalue + 1);
        }
    }
    return massive;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FindRowMinSum(int[,] massive)
{
    int sum = 0;
    int minSum = 0;
    string minRow = String.Empty;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            sum += massive[i, j];
        }

        if (sum < minSum || i == 0)
        {
            minSum = sum;
            minRow = (i + 1).ToString();
        }

        else if (sum == minSum)
            minRow += $", {i + 1}";

        sum = 0;
    }
    System.Console.WriteLine("Строка " + minRow + " обладает наименьшей суммой элементов.");
}