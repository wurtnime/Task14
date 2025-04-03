using System;

namespace ConsoleApp
{
    class Class13
    {
        public static void Task13()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] maxElements = FindMaxElements(array);
            for (int i = 0; i < maxElements.Length; i++)
            {
                Console.WriteLine($"Наибольший элемент в столбце {i + 1}: {maxElements[i]}");
            }
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