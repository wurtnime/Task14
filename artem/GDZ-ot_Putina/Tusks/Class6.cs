using System;

namespace WpfApp
{
    public static class Class6
    {
        public static string Task6()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            SwapMaxElements(array, 0, 2);
            return "Массив после обмена наибольшими элементами в первом и третьем столбцах:\n" + ArrayToString(array);
        }

        private static void SwapMaxElements(int[,] array, int col1, int col2)
        {
            int rows = array.GetLength(0);

            int maxCol1 = array[0, col1];
            int maxCol2 = array[0, col2];
            int maxRow1 = 0;
            int maxRow2 = 0;

            for (int i = 1; i < rows; i++)
            {
                if (array[i, col1] > maxCol1)
                {
                    maxCol1 = array[i, col1];
                    maxRow1 = i;
                }

                if (array[i, col2] > maxCol2)
                {
                    maxCol2 = array[i, col2];
                    maxRow2 = i;
                }
            }

            int temp = array[maxRow1, col1];
            array[maxRow1, col1] = array[maxRow2, col2];
            array[maxRow2, col2] = temp;
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