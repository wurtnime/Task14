using System;

namespace ConsoleApp
{
    class Class10
    {
        public static void Task10()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] oddCounts = CountOddElements(array);
            for (int i = 0; i < oddCounts.Length; i++)
            {
                Console.WriteLine($"Количество нечетных элементов в столбце {i + 1}: {oddCounts[i]}");
            }
        }

        private static int[] CountOddElements(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] counts = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
                counts[j] = count;
            }

            return counts;
        }
    }
}