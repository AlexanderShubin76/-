// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

float[,] array = GetArrayRandomFloat(3, 4);
Printarray(array);

float[,] GetArrayRandomFloat(int rows, int cols, int minValue = 0, int maxvalue = 9)
{
    float[,] massive = new float[rows, cols];
    var rnd = new Random();
    int integerRandom;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            integerRandom = rnd.Next(minValue, maxvalue + 1);
            massive[i, j] = (float)rnd.NextDouble() * integerRandom;
        }
    }
    return massive;
}

void Printarray(float[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]}\t");

        }
        System.Console.WriteLine();
    }
}