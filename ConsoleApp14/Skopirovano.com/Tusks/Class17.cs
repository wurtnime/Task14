using System;

namespace ConsoleApp
{
    class Class17
    {
        public static void Task17()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] rowSums = SumOfEachRow(array);
            for (int i = 0; i < rowSums.Length; i++)
            {
                Console.WriteLine($"Сумма элементов строки {i + 1}: {rowSums[i]}");
            }
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