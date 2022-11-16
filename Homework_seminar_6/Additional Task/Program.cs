// Дополнительно. Дан массив. Найдите MEX массива.
// MEX (Minimum Excluded) - минимальный отсутствующий элемент.

System.Console.Write("Введите числа через запятую (от 0 до 100): ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);
System.Console.WriteLine($"[{string.Join(", ", numbers)}]");

int[] sortedNumbers = SortArray(numbers);
System.Console.WriteLine($"[{string.Join(", ", sortedNumbers)}]");

System.Console.WriteLine($"Значение MEX составляет: {FindMEX(sortedNumbers)}");


int[] GetArrayFromString(string str)
{
    int length = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ',')
        {
            length++;
        }
    }

    int[] array = new int[length];
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
        
        array[k] = int.Parse(temp);
        k++;
    }
    return array;
}

int[] SortArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {   
        for (int j = 1; j < numbers.Length-i; j++)
        {
            if (numbers[j] == numbers[j-1])
                { 
                    for (int s = j; s < numbers.Length - 1; s++)    
                    {
                        numbers [s] = numbers [s + 1];
                    }
                    Array.Resize(ref numbers, numbers.Length - 1);
                }
            if (numbers[j] < numbers[j-1])
            {
                int temp = numbers[j-1];
                numbers [j-1] = numbers [j];
                numbers[j] = temp;
            }    
        }
    }        
    return numbers;
}

int FindMEX(int[] array1)
{
        int MEX = 0;

        if (array1[0] != 0)
            return MEX;

        for (int k = 0; k < array1.Length; k++)
        {

            if (array1[k] != array1[^1] && array1[k]+1 != array1[k+1])
            {
                return array1[k]+1;
            }

            if (array1[k] == array1[^1])
                return array1[k]+1;
        }
        return MEX;
    }
