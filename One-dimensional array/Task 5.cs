using System;

namespace Lab
{
    class Task5
    {
        static void Main()
        {
            int[,] arr = new int[3, 6];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = r.Next(-50, 50);
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine();
            }
            int min = arr[0, 0];
            int max = arr[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("\nMinimum element = {0}", min);
            Console.WriteLine("Maximum element = {0}", max);
            Console.WriteLine();
        }
    }
}