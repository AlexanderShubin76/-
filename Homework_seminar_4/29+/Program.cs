  string input = "1, 22, 333,    4444, 55555, 66, 77, 88";
            //Подразумеваем 8 чисел, но можно взять с клавиатуры
            int length = 8;

            int[] numbers = new int[length];
            
            for (int i = 0, k = 0; i < input.Length; i++)
            {
                //В строку для правильного конвертирования
                //При попытке сконвертировать char будет присвоен код символа из таблицы ASCII
                string symbol = input[i].ToString();
                
                //Пропускаем данные символы
                if (symbol == "," || symbol == " ")
                {
                    //Считаем, что числа точно разделены запятой, но может быть не одним пробелом
                    if (symbol == ",")
                    {
                        k++;
                    }
                    continue;
                }

                if (k >= length)
                {
                    Console.WriteLine($"Вы ввели больше {length} чисел. Сохранились только первых {length} чисел.");
                    break;
                }    

                numbers[k] = numbers[k] * 10 + int.Parse(symbol);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
