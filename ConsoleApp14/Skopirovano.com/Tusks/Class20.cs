using System;

namespace ConsoleApp
{
    class Class20
    {
        public static void Task20()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int product = ProductOfPositiveElementsInFirstColumn(array);
            Console.WriteLine($"Произведение положительных элементов первого столбца: {product}");
        }

        private static int ProductOfPositiveElementsInFirstColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int product = 1;

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 0] > 0)
                {
                    product *= array[i, 0];
                }
            }

            return product;
        }
    }
}