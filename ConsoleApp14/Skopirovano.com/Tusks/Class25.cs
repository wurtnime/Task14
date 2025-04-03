using System;

namespace ConsoleApp
{
    class Class25
    {
        public static void Task25()
        {
            int[,] array = {
                { 1, -2, 3 },
                { 4, -5, 6 },
                { 7, -8, 9 }
            };

            int count = CountNegativeElementsInSecondColumn(array);
            Console.WriteLine($"Количество отрицательных элементов во втором столбце: {count}");
        }

        private static int CountNegativeElementsInSecondColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 1] < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}