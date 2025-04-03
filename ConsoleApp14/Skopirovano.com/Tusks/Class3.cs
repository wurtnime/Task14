using System;

namespace ConsoleApp
{
    class Class3
    {
        public static void Task3()
        {
            int[,] array = {
                { 1, -2, 3 },
                { 4, 5, -6 },
                { 7, 8, 9 }
            };

            double[] averages = CalculateColumnAverages(array);
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {averages[i]}");
            }
        }

        private static double[] CalculateColumnAverages(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            double[] averages = new double[cols];

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                int count = 0;

                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                        count++;
                    }
                }

                averages[j] = count > 0 ? (double)sum / count : 0;
            }

            return averages;
        }
    }
}