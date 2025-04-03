using System;

namespace WpfApp
{
    public static class Class28
    {
        public static string Task28()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 },
                { 13, 14, 15 }
            };

            SwapRows(array, 3, 4);
            return "Массив после перестановки 4 и 5 строк:\n" + ArrayToString(array);
        }

        private static void SwapRows(int[,] array, int row1, int row2)
        {
            int cols = array.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                int temp = array[row1, j];
                array[row1, j] = array[row2, j];
                array[row2, j] = temp;
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