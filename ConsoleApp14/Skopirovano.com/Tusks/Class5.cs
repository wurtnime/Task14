using System;

namespace ConsoleApp
{
    class Class5
    {
        public static void Task5()
        {
            int[,] array = {
                { 5, 2, 9, 1 },
                { 3, 8, 7, 4 },
                { 6, 0, 2, 3 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SortByLastColumn(array);

            Console.WriteLine("Массив после сортировки по последнему столбцу:");
            PrintArray(array);
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