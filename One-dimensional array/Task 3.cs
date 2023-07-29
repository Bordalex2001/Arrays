using System;

namespace Lab
{
    class Task3
    {
        static void Main()
        {
            int[] arr = new int[] {8, 5, 2, 9, 11, 16, 8, 5, 2, 14, 23, 18};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{1, 0}", arr[i]);
            }
            Console.WriteLine();
            int[] sequence = new int[3];
            
            Console.WriteLine("\nEnter any three numbers which they are in the array: ");
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }
            int repeats = 0;
            for (int i = 0; i <= arr.Length - sequence.Length; i++)
            {
                bool repeatIsFound = true;
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (sequence[j] != arr[i + j])
                    {
                        repeatIsFound = false;
                        break;
                    }
                }
                if (repeatIsFound)
                {
                    repeats++;
                }
            }
            Console.WriteLine("Repeats: " + repeats);
            Console.WriteLine();
        }
    }
}