using System;

namespace WpfApp
{
    public static class Class5
    {
        public static string Task5()
        {
            int[,] array = {
                { 5, 2, 9, 1 },
                { 3, 8, 7, 4 },
                { 6, 0, 2, 3 }
            };

            SortByLastColumn(array);
            return "Массив после сортировки по последнему столбцу:\n" + ArrayToString(array);
        }

        private static void SortByLastColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (array[i, cols - 1] < array[j, cols - 1])
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = array[i, k];
                            array[i, k] = array[j, k];
                            array[j, k] = temp;
                        }
                    }
                }
            }
        }

        private static string ArrayToString(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i, j] + "\t";
                }
                result += "\n";
            }

            return result;
        }
    }
}