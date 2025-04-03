using System;

namespace ConsoleApp
{
    class Class14
    {
        public static void Task14()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] indices = FindFirstMinElementIndices(array);
            Console.WriteLine($"Индексы первого наименьшего элемента: [{indices[0]}, {indices[1]}]");
        }

        private static int[] FindFirstMinElementIndices(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int min = array[0, 0];
            int[] indices = new int[2] { 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        indices[0] = i;
                        indices[1] = j;
                    }
                }
            }

            return indices;
        }
    }
}