// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
const int cellWidth = 5;
int rows = 3;
int cols = 3;
int[,] matrix1 = GetArrayRandom(rows, cols);
int[,] matrix2 = GetArrayRandom(rows, cols);

PrintArray(matrix1);
System.Console.WriteLine();

PrintArray(matrix2);
System.Console.WriteLine();


int[,] matrix3 = GetResultingMatrix(matrix1, matrix2, rows, cols);
PrintArray(matrix3);

int[,] GetArrayRandom(int rows, int cols, int minvalue = 0, int maxvalue = 9)
{
    int[,] massive = new int[rows, cols];
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
            System.Console.Write($"{massive[i, j],cellWidth}");
        }
        System.Console.WriteLine();
    }
}

int[,] GetResultingMatrix(int[,] arrayRows, int[,] arrayCols, int rows, int cols)
{
    int[,] array3 = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                array3[i, j] += arrayRows[i, k] * arrayCols[k, j];
            }
        }
    }
    return array3;
}