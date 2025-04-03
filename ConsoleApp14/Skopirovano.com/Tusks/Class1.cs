using System;

namespace ConsoleApp
{
    class Class1
    {
        public static void Task1()
        {
            int[,] array = {
                { 5, 2, 9, 1 },
                { 3, 8, 7, 4 },
                { 6, 0, 2, 3 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SortLastRow(array);

            Console.WriteLine("Массив после сортировки последней строки:");
            PrintArray(array);
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