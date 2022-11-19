// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] array = GetArrayRandom(3,4);
PrintArray(array);
System.Console.Write("Введите номер строки в двумерном массиве: ");
int row = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите номер столбца в двумерном массиве: ");
int col = int.Parse(Console.ReadLine()!);
FindElementInArray(array, row, col);

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

void FindElementInArray(int[,] massive, int row, int col)
{
    
    if(row>=0 && row < massive.GetLength(0)
    && col>=0 && col < massive.GetLength(1))
        System.Console.WriteLine($"Значение элемента в двумерном массиве по позиции [{row}, {col}] составляет {massive[row, col]}");

    else System.Console.WriteLine("Такой позиции в массиве нет");
}