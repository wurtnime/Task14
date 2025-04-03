using System;

namespace ConsoleApp
{
    class Class21
    {
        public static void Task21()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] columnSums = SumOfEachColumn(array);
            for (int i = 0; i < columnSums.Length; i++)
            {
                Console.WriteLine($"Сумма столбца {i + 1}: {columnSums[i]}");
            }
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