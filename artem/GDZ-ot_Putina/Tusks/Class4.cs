using System;

namespace WpfApp
{
    public static class Class4
    {
        public static string Task4()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int min = FindMinOnSecondaryDiagonal(array);
            return $"Наименьший элемент на побочной диагонали: {min}";
        }

        private static int FindMinOnSecondaryDiagonal(int[,] array)
        {
            int n = array.GetLength(0);
            int min = array[0, n - 1];

            for (int i = 0; i < n; i++)
            {
                if (array[i, n - 1 - i] < min)
                {
                    min = array[i, n - 1 - i];
                }
            }

            return min;
        }
    }
}