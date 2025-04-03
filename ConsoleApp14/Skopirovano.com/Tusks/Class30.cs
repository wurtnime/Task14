using System;

namespace ConsoleApp
{
    class Class30
    {
        public static void Task30()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int count = CountNonNegativeElementsInSecondColumn(array);
            Console.WriteLine($"Количество неотрицательных элементов во втором столбце: {count}");
        }

        private static int CountNonNegativeElementsInSecondColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 1] >= 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}