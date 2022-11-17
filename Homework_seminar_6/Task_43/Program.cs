// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
System.Console.WriteLine("Введите последовательно через запятую значения b1, k1, b2, k2: ");

FindIntersectionPoint(GetArrayFromString(Console.ReadLine()!));

int[] GetArrayFromString (string str)
{
    int length = 4;

    int[] massive = new int[length];
    int k = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string temp = string.Empty;
        while (str[i] != ',')
        {
            if (i != str.Length - 1)
            {
                temp += str[i].ToString();
                i++;
            }

            else
            {
                temp += str[i].ToString();
                break;
            }
        }
        
        massive[k] = int.Parse(temp);
        k++;
    }
    return massive;
}

void FindIntersectionPoint(int[] array)
{
    int b1 = array[0];
    int k1 = array[1];
    int b2 = array[2];
    int k2 = array[3];

    float x; float y;
    if (k2 == k1 && b2 != b1)
    {
        System.Console.WriteLine("Прямые параллельны друг другу");
        return;
    }

    if (k2 == k1 && b2 == b1)
        System.Console.WriteLine("Две прямые полностью совпадают, у них бесконечное количество точек пересечения");

    else
    {    
        x = (float) (b2 - b1) / (k1 - k2);
        y = (float) k1 * x + b1;
        System.Console.WriteLine($"Координаты пересечения прямых({x}, {y})");
    }  
}