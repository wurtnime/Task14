using System;

namespace WpfApp
{
    public static class Class1
    {
        public static string Task1()
        {
            int[,] array = {
                { 5, 2, 9, 1 },
                { 3, 8, 7, 4 },
                { 6, 0, 2, 3 }
            };

            SortLastRow(array);
            return "Массив после сортировки последней строки:\n" + ArrayToString(array);
        }

        private static void SortLastRow(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int lastRowIndex = rows - 1;

            int[] lastRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                lastRow[j] = array[lastRowIndex, j];
            }

            Array.Sort(lastRow);

            for (int j = 0; j < cols; j++)
            {
                array[lastRowIndex, j] = lastRow[j];
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