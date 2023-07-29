using System;

namespace Lab
{
    class Task1
    {
        static void Main()
        {
            int[] arr = new int[10];
            Random r = new Random();
            int even = 0;
            int uneven = 0;
            int unique = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-20, 20);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
                if (i % 2 == 0)
                {
                    even++;
                }
                if (i % 2 != 0)
                {
                    uneven++;
                }
                if (Array.IndexOf(arr, i) == Array.LastIndexOf(arr, i))
                {
                    unique++;
                }
            }
            Console.WriteLine("\nEven numbers: {0}", even);
            Console.WriteLine("Uneven numbers: {0}", uneven);
            Console.WriteLine("Unique numbers: {0}", unique);
        }
    }
}
