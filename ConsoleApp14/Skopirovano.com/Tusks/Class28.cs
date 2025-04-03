using System;

namespace ConsoleApp
{
    class Class28
    {
        public static void Task28()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 },
                { 13, 14, 15 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SwapRows(array, 3, 4);

            Console.WriteLine("Массив после перестановки 4 и 5 строк:");
            PrintArray(array);
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