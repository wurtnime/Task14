using System;

namespace ConsoleApp
{
    class Class7
    {
        public static void Task7()
        {
            int[,] array = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SwapMinElements(array, 0, 2);

            Console.WriteLine("Массив после обмена наименьшими элементами в первой и третьей строках:");
            PrintArray(array);
        }

        private static void SwapMinElements(int[,] array, int row1, int row2)
        {
            int cols = array.GetLength(1);

            int minCol1 = 0;
            int minCol2 = 0;

            for (int j = 1; j < cols; j++)
            {
                if (array[row1, j] < array[row1, minCol1])
                {
                    minCol1 = j;
                }

                if (array[row2, j] < array[row2, minCol2])
                {
                    minCol2 = j;
                }
            }

            int temp = array[row1, minCol1];
            array[row1, minCol1] = array[row2, minCol2];
            array[row2, minCol2] = temp;
        }

        private static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}