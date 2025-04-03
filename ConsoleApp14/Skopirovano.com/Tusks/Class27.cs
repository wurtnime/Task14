using System;

namespace ConsoleApp
{
    class Class27
    {
        public static void Task27()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = SumOfOddElements(array);
            Console.WriteLine($"Сумма нечетных элементов: {sum}");
        }

        private static int SumOfOddElements(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }
    }
}