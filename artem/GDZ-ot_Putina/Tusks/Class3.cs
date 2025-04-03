using System;

namespace WpfApp
{
    public static class Class3
    {
        public static string Task3()
        {
            int[,] array = {
                { 1, -2, 3 },
                { 4, 5, -6 },
                { 7, 8, 9 }
            };

            double[] averages = CalculateColumnAverages(array);
            string result = "Среднее арифметическое каждого столбца:\n";
            for (int i = 0; i < averages.Length; i++)
            {
                result += $"Столбец {i + 1}: {averages[i]}\n";
            }

            return result;
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