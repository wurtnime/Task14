using System;

namespace ConsoleApp
{
    class Class2
    {
        public static void Task2()
        {
            int[,] array = {
                { -1, 2, -3 },
                { 4, -5, 6 },
                { -7, 8, -9 }
            };

            int sum = SumOfNegativeOddElements(array);
            Console.WriteLine($"Сумма модулей отрицательных нечетных элементов: {sum}");
        }

        private static int SumOfNegativeOddElements(int[,] array)
        {
            int sum = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] < 0 && array[i, j] % 2 != 0)
                    {
                        sum += Math.Abs(array[i, j]);
                    }
                }
            }

            return sum;
        }
    }
}