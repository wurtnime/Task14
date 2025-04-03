using System;

namespace ConsoleApp
{
    class Class16
    {
        public static void Task16()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int product = ProductOfFirstRow(array);
            Console.WriteLine($"Произведение элементов первой строки: {product}");
        }

        private static int ProductOfFirstRow(int[,] array)
        {
            int cols = array.GetLength(1);
            int product = 1;

            for (int j = 0; j < cols; j++)
            {
                product *= array[0, j];
            }

            return product;
        }
    }
}