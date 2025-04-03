using System;

namespace WpfApp
{
    public static class Class19
    {
        public static string Task19()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int maxRowIndex = FindRowWithMaxSum(array);
            return $"Строка с наибольшей суммой элементов: {maxRowIndex + 1}";
        }

        private static int FindRowWithMaxSum(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int maxSum = int.MinValue;
            int maxRowIndex = 0;

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRowIndex = i;
                }
            }

            return maxRowIndex;
        }
    }
}