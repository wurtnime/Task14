using System;

namespace ConsoleApp
{
    class Class29
    {
        public static void Task29()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int minColIndex = FindColumnWithMinSum(array);
            Console.WriteLine($"Столбец с наименьшей суммой элементов: {minColIndex + 1}");
        }

        private static int FindColumnWithMinSum(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int minSum = int.MaxValue;
            int minColIndex = 0;

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    minColIndex = j;
                }
            }

            return minColIndex;
        }
    }
}