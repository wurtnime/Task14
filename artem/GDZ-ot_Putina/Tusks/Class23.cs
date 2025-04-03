using System;

namespace WpfApp
{
    public static class Class23
    {
        public static string Task23()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int count = CountElementsAboveAverage(array);
            return $"Количество элементов, превосходящих среднее арифметическое: {count}";
        }

        private static int CountElementsAboveAverage(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            double average = CalculateAverage(array);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] > average)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static double CalculateAverage(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += array[i, j];
                }
            }

            return (double)sum / (rows * cols);
        }
    }
}