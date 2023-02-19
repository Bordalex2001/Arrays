using System;

namespace Homework
{
    class Task2
    {
        static void Main()
        {
            int[,] arr = new int[5, 5];
            Random r = new Random();
            int min = 0;
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                    Console.Write("{0,5}", arr[i, j]);
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMinimum element = {0}", min);
            Console.WriteLine("Maximum element = {0}", max);
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (sum > min && sum < max)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of numbers (except min, max) = {0}", sum);
        }
    }
}