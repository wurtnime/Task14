using System;

namespace ConsoleApp
{
    class Class18
    {
        public static void Task18()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int minRowIndex = FindRowWithMinSum(array);
            Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
        }

        private static int FindRowWithMinSum(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int minSum = int.MaxValue;
            int minRowIndex = 0;

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
                    minRowIndex = i;
                }
            }

            return minRowIndex;
        }
    }
}