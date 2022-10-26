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
    
    
        int s = 0;
        int k = s+1;
        
        while (array[s] <= Math.Sqrt(array[array.Length-1]))
        {

            while (array[k] < array.Length)
            {                          
               
                if (array[k] % array[s] == 0)
                {  
                    array[k-1] = array[k];
                }

                else k=+1;
            }
            s++; 
        }
        System.Console.WriteLine(array); 
    }
}

int number1;
while(int.TryParse(Console.ReadLine(), out number1) && number1 == 1)
{
    System.Console.WriteLine("Введите число N");
    int numberN;

    if (int.TryParse(Console.ReadLine(), out numberN) && numberN >= 2)
        FindPrimeNumbers(numberN);
    
    else System.Console.WriteLine("Некорректное значение");
}
