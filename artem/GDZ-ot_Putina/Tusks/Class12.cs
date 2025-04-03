using System;

namespace WpfApp
{
    public static class Class12
    {
        public static string Task12()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int count = CountOccurrences(array, 7);
            return $"Число 7 встречается {count} раз(а)";
        }

        private static int CountOccurrences(int[,] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == number)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}