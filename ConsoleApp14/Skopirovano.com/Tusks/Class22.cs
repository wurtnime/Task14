using System;

namespace ConsoleApp
{
    class Class22
    {
        public static void Task22()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int minSum = FindMinSumOfRows(array);
            Console.WriteLine($"Минимальное значение среди сумм элементов всех строк: {minSum}");
        }

        private static int FindMinSumOfRows(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int minSum = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }

                if (sum < minSum)
                {
                    minSum = sum;
                }
            }

            return minSum;
        }
    }
}