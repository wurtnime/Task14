using System;

namespace WpfApp
{
    public static class Class10
    {
        public static string Task10()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] oddCounts = CountOddElements(array);
            string result = "Количество нечетных элементов в каждом столбце:\n";
            for (int i = 0; i < oddCounts.Length; i++)
            {
                result += $"Столбец {i + 1}: {oddCounts[i]}\n";
            }

            return result;
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