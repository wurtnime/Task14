using System;

namespace WpfApp
{
    public static class Class25
    {
        public static string Task25()
        {
            int[,] array = {
                { 1, -2, 3 },
                { 4, -5, 6 },
                { 7, -8, 9 }
            };

            int count = CountNegativeElementsInSecondColumn(array);
            return $"Количество отрицательных элементов во втором столбце: {count}";
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