// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
const int cellWidth = 4;
int size = 4;
int[,] spiralArray = new int[size, size];

PrintArray(GetArraySpiralOrder(spiralArray, size));


int[,] GetArraySpiralOrder(int[,] massive, int size)
{
    int i = 0;
    int j = 0;
    for (int number = 1; number <= size * size; number++)
    {
        massive[i, j] = number;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
    }
    return massive;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            System.Console.Write($"{massive[i, j],cellWidth}");
        }
        System.Console.WriteLine();
    }
}