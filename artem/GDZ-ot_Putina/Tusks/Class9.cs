using System;

namespace WpfApp
{
    public static class Class9
    {
        public static string Task9()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            double[] averages = CalculateColumnAverages(array);
            string result = "Среднее арифметическое каждого столбца:\n";
            for (int i = 0; i < averages.Length; i++)
            {
                result += $"Столбец {i + 1}: {averages[i]}\n";
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i, 0];
                int min = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                result += $"Максимум строки {i + 1}: {max}\n";
                result += $"Минимум строки {i + 1}: {min}\n";
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