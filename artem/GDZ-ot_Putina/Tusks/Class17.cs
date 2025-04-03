using System;

namespace WpfApp
{
    public static class Class17
    {
        public static string Task17()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] rowSums = SumOfEachRow(array);
            string result = "Сумма элементов каждой строки:\n";
            for (int i = 0; i < rowSums.Length; i++)
            {
                result += $"Строка {i + 1}: {rowSums[i]}\n";
            }

            return result;
        }

        private static int[] SumOfEachRow(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] sums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }
                sums[i] = sum;
            }

            return sums;
        }
    }
}