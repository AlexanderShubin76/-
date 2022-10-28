// Дополнительно.
// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11
void FindPrimeNumbers(int number)
{
    if (number==2)
        System.Console.WriteLine($"2");

    else
    {   
        int[] array = new int[number-1];
        int numberMassive = 2;
    
        for (int i = 0; i < number-1; i++)
        {
            array[i] = numberMassive;
            numberMassive ++;
        }
        
    // System.Console.WriteLine(string.Join(",", array));
    
    
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i + 1 ; j < array.Length; j++)
            {
                if (array[j] % array[i] == 0)
                { 
                    for (int s = j; s < array.Length - 1; s++)    
                    {
                        array [s] = array [s + 1];
                    }
                    Array.Resize(ref array, array.Length - 1);
                }
            }
        }
        System.Console.WriteLine(string.Join(",", array));
    }
}

int number1;
while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N >=2");
    int numberN;

    while(!int.TryParse(Console.ReadLine(), out numberN) || numberN < 2)
    {
        System.Console.WriteLine("Некорректное значение. Введите целое число не меньшее двух.");
    }
    FindPrimeNumbers(numberN);
}