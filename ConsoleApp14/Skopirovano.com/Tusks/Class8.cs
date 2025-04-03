using System;

namespace ConsoleApp
{
    class Class8
    {
        public static void Task8()
        {
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            double product = ProductOfMinElements(array);
            Console.WriteLine($"Произведение наименьших элементов каждого столбца: {product}");
        }

        private static double ProductOfMinElements(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            double product = 1;

            for (int j = 0; j < cols; j++)
            {
                int min = array[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                product *= min;
            }

            return product;
        }
    }
}