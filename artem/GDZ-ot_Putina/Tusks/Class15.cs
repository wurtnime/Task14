using System;

namespace WpfApp
{
    public static class Class15
    {
        public static string Task15()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = SumOfLastColumn(array);
            return $"Сумма элементов последнего столбца: {sum}";
        }

        private static int SumOfLastColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, cols - 1];
            }

            return sum;
        }
    }
}