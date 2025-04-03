using System;

namespace ConsoleApp
{
    class Class11
    {
        public static void Task11()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
            Console.WriteLine($"Количество нечетных чисел: {oddCount}");
        }
    }
}