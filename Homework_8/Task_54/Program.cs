// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
int cols = 4;
int[,] array = new int[rows, cols];
PrintArray(GetArrayRandom(array));
System.Console.WriteLine();
PrintArray(ArrangeArray(array));

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

int[,] ArrangeArray(int[,] massive)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < cols - j; k++)
            {
                if (k == cols - 1) break;
                
                if (massive[i, k] < massive[i, k + 1])
                    (massive[i, k], massive[i, k + 1]) = (massive[i, k + 1], massive[i, k]);
            }
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