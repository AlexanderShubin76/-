// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArrayRandom(3,4);
PrintArray(array);
FindArithmeticMean(array);

int[,] GetArrayRandom(int rows, int cols, int minvalue = 0, int maxvalue = 9)
{
    int[,] massive = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i,j] = rnd.Next(minvalue, maxvalue+1);
        }
    }
    return massive;
}

void PrintArray(int[,]massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] massive)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    int sum = 0;
    float arithmeticMean;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            sum += massive[i,j];

            if (i == massive.GetLength(0)-1)
            {
                arithmeticMean = (float) sum/massive.GetLength(0);
                System.Console.Write($"{arithmeticMean}; ");
                sum=0;
            }
        }
    }
}