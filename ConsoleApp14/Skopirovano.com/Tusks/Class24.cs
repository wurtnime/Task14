using System;

namespace ConsoleApp
{
    class Class24
    {
        public static void Task24()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = SumOfSecondRow(array);
            Console.WriteLine($"Сумма элементов второй строки: {sum}");
        }

        private static int SumOfSecondRow(int[,] array)
        {
            int cols = array.GetLength(1);
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += array[1, j];
            }

            return sum;
        }
    }
}