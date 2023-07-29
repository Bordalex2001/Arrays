using System;

namespace Lab
{
    class Task2
    {
        static void Main()
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-20, 20);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Enter a maximum number of elements to calculate their sum: ");
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < max)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Sum of elements less than {max}: " + sum);
        }
    }
}