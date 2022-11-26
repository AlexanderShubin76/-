// Задача 60. ...Сформируйте трёхмерный массив из
// неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int cols = 2;
int planes = 2;

int[] array1D = GetArray1D(rows, cols, planes);
System.Console.WriteLine(String.Join(", ", array1D));

System.Console.WriteLine(String.Join(", ", Fill1DMassive(array1D)));

int[,,] array3D = GetArray3DRandom(Fill1DMassive(array1D), rows, cols, planes);
PrintArray(array3D);

int[] GetArray1D(int rows, int cols, int planes, int minvalue = 10, int maxvalue = 99)
{
    int length = rows * cols * planes;
    int[] massive = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        massive[i] = rnd.Next(minvalue, maxvalue + 1);
    }
    return massive;
}

int[] Fill1DMassive(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        for (int j = 0; j < massive.Length; j++)
        {
            if (massive[i] == massive[j] && i != j)
            {
                massive[i]++;
                i -= 1;
                break;
            }
        }
    }
    return massive;
}

int[,,] GetArray3DRandom(int[] massive1D, int rows, int cols, int planes)
{
    int[,,] massive3D = new int[rows, cols, planes];
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < planes; k++)
            {
                massive3D[i, j, k] = massive1D[index];
                index++;
            }
        }
    }
    return massive3D;
}

void PrintArray(int[,,] massive3D)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < planes; k++)
            {
                System.Console.Write($"{massive3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
