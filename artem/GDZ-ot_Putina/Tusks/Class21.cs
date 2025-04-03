using System;

namespace WpfApp
{
    public static class Class21
    {
        public static string Task21()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] columnSums = SumOfEachColumn(array);
            string result = "Сумма каждого столбца матрицы:\n";
            for (int i = 0; i < columnSums.Length; i++)
            {
                result += $"Столбец {i + 1}: {columnSums[i]}\n";
            }

            return result;
        }

        private static int[] SumOfEachColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] sums = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                sums[j] = sum;
            }

            return sums;
        }
    }
}