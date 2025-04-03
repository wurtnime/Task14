using System;

namespace WpfApp
{
    public static class Class26
    {
        public static string Task26()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] counts = CountElementsInEachColumn(array);
            string result = "Количество элементов в каждом столбце:\n";
            for (int i = 0; i < counts.Length; i++)
            {
                result += $"Столбец {i + 1}: {counts[i]}\n";
            }

            return result;
        }

        private static int[] CountElementsInEachColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] counts = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] != 0)
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