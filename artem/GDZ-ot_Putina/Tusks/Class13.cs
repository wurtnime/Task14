using System;

namespace WpfApp
{
    public static class Class13
    {
        public static string Task13()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] maxElements = FindMaxElements(array);
            string result = "Наибольший элемент в каждом столбце:\n";
            for (int i = 0; i < maxElements.Length; i++)
            {
                result += $"Столбец {i + 1}: {maxElements[i]}\n";
            }

            return result;
        }

        private static int[] FindMaxElements(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] maxElements = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int max = array[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                maxElements[j] = max;
            }

            return maxElements;
        }
    }
}